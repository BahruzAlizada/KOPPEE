#pragma checksum "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4e0d5a5b69bf317ecacc3ebe2b752b37586555e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\_ViewImports.cshtml"
using KOPPEE.ViewsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e0d5a5b69bf317ecacc3ebe2b752b37586555e", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77357736ce29e63ec7732ec820b96cb94640ba3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid footer text-white mt-5 pt-5 px-0 position-relative overlay-top"">
    <div class=""row mx-0 pt-5 px-sm-3 px-lg-5 mt-4"">
        <div class=""col-lg-3 col-md-6 mb-5"">
            <h4 class=""text-white text-uppercase mb-4"" style=""letter-spacing: 3px;"">Get In Touch</h4>
            <p><i class=""fa fa-map-marker-alt mr-2""></i>");
#nullable restore
#line 7 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\Footer\Default.cshtml"
                                                   Write(Model.FooterAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><i class=\"fa fa-phone-alt mr-2\"></i>+");
#nullable restore
#line 8 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\Footer\Default.cshtml"
                                               Write(Model.FooterNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"m-0\"><i class=\"fa fa-envelope mr-2\"></i>");
#nullable restore
#line 9 "C:\Users\Esma\Desktop\KOPPEE\KOPPEE\KOPPEE\Views\Shared\Components\Footer\Default.cshtml"
                                                         Write(Model.FooterEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
        <div class=""col-lg-3 col-md-6 mb-5"">
            <h4 class=""text-white text-uppercase mb-4"" style=""letter-spacing: 3px;"">Follow Us</h4>
            <p>Amet elitr vero magna sed ipsum sit kasd sea elitr lorem rebum</p>
            <div class=""d-flex justify-content-start"">
                <a class=""btn btn-lg btn-outline-light btn-lg-square mr-2"" href=""#""><i class=""fab fa-twitter""></i></a>
                <a class=""btn btn-lg btn-outline-light btn-lg-square mr-2"" href=""#""><i class=""fab fa-facebook-f""></i></a>
                <a class=""btn btn-lg btn-outline-light btn-lg-square mr-2"" href=""#""><i class=""fab fa-linkedin-in""></i></a>
                <a class=""btn btn-lg btn-outline-light btn-lg-square"" href=""#""><i class=""fab fa-instagram""></i></a>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 mb-5"">
            <h4 class=""text-white text-uppercase mb-4"" style=""letter-spacing: 3px;"">Open Hours</h4>
            <div>
                <h6 class=""text");
            WriteLiteral(@"-white text-uppercase"">Monday - Friday</h6>
                <p>8.00 AM - 8.00 PM</p>
                <h6 class=""text-white text-uppercase"">Saturday - Sunday</h6>
                <p>2.00 PM - 8.00 PM</p>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 mb-5"">
            <h4 class=""text-white text-uppercase mb-4"" style=""letter-spacing: 3px;"">Newsletter</h4>
            <p>Amet elitr vero magna sed ipsum sit kasd sea elitr lorem rebum</p>
            <div class=""w-100"">
                <div class=""input-group"">
                    <input type=""text"" class=""form-control border-light"" style=""padding: 25px;"" placeholder=""Your Email"">
                    <div class=""input-group-append"">
                        <button class=""btn btn-primary font-weight-bold px-3"">Sign Up</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591