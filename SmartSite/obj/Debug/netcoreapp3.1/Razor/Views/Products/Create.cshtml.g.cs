#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1809882c0529ab38f7ab6119e8e81313d8c56a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Create), @"mvc.1.0.view", @"/Views/Products/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Create.cshtml", typeof(AspNetCore.Views_Products_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1809882c0529ab38f7ab6119e8e81313d8c56a7", @"/Views/Products/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
   ViewBag.Title = "Create"; 

#line default
#line hidden
            BeginContext(64, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
#line 7 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
 using (Html.BeginForm("Create", "Products", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(174, 23, false);
#line 9 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(197, 236, true);
            WriteLiteral(" <!-- Contact Form -->\n                <div class=\"contact-form-area m-top-30 d-flex justify-content-center\" style=\"width:50%;margin-left:25%\">\n                    <div class=\"row d-flex justify-content-center\">\n                        ");
            EndContext();
            BeginContext(434, 64, false);
#line 12 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(498, 145, true);
            WriteLiteral("\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(644, 93, false);
#line 15 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(737, 93, true);
            WriteLiteral("\n                                <div class=\"col-md-10\">\n                                    ");
            EndContext();
            BeginContext(831, 93, false);
#line 17 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                               Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(924, 37, true);
            WriteLiteral("\n                                    ");
            EndContext();
            BeginContext(962, 82, false);
#line 18 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 251, true);
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(1296, 100, false);
#line 25 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                           Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 93, true);
            WriteLiteral("\n                                <div class=\"col-md-10\">\n                                    ");
            EndContext();
            BeginContext(1490, 102, false);
#line 27 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                               Write(Html.TextAreaFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 37, true);
            WriteLiteral("\n                                    ");
            EndContext();
            BeginContext(1630, 89, false);
#line 28 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 251, true);
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(1971, 94, false);
#line 35 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                           Write(Html.LabelFor(model => model.Image, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 57, true);
            WriteLiteral("\n                                <div class=\"col-md-10\">\n");
            EndContext();
            BeginContext(2258, 195, true);
            WriteLiteral("                                    <input type=\"file\" name=\"UploadImg\" accept=\"image/*\" />\n                                    <span class=\"text-danger\">\n                                        ");
            EndContext();
            BeginContext(2454, 15, false);
#line 40 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                                   Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2469, 295, true);
            WriteLiteral(@"
                                    </span>
                                </div>
                            </div>
                        </div>

                        <div class=""col-lg-12 col-md-12 "">
                            <div class=""form-group"">
                                ");
            EndContext();
            BeginContext(2765, 96, false);
#line 48 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                           Write(Html.LabelFor(model => model.PdfFile, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2861, 260, true);
            WriteLiteral(@"
                                <div class=""col-md-10"">
                                    <input type=""file"" name=""UploadPdf"" accept=""application/pdf"" />
                                    <span class=""text-danger"">
                                        ");
            EndContext();
            BeginContext(3122, 15, false);
#line 52 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                                   Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(3137, 294, true);
            WriteLiteral(@"
                                    </span>
                                </div>
                            </div>
                        </div>

                        <div class=""col-lg-12 col-md-12"">
                            <div class=""form-group"">
                                ");
            EndContext();
            BeginContext(3432, 94, false);
#line 60 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                           Write(Html.LabelFor(model => model.Brand, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3526, 93, true);
            WriteLiteral("\n                                <div class=\"col-md-10\">\n                                    ");
            EndContext();
            BeginContext(3620, 94, false);
#line 62 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                               Write(Html.EditorFor(model => model.Brand, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3714, 37, true);
            WriteLiteral("\n                                    ");
            EndContext();
            BeginContext(3752, 83, false);
#line 63 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Brand, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3835, 250, true);
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n\n                        <div class=\"col-lg-12 col-md-12\">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(4086, 119, false);
#line 70 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                           Write(Html.LabelFor(model => model.ProductTypeID, "ProductTypeID", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4205, 93, true);
            WriteLiteral("\n                                <div class=\"col-md-10\">\n                                    ");
            EndContext();
            BeginContext(4299, 89, false);
#line 72 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                               Write(Html.DropDownList("ProductTypeID", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4388, 37, true);
            WriteLiteral("\n                                    ");
            EndContext();
            BeginContext(4426, 91, false);
#line 73 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                               Write(Html.ValidationMessageFor(model => model.ProductTypeID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4517, 462, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>

                        <div class=""col-12"">
                            <div class=""form-group button"">
                                <button type=""submit"" class=""bizwheel-btn theme-2 "">Create</button>
                            </div>
                        </div>
                        <div class=""form-group button"">
                            ");
            EndContext();
            BeginContext(4980, 86, false);
#line 84 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
                       Write(Html.ActionLink("Cancel", "Index", null, new { @class = "btn btn-info form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5066, 109, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                </div> <!--/ End contact Form -->\n");
            EndContext();
#line 88 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Products\Create.cshtml"
}

#line default
#line hidden
            BeginContext(5177, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5196, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(5202, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1809882c0529ab38f7ab6119e8e81313d8c56a716198", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5249, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(5254, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1809882c0529ab38f7ab6119e8e81313d8c56a717452", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5313, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(5316, 150, true);
            WriteLiteral("<!-- editor textarea -->\n<script src=\"https://cdn.ckeditor.com/4.14.1/basic/ckeditor.js\"></script>\n\n<script>CKEDITOR.replace(\'Description\');</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartSite.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
