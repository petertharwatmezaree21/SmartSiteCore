#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e63f4c6d3f7f3e172c7d827671056108f7d7584c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ChangePassword), @"mvc.1.0.view", @"/Views/Manage/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ChangePassword.cshtml", typeof(AspNetCore.Views_Manage_ChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e63f4c6d3f7f3e172c7d827671056108f7d7584c", @"/Views/Manage/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.ChangePasswordViewModel>
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
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
   ViewBag.Title = "Change Password"; 

#line default
#line hidden
            BeginContext(88, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 5 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
 using (Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{

#line default
#line hidden
            BeginContext(213, 23, false);
#line 7 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(236, 291, true);
            WriteLiteral(@" <!-- Contact Form -->
                <div class=""contact-form-area m-top-30 d-flex justify-content-center"" style=""width:50%;margin-left:25%"">
                    <div class=""row d-flex justify-content-center"">

                        <h4>Change Password Form</h4>
                        ");
            EndContext();
            BeginContext(528, 58, false);
#line 12 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
                   Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(586, 146, true);
            WriteLiteral("\n\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(733, 76, false);
#line 16 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
                           Write(Html.LabelFor(m => m.OldPassword, new { @class = "col-md-4 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(809, 93, true);
            WriteLiteral("\n                                <div class=\"col-md-10\">\n                                    ");
            EndContext();
            BeginContext(903, 69, false);
#line 18 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
                               Write(Html.PasswordFor(m => m.OldPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(972, 251, true);
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(1224, 76, false);
#line 25 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
                           Write(Html.LabelFor(m => m.NewPassword, new { @class = "col-md-4 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 93, true);
            WriteLiteral("\n                                <div class=\"col-md-10\">\n                                    ");
            EndContext();
            BeginContext(1394, 69, false);
#line 27 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
                               Write(Html.PasswordFor(m => m.NewPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 251, true);
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(1715, 80, false);
#line 34 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
                           Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-4 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 93, true);
            WriteLiteral("\n                                <div class=\"col-md-10\">\n                                    ");
            EndContext();
            BeginContext(1889, 73, false);
#line 36 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
                               Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 559, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>


                        <div class=""col-lg-12 col-md-12 "">
                            <div class=""form-group"">
                                <div class=""col-md-offset-2 col-md-10"">
                                    <input type=""submit"" value=""Change password"" class=""bizwheel-btn theme-2"" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>");
            EndContext();
#line 50 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\ChangePassword.cshtml"
                      }

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(2540, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(2546, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e63f4c6d3f7f3e172c7d827671056108f7d7584c9789", async() => {
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
                BeginContext(2593, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2598, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e63f4c6d3f7f3e172c7d827671056108f7d7584c11042", async() => {
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
                BeginContext(2657, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartSite.Models.ChangePasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
