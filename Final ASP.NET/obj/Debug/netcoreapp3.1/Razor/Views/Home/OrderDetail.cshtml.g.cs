#pragma checksum "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93bc96efdcfa619ca1f4bc3bed6923329e013d4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderDetail), @"mvc.1.0.view", @"/Views/Home/OrderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93bc96efdcfa619ca1f4bc3bed6923329e013d4e", @"/Views/Home/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898d7c7aff7e3d1fc6917caa0237e3b1117348f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.Shared.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
  
    ViewData["Title"] = "Order Detail - " + Model.OrderID;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"display-2\" style=\"text-align: center;\">Order Details</h2>\r\n\r\n  <div class=\"card border-dark mb-3\"; style=\"width: 575px; margin: auto;\">\r\n    <div class=\"card-header\"><h2><b>Order Number - ");
#nullable restore
#line 9 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                              Write(Model.OrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2></div>\r\n    <div class=\"card-body text-dark\">\r\n      <h3><b>Shipping Info</b></h3>\r\n      <hr>\r\n      <h4>Date Shipped</h4>\r\n      <h5 style=\"text-align: right;\">");
#nullable restore
#line 14 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                Write(Model.ShippedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 15 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
       if(@Model.ShipVia == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h4>Shipper</h4>\r\n      <h5 style=\"text-align: right;\">Speedy Express</h5>\r\n");
#nullable restore
#line 18 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
      }else if(@Model.ShipVia == 2){

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h4>Shipper</h4>\r\n      <h5 style=\"text-align: right;\">United package</h5>\r\n");
#nullable restore
#line 21 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
      }else if(@Model.ShipVia == 3){

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h4>Shipper</h4>\r\n      <h5 style=\"text-align: right;\">Federal Shipping</h5>\r\n");
#nullable restore
#line 24 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h4>Shipping Cost</h4>\r\n      <h5 style=\"text-align: right;\">$");
#nullable restore
#line 26 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                 Write(Model.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n      <hr>\r\n      <h3><b>Customer Info</b></h3>\r\n      <hr>\r\n      <h4>Customer Name</h4>\r\n      <h5 style=\"text-align: right;\">");
#nullable restore
#line 31 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                Write(Model.ShipName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n      <h4>Customer Address</h4>\r\n      <h5 style=\"text-align: right;\">");
#nullable restore
#line 33 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                Write(Model.ShipAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 33 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                                     Write(Model.ShipCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n      <h5 style=\"text-align: right;\">");
#nullable restore
#line 34 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                Write(Model.ShipRegion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                                  Write(Model.ShipPostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\OSA Pyro\Downloads\Final Project\Final ASP.NET\Views\Home\OrderDetail.cshtml"
                                                                        Write(Model.ShipCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.Shared.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
