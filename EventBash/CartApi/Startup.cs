﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CartApi.Infrastructure.Filters;
using CartApi.Messaging.Consumers;
using CartApi.Models;
using MassTransit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using StackExchange.Redis;
using Swashbuckle.AspNetCore.Swagger;

namespace CartApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<ConnectionMultiplexer>(sp =>
            {
                //var settings = sp.GetRequiredService<IOptions<CartSettings>>().Value;
                var configuration = ConfigurationOptions.Parse(Configuration["ConnectionString"], true);
                //resolving via dns before connecting
                configuration.ResolveDns = true;
                configuration.AbortOnConnectFail = false;
                return ConnectionMultiplexer.Connect(configuration);
            });
            ConfigureAuthService(services);
            //The below code is for swagger.
            services.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Info
                {
                    Title = "Basket HTTP API",
                    Version = "v1",
                    Description = "The Basket Service HTTP API",
                    TermsOfService = "Terms Of Service"
                });
                options.AddSecurityDefinition("oauth2", new OAuth2Scheme
                {
                    Type = "oauth2",
                    Flow = "implicit",
                    AuthorizationUrl = $"{Configuration.GetValue<string>("IdentityUrl")}/connect/authorize",
                    TokenUrl = $"{Configuration.GetValue<string>("IdentityUrl")}/connect/token",
                    Scopes = new Dictionary<string, string>()
                    {
                        { "basket", "Basket Api" }
                    }
                });

                options.OperationFilter<AuthorizeCheckOperationFilter>();

            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ICartRepository, RedisCartRepository>();
            var builder = new ContainerBuilder();

            // register a specific consumer
            builder.RegisterType<OrderCompletedEventConsumer>();

            builder.Register(context =>
            {
                var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
                {


                    var host = cfg.Host(new Uri("rabbitmq://rabbitmq/"), "/", h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });


                    // https://stackoverflow.com/questions/39573721/disable-round-robin-pattern-and-use-fanout-on-masstransit
                    cfg.ReceiveEndpoint(host, "EventBash" + Guid.NewGuid().ToString(), e =>
                    {
                        e.LoadFrom(context);

                    });
                });

                return busControl;
            })
                .SingleInstance()
                .As<IBusControl>()
                .As<IBus>();

            builder.Populate(services);
            ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(ApplicationContainer);
        }

        private void ConfigureAuthService(IServiceCollection services)
        {
            // prevent from mapping "sub" claim to nameidentifier.
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            var identityUrl = Configuration.GetValue<string>("IdentityUrl");

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.Authority = identityUrl;
                options.RequireHttpsMetadata = false;
                options.Audience = "basket";
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
