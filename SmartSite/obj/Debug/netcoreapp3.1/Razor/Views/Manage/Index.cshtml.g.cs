#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eccccea1d8de5d01df7642c1535b3bfadee950e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_Index), @"mvc.1.0.view", @"/Views/Manage/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/Index.cshtml", typeof(AspNetCore.Views_Manage_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eccccea1d8de5d01df7642c1535b3bfadee950e", @"/Views/Manage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\Index.cshtml"
   ViewBag.Title = "Manage"; 

#line default
#line hidden
            BeginContext(70, 371, true);
            WriteLiteral(@"
<!-- Contact Form -->
<div class=""contact-form-area m-top-30 d-flex justify-content-center"" style=""width:50%;margin-left:25%"">
    <div class=""row d-flex justify-content-center"">

        <h4>Change your account settings</h4>


        <div class=""col-lg-12 col-md-12 "">
            <div class=""form-group text-center"">
                <i class=""fas fa-unlock-alt""></i>
");
            EndContext();
#line 14 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\Index.cshtml"
                 if (Model.HasPassword)
                {
    

#line default
#line hidden
            BeginContext(504, 57, false);
#line 16 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\Index.cshtml"
Write(Html.ActionLink("Change your password", "ChangePassword"));

#line default
#line hidden
            EndContext();
#line 16 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\Index.cshtml"
                                                               }
                else
                {
    

#line default
#line hidden
            BeginContext(608, 40, false);
#line 19 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\Index.cshtml"
Write(Html.ActionLink("Create", "SetPassword"));

#line default
#line hidden
            EndContext();
#line 19 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Manage\Index.cshtml"
                                             }

#line default
#line hidden
            BeginContext(650, 55, true);
            WriteLiteral("\n            </div>\n        </div>\n\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartSite.Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
