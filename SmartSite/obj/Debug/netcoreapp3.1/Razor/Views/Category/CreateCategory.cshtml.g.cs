#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\CreateCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb90f8d5f3ddb00dc7ace4d8c6ad4ea0f3c2ebd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CreateCategory), @"mvc.1.0.view", @"/Views/Category/CreateCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/CreateCategory.cshtml", typeof(AspNetCore.Views_Category_CreateCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb90f8d5f3ddb00dc7ace4d8c6ad4ea0f3c2ebd1", @"/Views/Category/CreateCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CreateCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\CreateCategory.cshtml"
   ViewBag.Title = "CreateCategory"; 

#line default
#line hidden
            BeginContext(72, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 5 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\CreateCategory.cshtml"
 using (Html.BeginForm("CreateCategory", "Category", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(146, 337, true);
            WriteLiteral(@"<!-- Contact Form -->
                <div class=""contact-form-area m-top-30"">
                    <h4>Create Category</h4>
                    <div class=""row"">
                        <div class=""col-lg-12 col-md-12 "" style=""display:flex;justify-content:center;align-items:center"">
                            <div class=""form-group"">
");
            EndContext();
            BeginContext(555, 113, true);
            WriteLiteral("                                <label for=\"CategoryName\">Category Name:</label>\n                                ");
            EndContext();
            BeginContext(669, 69, false);
#line 14 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\CreateCategory.cshtml"
                           Write(Html.TextBoxFor(c => c.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(738, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(772, 84, false);
#line 15 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\CreateCategory.cshtml"
                           Write(Html.ValidationMessageFor(c => c.CategoryName, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(856, 413, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-12"">
                            <div class=""form-group button"">
                                <button type=""submit"" class=""bizwheel-btn theme-2"">Create</button>
                            </div>
                        </div>
                    </div>
                </div> <!--/ End contact Form -->");
            EndContext();
#line 24 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\CreateCategory.cshtml"
                                                 }

#line default
#line hidden
            BeginContext(1271, 2, true);
            WriteLiteral("\n\n");
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
