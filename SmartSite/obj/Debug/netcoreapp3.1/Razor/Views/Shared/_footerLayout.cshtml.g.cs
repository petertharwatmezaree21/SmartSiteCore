#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d3c00a87d45cb9746627ff9d7b2ada5b6ed025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__footerLayout), @"mvc.1.0.view", @"/Views/Shared/_footerLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_footerLayout.cshtml", typeof(AspNetCore.Views_Shared__footerLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d3c00a87d45cb9746627ff9d7b2ada5b6ed025", @"/Views/Shared/_footerLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__footerLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
   if (ViewBag.layoutVM.GetLastNews() != null)
                {

#line default
#line hidden
            BeginContext(66, 96, true);
            WriteLiteral("    <div class=\"single-widget footer-news widget\">\n        <h3 class=\"widget-title\">News </h3>\n\n");
            EndContext();
#line 7 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
         foreach (var news in ViewBag.layoutVM.GetLastNews())
        {

#line default
#line hidden
            BeginContext(233, 119, true);
            WriteLiteral("<!-- Single News -->\n                    <div class=\"single-f-news\">\n                        <div class=\"post-thumb\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 352, "\"", 415, 1);
#line 10 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
WriteAttributeValue("", 359, Url.Action("NewsDetails", "News", new { id = news.ID }), 359, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(416, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(417, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25d3c00a87d45cb9746627ff9d7b2ada5b6ed0254835", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 427, "~/imageUploads/NewsImg/", 427, 23, true);
#line 10 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
AddHtmlAttributeValue("", 450, news.Image, 450, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(471, 177, true);
            WriteLiteral("</a></div>\n                        <div class=\"content\">\n                            <p class=\"post-meta\" style=\"margin:0px\"><time class=\"post-date\"><i class=\"fas fa-clock\"></i>");
            EndContext();
            BeginContext(649, 9, false);
#line 12 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
                                                                                                                   Write(news.Date);

#line default
#line hidden
            EndContext();
            BeginContext(658, 42, true);
            WriteLiteral("</time></p>\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 700, "\"", 763, 1);
#line 13 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
WriteAttributeValue("", 707, Url.Action("NewsDetails", "News", new { id = news.ID }), 707, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(764, 37, true);
            WriteLiteral(">\n                                <p>");
            EndContext();
            BeginContext(802, 10, false);
#line 14 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
                              Write(news.Title);

#line default
#line hidden
            EndContext();
            BeginContext(812, 190, true);
            WriteLiteral("</p>\n                            </a>\n                            <div class=\"title\">\n                                <p style=\"height:50px;overflow:hidden\"><i class=\"far fa-newspaper\"></i> ");
            EndContext();
            BeginContext(1003, 12, false);
#line 17 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
                                                                                                   Write(news.Details);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 123, true);
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </div> <!--/ End Single News -->");
            EndContext();
#line 20 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(1140, 11, true);
            WriteLiteral("    </div> ");
            EndContext();
#line 21 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Shared\_footerLayout.cshtml"
           } 

#line default
#line hidden
            BeginContext(1155, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
