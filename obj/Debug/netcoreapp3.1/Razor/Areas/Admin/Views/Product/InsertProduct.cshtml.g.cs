#pragma checksum "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\InsertProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2427a81f1f62cd2aa9d200a0ad4cbc6d5b674834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_InsertProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/InsertProduct.cshtml")]
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
#line 1 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\_ViewImports.cshtml"
using ShoesLover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\_ViewImports.cshtml"
using ShoesLover.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2427a81f1f62cd2aa9d200a0ad4cbc6d5b674834", @"/Areas/Admin/Views/Product/InsertProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d652e32e50049a3a6fb731130cf3a1e6ecd20d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_InsertProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>");
#nullable restore
#line 4 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\InsertProduct.cshtml"
Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<a class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("href", " href=\"", 86, "\"", 125, 2);
            WriteAttributeValue("", 93, "InsertVariant?id=", 93, 17, true);
#nullable restore
#line 5 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\InsertProduct.cshtml"
WriteAttributeValue("", 110, ViewData["id"], 110, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Thiet lap variant</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
