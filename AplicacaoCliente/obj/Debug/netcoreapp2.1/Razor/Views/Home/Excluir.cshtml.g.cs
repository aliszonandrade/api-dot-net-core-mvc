#pragma checksum "C:\Users\aliss\source\repos\MinhaWebAPI\AplicacaoCliente\Views\Home\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "749c3c1b99dd6f45899282d0b38e9c1237c956c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Excluir), @"mvc.1.0.view", @"/Views/Home/Excluir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Excluir.cshtml", typeof(AspNetCore.Views_Home_Excluir))]
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
#line 1 "C:\Users\aliss\source\repos\MinhaWebAPI\AplicacaoCliente\Views\_ViewImports.cshtml"
using AplicacaoCliente;

#line default
#line hidden
#line 2 "C:\Users\aliss\source\repos\MinhaWebAPI\AplicacaoCliente\Views\_ViewImports.cshtml"
using AplicacaoCliente.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749c3c1b99dd6f45899282d0b38e9c1237c956c6", @"/Views/Home/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2994dbb7a226b1e497188a2ba1d4f88f25003c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 428, true);
            WriteLiteral(@"<h2>Excluir Cliente</h2>

<h3>Deseja realmente excluir o cliente?</h3>
<button class=""btn btn-danger"" onclick=""excluir(1)"">Sim</button>
<button class=""btn btn-default""onclick=""excluir(0)"">Não</button>

<script>
    function excluir(id) {
        if (id == 0)
            window.location.href = window.location.origin;
        else
            window.location.href = window.location.origin + ""/Home/ExcluirCliente/"" + ");
            EndContext();
            BeginContext(429, 21, false);
#line 12 "C:\Users\aliss\source\repos\MinhaWebAPI\AplicacaoCliente\Views\Home\Excluir.cshtml"
                                                                                 Write(ViewData["ClienteID"]);

#line default
#line hidden
            EndContext();
            BeginContext(450, 19, true);
            WriteLiteral(";\r\n    }\r\n</script>");
            EndContext();
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
