#pragma checksum "C:\Projetos\senac-sjrp\senac-sjrp\Views\Pie\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23326fec818597d78a52636988b39fb929c5cc79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_Detail), @"mvc.1.0.view", @"/Views/Pie/Detail.cshtml")]
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
#line 1 "C:\Projetos\senac-sjrp\senac-sjrp\Views\_ViewImports.cshtml"
using senac_sjrp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\senac-sjrp\senac-sjrp\Views\_ViewImports.cshtml"
using senac_sjrp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23326fec818597d78a52636988b39fb929c5cc79", @"/Views/Pie/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b2f3d7094604935bac6be40858b1a161153b15", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg\">\r\n    <div class=\"form-group\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 78, "\"", 99, 1);
#nullable restore
#line 5 "C:\Projetos\senac-sjrp\senac-sjrp\Views\Pie\Detail.cshtml"
WriteAttributeValue("", 84, Model.ImageUrl, 84, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\" height=\"200px\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Name\">Nome da Torta: ");
#nullable restore
#line 8 "C:\Projetos\senac-sjrp\senac-sjrp\Views\Pie\Detail.cshtml"
                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"ShortDescription\">");
#nullable restore
#line 11 "C:\Projetos\senac-sjrp\senac-sjrp\Views\Pie\Detail.cshtml"
                                 Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"LongDescription\">");
#nullable restore
#line 14 "C:\Projetos\senac-sjrp\senac-sjrp\Views\Pie\Detail.cshtml"
                                Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Price\">Preço: R$ ");
#nullable restore
#line 17 "C:\Projetos\senac-sjrp\senac-sjrp\Views\Pie\Detail.cshtml"
                                Write(Model.Price.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    </div>\r\n</div>\r\n<a href=\"/pie\" class=\"btn btn-primary\">Voltar para Listagem</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
