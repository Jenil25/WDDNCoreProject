#pragma checksum "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\Home\OnlinePlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6909fedca7e7982e95c4284109ae3776917b59ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OnlinePlayer), @"mvc.1.0.view", @"/Views/Home/OnlinePlayer.cshtml")]
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
#line 1 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\_ViewImports.cshtml"
using OnlineMovieBuyingRentingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\_ViewImports.cshtml"
using OnlineMovieBuyingRentingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6909fedca7e7982e95c4284109ae3776917b59ba", @"/Views/Home/OnlinePlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec8d2f216e428e28c557469747994b097c4883e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OnlinePlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieBuyingRentingSystem.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\Home\OnlinePlayer.cshtml"
  
    ViewData["Title"] = "Watch online";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Enjoy ");
#nullable restore
#line 6 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\Home\OnlinePlayer.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\" style=\"margin-right:40rem\">\r\n\r\n    <div class=\"col\" style=\"padding:3rem; margin-left: 5rem;\">\r\n        <!-- player-->\r\n        <div style=\"margin-right:7rem\">\r\n            <iframe id=\"player\" width=\"900\" height=\"510\"");
            BeginWriteAttribute("src", " src=", 367, "", 387, 1);
#nullable restore
#line 13 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\Home\OnlinePlayer.cshtml"
WriteAttributeValue("", 372, Model.RentLink, 372, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\"></iframe>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMovieBuyingRentingSystem.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
