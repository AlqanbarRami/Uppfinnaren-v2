#pragma checksum "c:\Users\ramia\source\repos\Art\Art\Views\Painting\getPainting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f692daa684e48f88f1841b7297d50192309821bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Painting_getPainting), @"mvc.1.0.view", @"/Views/Painting/getPainting.cshtml")]
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
#line 1 "c:\Users\ramia\source\repos\Art\Art\Views\_ViewImports.cshtml"
using Art.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\ramia\source\repos\Art\Art\Views\_ViewImports.cshtml"
using Art.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f692daa684e48f88f1841b7297d50192309821bc", @"/Views/Painting/getPainting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283b0edb609eced2ff32e1f20d18377334c25eb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Painting_getPainting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaintingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "c:\Users\ramia\source\repos\Art\Art\Views\Painting\getPainting.cshtml"
     foreach(var item in Model.Paintings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"get-container\">\r\n         \r\n                <img class=\"one-image\"");
            BeginWriteAttribute("src", " src=\"", 165, "\"", 182, 1);
#nullable restore
#line 7 "c:\Users\ramia\source\repos\Art\Art\Views\Painting\getPainting.cshtml"
WriteAttributeValue("", 171, item.Image, 171, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\"/>       \r\n          \r\n               </div>\r\n");
#nullable restore
#line 10 "c:\Users\ramia\source\repos\Art\Art\Views\Painting\getPainting.cshtml"
    
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaintingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
