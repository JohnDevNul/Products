#pragma checksum "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a568af662305df9f105bc1a1f8a9b2f7865f419d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products__productCard), @"mvc.1.0.view", @"/Views/Products/_productCard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a568af662305df9f105bc1a1f8a9b2f7865f419d", @"/Views/Products/_productCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684f1b84bb6b99c11472852475c0380ee592a4ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Products__productCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activity2.Models.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
  
    var s = Model.Name;
    var firstWord = s.IndexOf(" ") > -1 ? s.Substring(0, s.IndexOf(" ")) : s;
 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 202, "\"", 267, 4);
            WriteAttributeValue("", 208, "https://loremflickr.com/g/320/240/", 208, 34, true);
#nullable restore
#line 8 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
WriteAttributeValue("", 242, firstWord, 242, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 252, "?lock=", 252, 6, true);
#nullable restore
#line 8 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
WriteAttributeValue("", 258, Model.Id, 258, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 289, "\"", 306, 1);
#nullable restore
#line 8 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
WriteAttributeValue("", 295, Model.Name, 295, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
                        Write(Html.DisplayFor(m => Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 520, "\"", 558, 2);
            WriteAttributeValue("", 527, "/products/ShowDetails/", 527, 22, true);
#nullable restore
#line 13 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
WriteAttributeValue("", 549, Model.Id, 549, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Details</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 607, "\"", 638, 2);
            WriteAttributeValue("", 614, "/products/Edit/", 614, 15, true);
#nullable restore
#line 14 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
WriteAttributeValue("", 629, Model.Id, 629, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 684, "\"", 717, 2);
            WriteAttributeValue("", 691, "/products/Delete/", 691, 17, true);
#nullable restore
#line 15 "C:\Users\pmgth\source\repos\Activity2\Activity2\Views\Products\_productCard.cshtml"
WriteAttributeValue("", 708, Model.Id, 708, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Delete</a>\r\n    </div>\r\n</div>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Activity2.Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591