#pragma checksum "C:\Users\Esma\Desktop\Visual studio c#\KOPPEE\KOPPEE\KOPPEE\Areas\Admin\Views\Offers\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6221fe39112c47c36498cad6ddabd8c58cfcbc1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Offers_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Offers/Detail.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\Visual studio c#\KOPPEE\KOPPEE\KOPPEE\Areas\Admin\Views\_ViewImports.cshtml"
using KOPPEE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\Visual studio c#\KOPPEE\KOPPEE\KOPPEE\Areas\Admin\Views\_ViewImports.cshtml"
using KOPPEE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esma\Desktop\Visual studio c#\KOPPEE\KOPPEE\KOPPEE\Areas\Admin\Views\_ViewImports.cshtml"
using KOPPEE.ViewsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6221fe39112c47c36498cad6ddabd8c58cfcbc1d", @"/Areas/Admin/Views/Offers/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77357736ce29e63ec7732ec820b96cb94640ba3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Offers_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Offer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Esma\Desktop\Visual studio c#\KOPPEE\KOPPEE\KOPPEE\Areas\Admin\Views\Offers\Detail.cshtml"
  
	Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Esma\Desktop\Visual studio c#\KOPPEE\KOPPEE\KOPPEE\Areas\Admin\Views\Offers\Detail.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h4>");
#nullable restore
#line 8 "C:\Users\Esma\Desktop\Visual studio c#\KOPPEE\KOPPEE\KOPPEE\Areas\Admin\Views\Offers\Detail.cshtml"
Write(Model.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<p>");
#nullable restore
#line 9 "C:\Users\Esma\Desktop\Visual studio c#\KOPPEE\KOPPEE\KOPPEE\Areas\Admin\Views\Offers\Detail.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Offer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591