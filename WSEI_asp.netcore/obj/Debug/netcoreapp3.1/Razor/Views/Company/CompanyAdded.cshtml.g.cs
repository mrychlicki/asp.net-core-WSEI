#pragma checksum "C:\Users\user\Desktop\asp.net\WSEI_asp.netcore\asp.net-core-WSEI\WSEI_asp.netcore\Views\Company\CompanyAdded.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f49471b8e64489ab78fe76d55d6b2805c2d80a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_CompanyAdded), @"mvc.1.0.view", @"/Views/Company/CompanyAdded.cshtml")]
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
#line 1 "C:\Users\user\Desktop\asp.net\WSEI_asp.netcore\asp.net-core-WSEI\WSEI_asp.netcore\Views\_ViewImports.cshtml"
using WSEI_asp.netcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\asp.net\WSEI_asp.netcore\asp.net-core-WSEI\WSEI_asp.netcore\Views\_ViewImports.cshtml"
using WSEI_asp.netcore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f49471b8e64489ab78fe76d55d6b2805c2d80a", @"/Views/Company/CompanyAdded.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558147ee8cbf80f17f6ef4849e64dd06127e0869", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_CompanyAdded : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyAddedViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Your company was successfully added!</h1>\r\n\r\n\r\n<h3>Statistic:</h3>\r\n\r\n<div>Chars in name: ");
#nullable restore
#line 8 "C:\Users\user\Desktop\asp.net\WSEI_asp.netcore\asp.net-core-WSEI\WSEI_asp.netcore\Views\Company\CompanyAdded.cshtml"
               Write(Model.NumberOfCharInName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>Chars in description: ");
#nullable restore
#line 10 "C:\Users\user\Desktop\asp.net\WSEI_asp.netcore\asp.net-core-WSEI\WSEI_asp.netcore\Views\Company\CompanyAdded.cshtml"
                      Write(Model.NumberOfCharInDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>Currently hidden: ");
#nullable restore
#line 12 "C:\Users\user\Desktop\asp.net\WSEI_asp.netcore\asp.net-core-WSEI\WSEI_asp.netcore\Views\Company\CompanyAdded.cshtml"
                   Write(Model.IsHidden ? "yes" : "no");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyAddedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
