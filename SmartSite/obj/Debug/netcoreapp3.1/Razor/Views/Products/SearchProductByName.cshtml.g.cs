#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04ad45c470231bdc03cf2db66d83b722835f649b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_SearchProductByName), @"mvc.1.0.view", @"/Views/Products/SearchProductByName.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/SearchProductByName.cshtml", typeof(AspNetCore.Views_Products_SearchProductByName))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04ad45c470231bdc03cf2db66d83b722835f649b", @"/Views/Products/SearchProductByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_SearchProductByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartSite.Models.Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
   ViewBag.Title = "Index"; 

#line default
#line hidden
            BeginContext(76, 379, true);
            WriteLiteral(@"<!-- Breadcrumb -->
<div class=""breadcrumbs overlay"" style=""background-image:url('../../img/5.jpg')"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""bread-inner"">
                    <!-- Bread Menu -->
                    <div class=""bread-menu"">
                        <ul>
                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 455, "\"", 489, 1);
#line 13 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
WriteAttributeValue("", 462, Url.Action("Index","Home"), 462, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(490, 429, true);
            WriteLiteral(@">Home  -</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!--/ End Breadcrumb -->
<!-- Portfolio -->
<section class=""portfolio section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 offset-lg-3 col-md-6 offset-md-3 col-12"">
                <div class=""section-title default text-center"">
");
            EndContext();
            BeginContext(1080, 419, true);
            WriteLiteral(@"                    <div class=""section-bottom"">
                        <div class=""text"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <div class=""portfolio-menu"">
                    <!-- Portfolio Nav -->
                    <div class=""button"" style=""text-align:left"">
");
            EndContext();
#line 44 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
            BeginContext(1744, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1758, "\"", 1798, 1);
#line 46 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
WriteAttributeValue("", 1765, Url.Action("Create", "Products"), 1765, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1799, 91, true);
            WriteLiteral(" class=\"bizwheel-btn theme-1 effect\">Add new product <i class=\"fas fa-plus-circle\"></i></a>");
            EndContext();
#line 46 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
                                                                                                                                                  }

#line default
#line hidden
            BeginContext(1892, 528, true);
            WriteLiteral(@"
                    </div>
                    <ul id=""portfolio-nav"" class=""portfolio-nav tr-list list-inline cbp-l-filters-work"">
                        <li data-filter=""*"" class=""cbp-filter-item active"">All</li>
                    </ul>
                    <!--/ End Portfolio Nav -->
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <div class=""portfolio-main"">
                    <div id=""portfolio-item"" class=""portfolio-item-active"">
");
            EndContext();
#line 60 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2499, 224, true);
            WriteLiteral("            <div class=\"cbp-item business animation\">\n                <!-- Single Portfolio -->\n                <div class=\"single-portfolio\">\n                    <div class=\"portfolio-head overlay\">\n                        ");
            EndContext();
            BeginContext(2723, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04ad45c470231bdc03cf2db66d83b722835f649b7711", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2733, "~/imageUploads/ProductImg/", 2733, 26, true);
#line 66 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
AddHtmlAttributeValue("", 2759, item.Image, 2759, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2774, 40, true);
            WriteLiteral("\n                        <a class=\"more\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2814, "\"", 2878, 1);
#line 67 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
WriteAttributeValue(" ", 2821, Url.Action("Details", "Products", new { id = item.ID }), 2822, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2879, 158, true);
            WriteLiteral("><i class=\"fas fa-long-arrow-alt-right\"></i></a>\n                    </div>\n                    <div class=\"portfolio-content\">\n                        <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3037, "\"", 3100, 1);
#line 70 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
WriteAttributeValue("", 3044, Url.Action("Details", "Products", new { id = item.ID }), 3044, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3101, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3103, 39, false);
#line 70 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3142, 97, true);
            WriteLiteral("</a></h4>\n                        <br />\n                        <p>\n                            ");
            EndContext();
            BeginContext(3240, 51, false);
#line 73 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductType.Type));

#line default
#line hidden
            EndContext();
            BeginContext(3291, 80, true);
            WriteLiteral("\n                        </p>\n                    </div>\n                </div>\n");
            EndContext();
#line 77 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
                 if (User.IsInRole("Admin"))
                {

#line default
#line hidden
            BeginContext(3433, 98, true);
            WriteLiteral("<!--/ End Single Portfolio -->\n                    <div class=\"button\">\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3531, "\"", 3586, 1);
#line 80 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
WriteAttributeValue("", 3538, Url.Action("Edit","Products",new { id=item.ID}), 3538, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3587, 72, true);
            WriteLiteral(" class=\"bizwheel-btn theme-1 effect\">Edit</a>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3659, "\"", 3716, 1);
#line 81 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
WriteAttributeValue("", 3666, Url.Action("Delete","Products",new { id=item.ID}), 3666, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3717, 74, true);
            WriteLiteral(" class=\"bizwheel-btn theme-2 effect\">Delete</a>\n                    </div>");
            EndContext();
#line 82 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
                          }

#line default
#line hidden
            BeginContext(3793, 19, true);
            WriteLiteral("\n            </div>");
            EndContext();
#line 84 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\SearchProductByName.cshtml"
                  }

#line default
#line hidden
            BeginContext(3814, 130, true);
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n<!--/ End Portfolio -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartSite.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
