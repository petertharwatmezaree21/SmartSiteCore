#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f91aebaad39f209bf7575a332e95d4fbde6f8ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f91aebaad39f209bf7575a332e95d4fbde6f8ff", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Contact.cshtml"
   ViewBag.Title = "Contact"; 

#line default
#line hidden
            BeginContext(32, 379, true);
            WriteLiteral(@"<!-- Breadcrumb -->
<div class=""breadcrumbs overlay"" style=""background-image:url('../../img/9.jpg')"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""bread-inner"">
                    <!-- Bread Menu -->
                    <div class=""bread-menu"">
                        <ul>
                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 411, "\"", 446, 1);
#line 11 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Contact.cshtml"
WriteAttributeValue("", 418, Url.Action("Index", "Home"), 418, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 2727, true);
            WriteLiteral(@">Home</a></li>|
                            <li><a href=""#"">Contact</a></li>
                        </ul>
                    </div>
                    <!-- Bread Title -->
                    <div class=""bread-title""><h2>Contact With Us</h2></div>
                </div>
            </div>
        </div>
    </div>
</div>
<!--/ End Breadcrumb -->
<!-- Contact Us -->
<section class=""contact-us section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 col-md-7 col-12"">
                <!-- Contact Form -->
                <div class=""contact-form-area m-top-30"">
                    <h4>Find Us</h4>
                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d13825.755760287977!2d31.250672377493014!3d29.966812949768343!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145847b33a35da9d%3A0xf1e7187827150f7d!2sSmart%20For%20Electrical%20Engineering!5e0!3m2!1sar!2seg!4v1599391326697!5m2!1sar!2seg"" width=""600"" height=""450"" frameborder=""0"" styl");
            WriteLiteral(@"e=""border:0;"" allowfullscreen="""" aria-hidden=""false"" tabindex=""0""></iframe>
                </div>
                <!--/ End contact Form -->
            </div>
            <div class=""col-lg-5 col-md-5 col-12"">
                <div class=""contact-box-main m-top-30"">
                    <div class=""contact-title"">
                        <h2>Contact with us</h2>
                    </div>
                    <!-- Single Contact -->
                    <div class=""single-contact-box"">
                        <div class=""c-icon""><i class=""fa fa-phone""></i></div>
                        <div class=""c-text"">
                            <h4>Call Us Now</h4>
                            <p><a href=""mailto:info@see-eg.com"">info@see-eg.com </a>-<a href=""#""> +20 102 722 6606</a></p>
                            <p><a href=""mailto:omar@see-eg.com"">omar@see-eg.com </a>-<a href=""#""> +20 100 231 1925</a></p>
                            <p><a href=""mailto:sales@see-eg.com"">sales@see-eg.com </a>-<a href=""#""> +20 102 024 0791<");
            WriteLiteral(@"/a></p>
                        </div>
                    </div>
                    <!--/ End Single Contact -->
                    <!-- Single Contact -->
                    <div class=""single-contact-box"">
                        <div class=""c-icon""><i class=""far fa-clock""></i></div>
                        <div class=""c-text"">
                            <h4>Opening Hour</h4>
                            <p>Saturday  -  Thursday<br>09AM - 5PM (everyday)</p>
                        </div>
                    </div>
                    <!--/ End Single Contact -->

                </div>
            </div>
        </div>
    </div>
</section>
<!--/ End Contact Us -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
