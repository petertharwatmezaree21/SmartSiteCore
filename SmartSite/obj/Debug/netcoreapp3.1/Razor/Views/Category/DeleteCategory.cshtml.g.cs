#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\DeleteCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8042b4c90437608feafb346c0cceb4005d7d0e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_DeleteCategory), @"mvc.1.0.view", @"/Views/Category/DeleteCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/DeleteCategory.cshtml", typeof(AspNetCore.Views_Category_DeleteCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8042b4c90437608feafb346c0cceb4005d7d0e4", @"/Views/Category/DeleteCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_DeleteCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\DeleteCategory.cshtml"
   ViewBag.Title = "DeleteCategory"; 

#line default
#line hidden
            BeginContext(72, 325, true);
            WriteLiteral(@"<div class=""deletePage"">
    <div class=""page-part"">
        <div class=""row d-flex justify-content-center"">
            <div class=""icon-delete col-12 d-flex justify-content-center"">
                <i class=""far fa-times-circle""></i>
            </div>
            <div>
                <h2>Are You Sure Delete Category <a>");
            EndContext();
            BeginContext(398, 18, false);
#line 10 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\DeleteCategory.cshtml"
                                               Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(416, 141, true);
            WriteLiteral("</a> ?</h2>\n                <p>This will cause deleting all this category related types and products .</p>\n            </div>\n        </div>\n");
            EndContext();
#line 14 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\DeleteCategory.cshtml"
         using (Html.BeginForm("DeleteCategory", "Category", FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(647, 25, false);
#line 16 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\DeleteCategory.cshtml"
Write(Html.HiddenFor(c => c.ID));

#line default
#line hidden
            EndContext();
            BeginContext(673, 299, true);
            WriteLiteral(@"                <div class=""row d-flex justify-content-center"">
                    <div class=""col-sm-2"">
                        <button type=""submit"" class=""btn btn-danger form-control"">Delete</button>
                    </div>
                    <div class=""col-sm-2"">
                        ");
            EndContext();
            BeginContext(973, 97, false);
#line 22 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\DeleteCategory.cshtml"
                   Write(Html.ActionLink("Cancel", "GetAllCategories", null, new { @class = "btn btn-info form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 50, true);
            WriteLiteral("\n                    </div>\n                </div>");
            EndContext();
#line 24 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\DeleteCategory.cshtml"
                      }

#line default
#line hidden
            BeginContext(1122, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartSite.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591