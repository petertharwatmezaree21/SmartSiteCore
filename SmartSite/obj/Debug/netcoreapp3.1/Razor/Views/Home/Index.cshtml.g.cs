#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aabdcfb049ffe8dbafcd43572c932e7dc1656e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aabdcfb049ffe8dbafcd43572c932e7dc1656e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartSite.Models.Category>>
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
#line 1 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
   ViewBag.Title = "Home Page"; 

#line default
#line hidden
            BeginContext(80, 652, true);
            WriteLiteral(@"<!-- Hero Slider -->
<section class=""hero-slider style1"">
    <div class=""home-slider"">
        <!-- Single Slider -->
        <div class=""single-slider"" style=""background-image: url('../../img/1.2.jpg');"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7 col-md-8 col-sm-12"">
                        <div class=""welcome-text col-sm-12"">
                            <div class=""hero-text"">
                                <h4>We are always ready to help you</h4>
                                <h1>Smart for Electrical Engineering</h1>
                                <div class=""button"">
");
            EndContext();
#line 16 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                       foreach (var category in Model)
                                                    {

#line default
#line hidden
            BeginContext(857, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 899, "\"", 989, 1);
#line 18 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 906, Url.Action("FilterProductTypeByCategory", "ProductType", new { id = category.ID }), 906, 83, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 990, "\"", 1036, 4);
            WriteAttributeValue("", 998, "bizwheel-btn", 998, 12, true);
            WriteAttributeValue(" ", 1010, "theme-", 1011, 7, true);
#line 18 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1017, category.ID, 1017, 12, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1029, "effect", 1030, 7, true);
            EndWriteAttribute();
            BeginContext(1037, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1039, 21, false);
#line 18 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                                                                                                                                                                Write(category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 5, true);
            WriteLiteral("</a> ");
            EndContext();
#line 18 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                                                                                                                                                                                                } 

#line default
#line hidden
            BeginContext(1069, 740, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--/ End Single Slider -->
        <!-- Single Slider -->
        <div class=""single-slider"" style=""background-image:url('../../img/1.1.jpg')"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7 col-md-8 col-sm-12"">
                        <div class=""welcome-text"">
                            <div class=""hero-text"">
                                <h4>Your time is so important for us</h4>
                                <h1>Some general safety prouducts for working with</h1>
");
            EndContext();
#line 37 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                   if (ViewBag.safetyCatID != null)
                                                {

#line default
#line hidden
            BeginContext(1927, 99, true);
            WriteLiteral("                                    <div class=\"button\">\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2026, "\"", 2124, 1);
#line 40 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 2033, Url.Action("FilterProductTypeByCategory", "ProductType", new { id =  ViewBag.safetyCatID}), 2033, 91, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2125, 91, true);
            WriteLiteral(" class=\"bizwheel-btn theme-1 effect\">Safety</a>\n                                    </div> ");
            EndContext();
#line 41 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                           } 

#line default
#line hidden
            BeginContext(2220, 858, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--/ End Single Slider -->
        <!-- Single Slider -->
        <div class=""single-slider"" style=""background-image:url('../../img/1.jpg')"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-7 col-md-8 col-sm-12"">
                        <div class=""welcome-text"">
                            <div class=""hero-text"">
                                <h4>Our experties are waiting for you</h4>
                                <h1>BE SMART, LIVE BETTER</h1>
                                <div class=""p-text"">
                                </div>
                                <div class=""button"">
                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3078, "\"", 3113, 1);
#line 62 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 3085, Url.Action("About", "Home"), 3085, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3114, 3092, true);
            WriteLiteral(@" class=""bizwheel-btn theme-2 effect"">About us</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--/ End Single Slider -->
    </div>
</section>
<!--/ End Hero Slider -->
<!-- Features Area -->
<section class=""features-area section-bg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-6 col-sm-12"">
                <!-- Single Feature -->
                <div class=""single-feature"">
                    <div class=""icon-head""><i class=""fa fa-podcast""></i></div>
                    <h4>High-quality service</h4>
                </div>
                <!--/ End Single Feature -->
            </div>
            <div class=""col-lg-3 col-md-6 col-12"">
                <!-- Single Feature -->
                <div class=""single-feature"">
                    <div class=""icon-head""><i class=""fa fa-podcast""></i></div>
           ");
            WriteLiteral(@"         <h4>Quality Products</h4>
                </div>
                <!--/ End Single Feature -->
            </div>
            <div class=""col-lg-3 col-md-6 col-12"">
                <!-- Single Feature -->
                <div class=""single-feature active"">
                    <div class=""icon-head""><i class=""fa fa-podcast""></i></div>
                    <h4>continuous support</h4>

                </div>
                <!--/ End Single Feature -->
            </div>
            <div class=""col-lg-3 col-md-6 col-12"">
                <!-- Single Feature -->
                <div class=""single-feature"">
                    <div class=""icon-head""><i class=""fa fa-podcast""></i></div>
                    <h4>latest news</h4>
                </div>
                <!--/ End Single Feature -->
            </div>
        </div>
    </div>
</section>
<!--/ End Features Area -->
<!-- Call To Action -->
<section class=""call-action overlay"" style=""background-image:url('')"">
    <div class=""container"">
        <div ");
            WriteLiteral(@"class=""row"">
            <div class=""col-lg-9 col-12"">
                <div class=""call-inner"">
                    <h2>BE SMART, LIVE BETTER</h2>
                    <p>our promise to our customers who have adopted continuous, high-quality service and products.</p>
                </div>
            </div>

        </div>
    </div>
</section>
<!--/ End Call to action -->
<!-- Services -->
<section class=""services section-bg section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""section-title style2 text-center"">
                    <div class=""section-top"">
                        <h1><span>Sample of our products</span><b>Products We Provide</b></h1>
                    </div>
                    <div class=""section-bottom"">
                        <div class=""text-style-two"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">

            <!--");
            WriteLiteral(" Single Service -->\n");
            EndContext();
#line 149 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
               List<SmartSite.Models.Product> randomProducts = ViewBag.shownProducts;
                            if (randomProducts != null)
                            {
                                foreach (var product in randomProducts)
                                {

#line default
#line hidden
            BeginContext(6484, 183, true);
            WriteLiteral("                <div class=\"col-lg-4 col-md-4 col-12\">\n                    <div class=\"single-service\">\n                        <div class=\"service-head\">\n                            ");
            EndContext();
            BeginContext(6667, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8aabdcfb049ffe8dbafcd43572c932e7dc1656e513885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6677, "~/imageUploads/ProductImg/", 6677, 26, true);
#line 157 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6703, product.Image, 6703, 14, false);

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
            BeginContext(6727, 31, true);
            WriteLiteral("\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6758, "\"", 6819, 1);
#line 158 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 6765, Url.Action("Details","Products",new { id=product.ID}), 6765, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6820, 186, true);
            WriteLiteral("><div class=\"icon-bg\"><i class=\"fas fa-arrow-right\"></i></div></a>\n                        </div>\n                        <div class=\"service-content\">\n                            <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7006, "\"", 7067, 1);
#line 161 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 7013, Url.Action("Details","Products",new { id=product.ID}), 7013, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7068, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(7070, 12, false);
#line 161 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                                                                            Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(7082, 52, true);
            WriteLiteral("</a></h4>\n                            <a class=\"btn\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7134, "\"", 7195, 1);
#line 162 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 7141, Url.Action("Details","Products",new { id=product.ID}), 7141, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7196, 140, true);
            WriteLiteral("><i class=\"fas fa-arrow-circle-right\"></i>More Details</a>\n                        </div>\n                    </div>\n                </div> ");
            EndContext();
#line 165 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                       }
                            } 

#line default
#line hidden
            BeginContext(7370, 836, true);
            WriteLiteral(@"

            <!--/ End Single Service -->

        </div>
    </div>
</section>
<!--/ End Services -->
<!-- Latest Blog -->
<section class=""latest-blog section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 offset-lg-3 col-md-8 offset-md-2 col-12"">
                <div class=""section-title default text-center"">
                    <div class=""section-top"">
                        <h1><span>Published</span><b>Latest News</b></h1>
                    </div>
                    <div class=""section-bottom"">
                        <div class=""text"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <div class=""blog-latest blog-latest-slider"">
");
            EndContext();
#line 194 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                       if (ViewBag.displayedNews != null)
                                    {
                                        foreach (var news in ViewBag.displayedNews)
                                        {

#line default
#line hidden
            BeginContext(8427, 247, true);
            WriteLiteral(" <!-- Single Blog -->\n                                            <div class=\"single-news \">\n                                                <div class=\"news-head overlay\">\n                                                    <span class=\"news-img\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 8674, "\"", 8757, 3);
            WriteAttributeValue("", 8682, "background-image:url(\'../../imageUploads/NewsImg/", 8682, 49, true);
#line 200 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 8731, news.Image, 8731, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 8742, "\');height:200px", 8742, 15, true);
            EndWriteAttribute();
            BeginContext(8758, 63, true);
            WriteLiteral("></span>\n                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8821, "\"", 8880, 1);
#line 201 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 8828, Url.Action("NewsDetails","News",new { id= news.ID}), 8828, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8881, 331, true);
            WriteLiteral(@" class=""bizwheel-btn theme-2"">Read more</a>
                                                </div>
                                                <div class=""news-body"">
                                                    <div class=""news-content"">
                                                        <h3 class=""news-title""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9212, "\"", 9271, 1);
#line 205 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 9219, Url.Action("NewsDetails","News",new { id= news.ID}), 9219, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9272, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(9274, 10, false);
#line 205 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                                                                                                                         Write(news.Title);

#line default
#line hidden
            EndContext();
            BeginContext(9284, 189, true);
            WriteLiteral("</a></h3>\n                                                        <div class=\"news-text\">\n                                                            <p style=\"height:50px;overflow:hidden\">");
            EndContext();
            BeginContext(9474, 12, false);
#line 207 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                                                                              Write(news.Details);

#line default
#line hidden
            EndContext();
            BeginContext(9486, 254, true);
            WriteLiteral("</p>\n                                                        </div>\n                                                        <ul class=\"news-meta\">\n                                                            <li class=\"date\"><i class=\"fa fa-calendar\"></i>");
            EndContext();
            BeginContext(9741, 32, false);
#line 210 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                                                                                      Write(news.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(9773, 259, true);
            WriteLiteral(@"</li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div> <!--/ End Single Blog --> ");
            EndContext();
#line 214 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\Home\Index.cshtml"
                                                                             }
                                                                            } 

#line default
#line hidden
            BeginContext(10114, 3626, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>
<!--/ End Latest Blog -->
<!-- Client Area -->
<div class=""clients section-bg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""partner-slider"">
                    <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-1.png"" alt=""#""></a>
                        </div>
                    </div>
                    <!--/ End Single client -->
                    <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-2.png"" alt=""#""></a>
                        </div>
                    </div>
                    <!--/ End Single client -->
              ");
            WriteLiteral(@"      <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-3.png"" alt=""#""></a>
                        </div>
                    </div>
                    <!--/ End Single client -->
                    <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-4.png"" alt=""#""></a>
                        </div>
                    </div>
                    <!--/ End Single client -->
                    <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-5.png"" alt=""#""></a>
                        </div>
                    </div>
         ");
            WriteLiteral(@"           <!--/ End Single client -->
                    <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-6.png"" alt=""#""></a>
                        </div>
                    </div>
                    <!--/ End Single client -->
                    <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-7.png"" alt=""#""></a>
                        </div>
                    </div>
                    <!--/ End Single client -->
                    <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-8.png"" alt=""#""></a>
              ");
            WriteLiteral(@"          </div>
                    </div>
                    <!--/ End Single client -->
                    <!-- Single client -->
                    <div class=""single-slider"">
                        <div class=""single-client"">
                            <a href=""#"" target=""_blank""><img src=""../../img/client/client-9.png"" alt=""#""></a>
                        </div>
                    </div>
                    <!--/ End Single client -->


                </div>
            </div>
        </div>
    </div>
</div>
<!--/ End Client Area -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartSite.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
