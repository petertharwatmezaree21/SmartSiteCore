#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8cf859b269b1aea08a7f3f85010f4fde3a36f58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cf859b269b1aea08a7f3f85010f4fde3a36f58", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.RegisterViewModel>
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
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
   ViewBag.Title = "Register"; 

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 5 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{

#line default
#line hidden
            BeginContext(195, 23, false);
#line 7 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(220, 149, true);
            WriteLiteral("<div class=\"contact-form-area m-top-30 d-flex justify-content-center\">\n    <div class=\"row d-flex justify-content-center\">\n        <h3>Register</h3>\n");
            EndContext();
            BeginContext(441, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(450, 64, false);
#line 13 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(514, 99, true);
            WriteLiteral("\n\n\n        <div class=\"col-lg-12 col-md-12 \">\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(614, 73, false);
#line 18 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.userName, new { @class = "col-md-4 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(687, 61, true);
            WriteLiteral("\n                <div class=\"col-md-10\">\n                    ");
            EndContext();
            BeginContext(749, 65, false);
#line 20 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(m => m.userName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(814, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(836, 78, false);
#line 21 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.ValidationMessageFor(m => m.userName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(914, 155, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n        <div class=\"col-lg-12 col-md-12 \">\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(1070, 70, false);
#line 28 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Email, new { @class = "col-md-4 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 61, true);
            WriteLiteral("\n                <div class=\"col-md-10\">\n                    ");
            EndContext();
            BeginContext(1202, 62, false);
#line 30 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1286, 75, false);
#line 31 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 155, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n        <div class=\"col-lg-12 col-md-12 \">\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(1517, 73, false);
#line 38 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Password, new { @class = "col-md-4 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 61, true);
            WriteLiteral("\n                <div class=\"col-md-10\">\n                    ");
            EndContext();
            BeginContext(1652, 66, false);
#line 40 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1740, 78, false);
#line 41 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 155, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n        <div class=\"col-lg-12 col-md-12 \">\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(1974, 80, false);
#line 48 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-4 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 61, true);
            WriteLiteral("\n                <div class=\"col-md-10\">\n                    ");
            EndContext();
            BeginContext(2116, 73, false);
#line 50 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2211, 85, false);
#line 51 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2296, 412, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>


        <div class=""col-12"">
            <div class=""form-group button"">
                <button type=""submit"" class=""bizwheel-btn theme-2 "">Register</button>
            </div>
        </div>

        <div class=""col-12"">
            <div class=""form-group button"">
                <p>
                    already have an account?
                    ");
            EndContext();
            BeginContext(2709, 65, false);
#line 67 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
               Write(Html.ActionLink("Login Here", "Login", null, new { @class = "" }));

#line default
#line hidden
            EndContext();
            BeginContext(2774, 87, true);
            WriteLiteral("\n                </p>\n            </div>\n        </div>\n\n\n    </div>\n</div>            ");
            EndContext();
#line 74 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Account\Register.cshtml"
                  }

#line default
#line hidden
            BeginContext(2863, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2881, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(2887, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8cf859b269b1aea08a7f3f85010f4fde3a36f5812297", async() => {
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
                BeginContext(2934, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2939, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8cf859b269b1aea08a7f3f85010f4fde3a36f5813551", async() => {
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
                BeginContext(2998, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(3001, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartSite.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591