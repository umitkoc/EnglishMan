#pragma checksum "C:\Users\umitkoc\Desktop\EnglishMan\EnglishManWebUI\Views\home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a27b5ebfca769bb28898a4b0714d54e564e19f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_home_index), @"mvc.1.0.view", @"/Views/home/index.cshtml")]
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
#line 3 "C:\Users\umitkoc\Desktop\EnglishMan\EnglishManWebUI\Views\_ViewImports.cshtml"
using EnglishManWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a27b5ebfca769bb28898a4b0714d54e564e19f", @"/Views/home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567816bd99e3c7be6d43e6bbf5e02f4077ff5fcc", @"/Views/_ViewImports.cshtml")]
    public class Views_home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Start: Slider Section -->\r\n");
#nullable restore
#line 2 "C:\Users\umitkoc\Desktop\EnglishMan\EnglishManWebUI\Views\home\index.cshtml"
Write(await Html.PartialAsync("_slider"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- End: Slider Section -->\r\n\r\n<!-- Start: Welcome Section -->\r\n");
#nullable restore
#line 6 "C:\Users\umitkoc\Desktop\EnglishMan\EnglishManWebUI\Views\home\index.cshtml"
Write(await Html.PartialAsync("_welcome"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- End: Welcome Section -->\r\n\r\n<!-- Start: Category Filter -->\r\n");
#nullable restore
#line 10 "C:\Users\umitkoc\Desktop\EnglishMan\EnglishManWebUI\Views\home\index.cshtml"
Write(await Html.PartialAsync("_categoryfilter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Start: Category Filter -->\r\n\r\n<!-- Start: Features -->\r\n");
#nullable restore
#line 14 "C:\Users\umitkoc\Desktop\EnglishMan\EnglishManWebUI\Views\home\index.cshtml"
Write(await Html.PartialAsync("_advantage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- End: Features -->\r\n\r\n<!-- Start: Meet Staff -->\r\n");
#nullable restore
#line 18 "C:\Users\umitkoc\Desktop\EnglishMan\EnglishManWebUI\Views\home\index.cshtml"
Write(await Html.PartialAsync("_producers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- End: Meet Staff -->\r\n\r\n<!-- Start: Our Community Section -->\r\n");
#nullable restore
#line 22 "C:\Users\umitkoc\Desktop\EnglishMan\EnglishManWebUI\Views\home\index.cshtml"
Write(await Html.PartialAsync("_comments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- End: Our Community Section -->");
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