#pragma checksum "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc9032022f6502902bfc33aeb2bc041d9d890a04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi;

#line default
#line hidden
#line 3 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models;

#line default
#line hidden
#line 4 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 5 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc9032022f6502902bfc33aeb2bc041d9d890a04", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebd87ea481c1599b146960a74ab2e52576419d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 98, true);
            WriteLiteral("\r\n<div class=\"page-consent\">\r\n    <div class=\"row page-header\">\r\n        <div class=\"col-sm-10\">\r\n");
            EndContext();
#line 6 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            BeginContext(185, 45, true);
            WriteLiteral("                <div class=\"client-logo\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 230, "\"", 256, 1);
#line 8 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
WriteAttributeValue("", 236, Model.ClientLogoUrl, 236, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(257, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 9 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(281, 34, true);
            WriteLiteral("            <h1>\r\n                ");
            EndContext();
            BeginContext(316, 16, false);
#line 11 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(332, 180, true);
            WriteLiteral("\r\n                <small>is requesting your permission</small>\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(513, 34, false);
#line 19 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
       Write(Html.Partial("_ValidationSummary"));

#line default
#line hidden
            EndContext();
            BeginContext(547, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(563, 2629, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "128cb72ce1be4cbcadf60cb03257a485", async() => {
                BeginContext(609, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(627, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64a83520212c4ca2b57ac0a56100096c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 22 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(670, 100, true);
                WriteLiteral("\r\n\r\n                <div>Uncheck the permissions you do not wish to grant.</div>\r\n                \r\n");
                EndContext();
#line 26 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                BeginContext(839, 331, true);
                WriteLiteral(@"                    <div class=""panel panel-default consent-buttons"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-user""></span>
                            Personal Information
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 34 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {
                                

#line default
#line hidden
                BeginContext(1308, 37, false);
#line 36 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                           Write(Html.Partial("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 36 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                                                                      
                            }

#line default
#line hidden
                BeginContext(1378, 59, true);
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
                EndContext();
#line 40 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1456, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                BeginContext(1527, 314, true);
                WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-tasks""></span>
                            Application Access
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 50 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {
                                

#line default
#line hidden
                BeginContext(1979, 37, false);
#line 52 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                           Write(Html.Partial("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 52 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                                                                      
                            }

#line default
#line hidden
                BeginContext(2049, 59, true);
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
                EndContext();
#line 56 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2127, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
                BeginContext(2198, 113, true);
                WriteLiteral("                    <div class=\"consent-remember\">\r\n                        <label>\r\n                            ");
                EndContext();
                BeginContext(2311, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7bf68eedbac4fe9932f7519314d5535", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 62 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2373, 131, true);
                WriteLiteral("\r\n                            <strong>Remember My Decision</strong>\r\n                        </label>\r\n                    </div>\r\n");
                EndContext();
#line 66 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2523, 250, true);
                WriteLiteral("\r\n                <div class=\"consent-buttons\">\r\n                    <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\r\n                    <button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\r\n");
                EndContext();
#line 71 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                     if (Model.ClientUrl != null)
                    {

#line default
#line hidden
                BeginContext(2847, 77, true);
                WriteLiteral("                        <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2924, "\"", 2947, 1);
#line 73 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
WriteAttributeValue("", 2931, Model.ClientUrl, 2931, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2948, 120, true);
                WriteLiteral(">\r\n                            <span class=\"glyphicon glyphicon-info-sign\"></span>\r\n                            <strong>");
                EndContext();
                BeginContext(3069, 16, false);
#line 75 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                               Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(3085, 41, true);
                WriteLiteral("</strong>\r\n                        </a>\r\n");
                EndContext();
#line 77 "C:\BootCampProject\GitHub\Assignment3a\EventBash\TokenServiceApi\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3149, 36, true);
                WriteLiteral("                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3192, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
