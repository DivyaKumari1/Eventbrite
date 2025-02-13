#pragma checksum "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02806ea75011063a76d528da737c0f2168d3df64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\_ViewImports.cshtml"
using WebMvc;

#line default
#line hidden
#line 2 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\_ViewImports.cshtml"
using WebMvc.Models;

#line default
#line hidden
#line 2 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
using WebMvc.Models.OrderModels;

#line default
#line hidden
#line 4 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
using WebMvc.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02806ea75011063a76d528da737c0f2168d3df64", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82dfb9e8d9c1e15d2e9f7b4d3cf193b2b540299a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("esh-orders-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
      
        ViewData["Title"] = "My Orders";
    

#line default
#line hidden
            BeginContext(148, 38, true);
            WriteLiteral("    <div class=\"esh-orders\">\r\n        ");
            EndContext();
            BeginContext(187, 172, false);
#line 10 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
   Write(Html.Partial("_Header", new List<Header>() {
        new Header() { Controller = "Catalog", Text = "Back to catalog" },
        new Header() { Text = " / " }
         }));

#line default
#line hidden
            EndContext();
            BeginContext(359, 494, true);
            WriteLiteral(@"
        <div class=""container"">
            <article class=""esh-orders-titles row"">
                <section class=""esh-orders-title col-xs-2"">Order number</section>
                <section class=""esh-orders-title col-xs-4"">Date</section>
                <section class=""esh-orders-title col-xs-2"">Total</section>
                <section class=""esh-orders-title col-xs-2"">Status</section>
                <section class=""esh-orders-title col-xs-2""></section>
            </article>
");
            EndContext();
#line 22 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(910, 118, true);
            WriteLiteral("                <article class=\"esh-orders-items row\">\r\n                    <section class=\"esh-orders-item col-xs-2\">");
            EndContext();
            BeginContext(1029, 42, false);
#line 25 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 74, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-4\">");
            EndContext();
            BeginContext(1146, 44, false);
#line 26 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 76, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-2\">$ ");
            EndContext();
            BeginContext(1267, 45, false);
#line 27 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.OrderTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 74, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-2\">");
            EndContext();
            BeginContext(1387, 46, false);
#line 28 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.OrderStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 100, true);
            WriteLiteral("</section>\r\n                    <section class=\"esh-orders-item col-xs-2\">\r\n                        ");
            EndContext();
            BeginContext(1533, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7b74d67ac9d471a9aa9d68851a7ba07", async() => {
                BeginContext(1637, 6, true);
                WriteLiteral("Detail");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
                                                                                                     WriteLiteral(item.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1647, 62, true);
            WriteLiteral("\r\n                    </section>\r\n                </article>\r\n");
            EndContext();
#line 33 "C:\BootCampProject\GitHub\Assignment3a\EventBash\WebMvc\Views\Order\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1724, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
