#pragma checksum "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bfea13b45fc5714ee163e67a011619ae40286af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_About_Default), @"mvc.1.0.view", @"/Views/Shared/Components/About/Default.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\_ViewImports.cshtml"
using KOPPEE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\_ViewImports.cshtml"
using KOPPEE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bfea13b45fc5714ee163e67a011619ae40286af", @"/Views/Shared/Components/About/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0e288acadc630beadac644d58290d355ae1e0d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_About_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("position-absolute w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit: cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"section-title\">\r\n        <h4 class=\"text-primary text-uppercase\" style=\"letter-spacing: 5px;\">About Us</h4>\r\n        <h1 class=\"display-4\">");
#nullable restore
#line 6 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml"
                         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-4 py-0 py-lg-5\">\r\n            <h1 class=\"mb-3\">Our Story</h1>\r\n            <h5 class=\"mb-3\">");
#nullable restore
#line 11 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml"
                        Write(Model.SubTitleStory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p>");
#nullable restore
#line 12 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml"
          Write(Model.StoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 454, "\"", 461, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary font-weight-bold py-2 px-4 mt-2\">Learn More</a>\r\n        </div>\r\n        <div class=\"col-lg-4 py-5 py-lg-0\" style=\"min-height: 500px;\">\r\n            <div class=\"position-relative h-100\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8bfea13b45fc5714ee163e67a011619ae40286af5467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 740, "~/img/", 740, 6, true);
#nullable restore
#line 17 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml"
AddHtmlAttributeValue("", 746, Model.Image, 746, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-4 py-0 py-lg-5\">\r\n            <h1 class=\"mb-3\">Our Vision</h1>\r\n            <p>");
#nullable restore
#line 22 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml"
          Write(Model.VisionDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h5 class=\"mb-3\"><i class=\"fa fa-check text-primary mr-3\"></i>");
#nullable restore
#line 23 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml"
                                                                     Write(Model.VisionGoalOne);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 class=\"mb-3\"><i class=\"fa fa-check text-primary mr-3\"></i>");
#nullable restore
#line 24 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml"
                                                                     Write(Model.VisionGoalTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 class=\"mb-3\"><i class=\"fa fa-check text-primary mr-3\"></i>");
#nullable restore
#line 25 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\About\Default.cshtml"
                                                                     Write(Model.VisionGoalThree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1280, "\"", 1287, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary font-weight-bold py-2 px-4 mt-2\">Learn More</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
