#pragma checksum "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e46338327f52cdf68e9141ecc355536d671cdde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Welcome), @"mvc.1.0.view", @"/Views/Products/Welcome.cshtml")]
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
#line 1 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\_ViewImports.cshtml"
using Activity2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\_ViewImports.cshtml"
using Activity2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e46338327f52cdf68e9141ecc355536d671cdde", @"/Views/Products/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684f1b84bb6b99c11472852475c0380ee592a4ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2>Welcome ");
#nullable restore
#line 5 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\Welcome.cshtml"
       Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>today\'s secret number is ");
#nullable restore
#line 6 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\Welcome.cshtml"
                       Write(ViewBag.Secnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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