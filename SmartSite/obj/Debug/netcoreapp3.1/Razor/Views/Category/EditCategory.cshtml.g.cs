#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6858465006c1eac951aff61b2d390a50e2708e40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_EditCategory), @"mvc.1.0.view", @"/Views/Category/EditCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/EditCategory.cshtml", typeof(AspNetCore.Views_Category_EditCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6858465006c1eac951aff61b2d390a50e2708e40", @"/Views/Category/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\EditCategory.cshtml"
   ViewBag.Title = "EditCategory"; 

#line default
#line hidden
            BeginContext(70, 24, true);
            WriteLiteral("\n<h2>EditCategory</h2>\n\n");
            EndContext();
#line 6 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\EditCategory.cshtml"
 using (Html.BeginForm("EditCategory", "Category", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(164, 330, true);
            WriteLiteral(@"<!-- Contact Form -->
                    <div class=""contact-form-area m-top-30"">
                        <h4>Edit Category</h4>
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12 "" style=""display:flex;justify-content:center;align-items:center"">
                                ");
            EndContext();
            BeginContext(495, 25, false);
#line 12 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\EditCategory.cshtml"
                           Write(Html.HiddenFor(c => c.ID));

#line default
#line hidden
            EndContext();
            BeginContext(520, 179, true);
            WriteLiteral("\n                                <div class=\"form-group\">\n                                    <label for=\"CategoryName\">Category Name:</label>\n                                    ");
            EndContext();
            BeginContext(700, 69, false);
#line 15 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\EditCategory.cshtml"
                               Write(Html.TextBoxFor(c => c.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(769, 37, true);
            WriteLiteral("\n                                    ");
            EndContext();
            BeginContext(807, 84, false);
#line 16 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\EditCategory.cshtml"
                               Write(Html.ValidationMessageFor(c => c.CategoryName, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(891, 447, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""form-group button"">
                                    <button type=""submit"" class=""bizwheel-btn theme-2"">Edit</button>
                                </div>
                            </div>
                        </div>
                    </div> <!--/ End contact Form -->");
            EndContext();
#line 25 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Category\EditCategory.cshtml"
                                                     }

#line default
#line hidden
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
