#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace.web\Views\Shared\_NoItemFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a4161f9a056b34b3f28c2fb998b1af372a24229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NoItemFound), @"mvc.1.0.view", @"/Views/Shared/_NoItemFound.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace.web\Views\_ViewImports.cshtml"
using MarketPlace.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.web\Views\_ViewImports.cshtml"
using MarketPlace.web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a4161f9a056b34b3f28c2fb998b1af372a24229", @"/Views/Shared/_NoItemFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4611585adaf0e3258a968658f1a770fefe09285e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NoItemFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"alert alert-warning\">\r\n    <p>");
#nullable restore
#line 3 "D:\MarketPlace\MarketPlace\MarketPlace.web\Views\Shared\_NoItemFound.cshtml"
  Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
