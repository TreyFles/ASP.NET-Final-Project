#pragma checksum "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8446cdeb3f356558dc3da9196b7fb19ef33f7d3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#nullable restore
#line 1 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\_ViewImports.cshtml"
using Final_ASP.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\_ViewImports.cshtml"
using Final_ASP.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8446cdeb3f356558dc3da9196b7fb19ef33f7d3e", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898d7c7aff7e3d1fc6917caa0237e3b1117348f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/delete.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 24px; width: 24px; float: right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Shopping Cart - Northwind";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\Cart.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Product ID</th>\r\n        <th>Product Name</th>\r\n        <th>Product Price</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\Cart.cshtml"
 foreach (CartItem item in Model.Cart.Items)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\Cart.cshtml"
       Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\Cart.cshtml"
       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\Cart.cshtml"
       Write(item.UnitPrice.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8446cdeb3f356558dc3da9196b7fb19ef33f7d3e5471", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </a></td>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 23 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table> \r\n\r\n<script>\r\n</script>\r\n\r\n<div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
