#pragma checksum "C:\Users\VISVARAJSINH\Desktop\Project\Helperland\ProjectHelperland\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f77a314403c9debbe0546e596bdf10554d1da089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#nullable restore
#line 1 "C:\Users\VISVARAJSINH\Desktop\Project\Helperland\ProjectHelperland\Views\_ViewImports.cshtml"
using ProjectHelperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VISVARAJSINH\Desktop\Project\Helperland\ProjectHelperland\Views\_ViewImports.cshtml"
using ProjectHelperland.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f77a314403c9debbe0546e596bdf10554d1da089", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a974c7aaa54fd6de60bbe3d36ff13c295e2d09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row  g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\VISVARAJSINH\Desktop\Project\Helperland\ProjectHelperland\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Helperland|Contact";
    Layout = "~/Views/Shared/PublicPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""contact_img"">

</div>

<section class=""faq_title text-center"">
    <h1>Contact us</h1>
    <h4><img src=""/images/forma-1-copy-5.png"" class=""text-center""></h4>


    <div class=""extra-service d-flex flex-wrap justify-content-center align-items-center"">
        <div class=""extra-items text-center "">
            <div class="" d-flex justify-content-center align-items-center mx-auto"">
                <img src=""/images/forma-1_2.png""");
            BeginWriteAttribute("alt", " alt=\"", 569, "\"", 575, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""extra-details mt-3"">
                <p class=""extra-title mb-0"">
                    1111 Lorem ipsum text 100,<br>Lorem ipsum AB
                </p>
            </div>
        </div>
        <div class=""extra-items text-center"">
            <div class="" d-flex justify-content-center align-items-center mx-auto"">
                <img src=""/images/phone-call.png""");
            BeginWriteAttribute("alt", " alt=\"", 996, "\"", 1002, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""extra-details mt-3"">
                <p class=""extra-title mb-0"">
                    +49 (40) 123 56 7890<br>
                    +49 (40) 123 56 7890
                </p>
            </div>
        </div>
        <div class=""extra-items text-center"">
            <div class=""d-flex justify-content-center align-items-center mx-auto"">
                <img src=""/images/vector-smart-object.png""");
            BeginWriteAttribute("alt", " alt=\"", 1453, "\"", 1459, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""extra-details mt-3"">
                <p class=""extra-title mb-0"">
                    info@helperland.com
                </p>
            </div>
        </div>

    </div>
    <h5 class=""p_hr mx-auto mt-3""></h5>
</section>

<section class=""contact"">
    <h2 class=""text-center"">Get in touch with us</h2>
    <div class=""Contact_form mx-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77a314403c9debbe0546e596bdf10554d1da0896136", async() => {
                WriteLiteral(@"
            <div class=""col-md-6"">
                <input type=""text"" name=""Firstname"" class=""form-control"" id=""Firstname"" placeholder=""First Name"" required>
            </div>
            <div class=""col-md-6"">
                <input type=""text"" name=""Lastname"" class=""form-control"" id=""Lastname"" placeholder=""Last Name"" required>
            </div>
            <div class=""col-md-6"">
                <div class=""row g-0"">

                    <div class=""col-sm-12 input-group"">
                        <span class=""c_code align-items-center justify-content-center"">+49</span>
                        <input type=""number"" name=""Phonenumber"" class=""form-control"" id=""Phone number"" placeholder=""Mobile Number"" required>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <input type=""email"" name=""Email"" class=""form-control"" id=""Email"" placeholder=""Email address"" required>
            </div>
            <div class=""col-md-12"">
     ");
                WriteLiteral(@"           <input type=""text"" name=""Subject"" class=""form-control"" id=""subject"" placeholder=""Subject"" required>
            </div>
            <div class=""col-md-12"">
                <textarea class=""form-control"" id=""message"" placeholder=""Messages"" rows=""4""></textarea>
            </div>
            <div class=""col-md-12 text-center"">
                <button class=""c_sub_btn"" type=""submit"" name=""Submit""><h3>Submit</h3></button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

</section>
<section class=""map"">
    <div class=""contact_map"">
        <img src=""/images/pin.png"" class=""map_img"">
    </div>
</section>

<section class=""news_letter f_color bg-white"">
    <div class=""container text-center"">

        <h2>GET OUR NEWSLETTER</h2>
        <div class=""form-row d-flex justify-content-center align-items-center"">
            <div class=""form-group"">
                <label for=""email"" style=""display: none;"">YOUR EMAIL</label>
                <input type=""text"" placeholder=""YOUR EMAIL"" id=""email"" class=""form-control"">
            </div>
            <div class=""btn-wrapper"">
                <button class=""submit_btn"">Submit</button>
            </div>
        </div>
    </div>
</section>

");
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
