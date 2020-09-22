#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62978070640f6fd934e15f883694af571f2674ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductType_ProductTypeDetails), @"mvc.1.0.view", @"/Views/ProductType/ProductTypeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductType/ProductTypeDetails.cshtml", typeof(AspNetCore.Views_ProductType_ProductTypeDetails))]
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
#line 1 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\_ViewImports.cshtml"
using SmartSite;

#line default
#line hidden
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\_ViewImports.cshtml"
using SmartSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62978070640f6fd934e15f883694af571f2674ca", @"/Views/ProductType/ProductTypeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductType_ProductTypeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.ProductType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
   ViewBag.Title = "ProductTypeDetails"; 

#line default
#line hidden
            BeginContext(79, 245, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"card text-white bg-primary mb-3\" style=\"max-width: 18rem;\">\n        <div class=\"card-header\">Product Type Details</div>\n        <div class=\"card-body\">\n            <h5 class=\"card-title\">Type Name : <u>[ ");
            EndContext();
            BeginContext(325, 10, false);
#line 8 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                                               Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(335, 63, true);
            WriteLiteral(" ]</u></h5>\n            <h5 class=\"card-title\">Category : <u>[ ");
            EndContext();
            BeginContext(399, 27, false);
#line 9 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                                              Write(Model.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(426, 42, true);
            WriteLiteral(" ]</u></h5>\n        </div>\n    </div>\n    ");
            EndContext();
            BeginContext(469, 107, false);
#line 12 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
Write(Html.ActionLink("products", "FilterProductsByType", new { id = Model.ID }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(576, 304, true);
            WriteLiteral(@"
    <hr />
    <div>
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Type</th>
                    <th>Category</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 25 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                   IEnumerable<SmartSite.Models.Product> products = ViewData["product"] as IEnumerable<SmartSite.Models.Product>;
                                foreach (var product in products)
                                {

#line default
#line hidden
            BeginContext(1110, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1164, 12, false);
#line 29 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                       Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1176, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1211, 24, false);
#line 30 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                       Write(product.ProductType.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1235, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1270, 41, false);
#line 31 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                       Write(product.ProductType.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 63, true);
            WriteLiteral("</td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1375, 62, false);
#line 33 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { id = product.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 35 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                             if (User.IsInRole("Admin"))
                            {
            

#line default
#line hidden
            BeginContext(1539, 56, false);
#line 37 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id = product.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 60, false);
#line 38 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = product.ID }));

#line default
#line hidden
            EndContext();
#line 38 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                                                                                             }

#line default
#line hidden
            BeginContext(1691, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr> ");
            EndContext();
#line 41 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
                          } 

#line default
#line hidden
            BeginContext(1752, 78, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n    <hr />\n    <div>\n        ");
            EndContext();
            BeginContext(1831, 96, false);
#line 47 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\ProductTypeDetails.cshtml"
   Write(Html.ActionLink("Return", "AllProductTypes", null, new { @class = "btn btn-info form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartSite.Models.ProductType> Html { get; private set; }
    }
}
#pragma warning restore 1591
