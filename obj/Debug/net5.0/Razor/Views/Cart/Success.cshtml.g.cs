#pragma checksum "E:\Thabis Documents\Projects\NETCore5\paypal_integration\Views\Cart\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85ca4c7e099dd7f06689c40cab6b587d1ae425d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Success), @"mvc.1.0.view", @"/Views/Cart/Success.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ca4c7e099dd7f06689c40cab6b587d1ae425d6", @"/Views/Cart/Success.cshtml")]
    public class Views_Cart_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Thabis Documents\Projects\NETCore5\paypal_integration\Views\Cart\Success.cshtml"
  
    ViewData["Title"] = "PayPal Success";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Payment Successful!</h1>\r\n<p class=\"text-muted\">");
#nullable restore
#line 7 "E:\Thabis Documents\Projects\NETCore5\paypal_integration\Views\Cart\Success.cshtml"
                 Write(ViewBag.paypalResult.PayerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n<p class=\"text-muted\">");
#nullable restore
#line 8 "E:\Thabis Documents\Projects\NETCore5\paypal_integration\Views\Cart\Success.cshtml"
                 Write(ViewBag.paypalResult.PayerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n<p class=\"text-muted\">");
#nullable restore
#line 9 "E:\Thabis Documents\Projects\NETCore5\paypal_integration\Views\Cart\Success.cshtml"
                 Write(ViewBag.paypalResult.PayerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n<p class=\"text-muted\">");
#nullable restore
#line 10 "E:\Thabis Documents\Projects\NETCore5\paypal_integration\Views\Cart\Success.cshtml"
                 Write(ViewBag.paypalResult.InvoiceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n<p class=\"text-muted\">");
#nullable restore
#line 11 "E:\Thabis Documents\Projects\NETCore5\paypal_integration\Views\Cart\Success.cshtml"
                 Write(ViewBag.paypalResult.GrossTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
