#pragma checksum "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01896feaea8b2102664ddd2328b8701cab3e4bea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductType_EditProductType), @"mvc.1.0.view", @"/Views/ProductType/EditProductType.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductType/EditProductType.cshtml", typeof(AspNetCore.Views_ProductType_EditProductType))]
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
#line 2 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01896feaea8b2102664ddd2328b8701cab3e4bea", @"/Views/ProductType/EditProductType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc463cf8b5e4e921b6b610d83d58c2acd0e08265", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductType_EditProductType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSite.Models.ProductType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
   ViewBag.Title = "EditProductType"; 

#line default
#line hidden
            BeginContext(158, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
 using (Html.BeginForm("EditProductType", "ProductType", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(278, 23, false);
#line 8 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(302, 214, true);
            WriteLiteral("                <div class=\"contact-form-area m-top-30 d-flex justify-content-center\" style=\"width:50%;margin-left:25%\">\n                    <div class=\"row d-flex justify-content-center\">\n\n                        ");
            EndContext();
            BeginContext(517, 25, false);
#line 12 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                   Write(Html.HiddenFor(m => m.ID));

#line default
#line hidden
            EndContext();
            BeginContext(542, 146, true);
            WriteLiteral("\n\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(689, 26, false);
#line 16 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                           Write(Html.LabelFor(m => m.Type));

#line default
#line hidden
            EndContext();
            BeginContext(715, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(749, 88, false);
#line 17 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                           Write(Html.TextBoxFor(m => m.Type, new { @class = "form-control", placeholder = "Type Name" }));

#line default
#line hidden
            EndContext();
            BeginContext(837, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(871, 96, false);
#line 18 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Type, "Must Upload Type Image", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(967, 212, true);
            WriteLiteral("\n                            </div>\n                        </div>\n\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(1180, 32, false);
#line 24 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                           Write(Html.LabelFor(m => m.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(1246, 142, false);
#line 25 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                           Write(Html.DropDownListFor(s => s.CategoryID, ViewData["Category"] as IEnumerable<SelectListItem>, new { @class = "browser-default custom-select" }));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(1422, 80, false);
#line 26 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                           Write(Html.ValidationMessageFor(m => m.CategoryID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 212, true);
            WriteLiteral("\n                            </div>\n                        </div>\n\n                        <div class=\"col-lg-12 col-md-12 \">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(1715, 27, false);
#line 32 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                           Write(Html.LabelFor(t => t.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 84, true);
            WriteLiteral("\n                                <input class=\"form-control\" type=\"file\" name=\"file\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1826, "\"", 1911, 1);
#line 33 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
WriteAttributeValue("", 1834, HttpContextAccessor.HttpContext.Session.GetString("oldImagePath").ToString(), 1834, 77, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1912, 114, true);
            WriteLiteral(" accept=\"image/*\">\n                                <span class=\"text-danger\">\n                                    ");
            EndContext();
            BeginContext(2027, 15, false);
#line 35 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                               Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2042, 138, true);
            WriteLiteral("\n                                </span>\n                            </div>\n                        </div>\n\n                        <input");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2180, "\"", 2265, 1);
#line 40 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
WriteAttributeValue("", 2188, HttpContextAccessor.HttpContext.Session.GetString("oldImagePath").ToString(), 2188, 77, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2266, 365, true);
            WriteLiteral(@" name=""deletingImgPath"" hidden />

                        <div class=""col-lg-12 col-md-12 "">
                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-primary"" id=""edit"">Edit</button>
                            </div>
                        </div>

                    </div>
                </div>");
            EndContext();
#line 49 "D:\IQ2Life\Smart-master Core\SmartSite\SmartSite\Views\ProductType\EditProductType.cshtml"
                      }

#line default
#line hidden
            BeginContext(2633, 1, true);
            WriteLiteral("\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartSite.Models.ProductType> Html { get; private set; }
    }
}
#pragma warning restore 1591
