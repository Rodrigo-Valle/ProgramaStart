#pragma checksum "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\RemoverStarters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e19191e4daf86025103f1e1383877ca968fd89b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grupo_RemoverStarters), @"mvc.1.0.view", @"/Views/Grupo/RemoverStarters.cshtml")]
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
#line 1 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\_ViewImports.cshtml"
using ProjetoProgramaStart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\_ViewImports.cshtml"
using ProjetoProgramaStart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e19191e4daf86025103f1e1383877ca968fd89b", @"/Views/Grupo/RemoverStarters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4010fbf0197e4fb3803f79735f8c6d255a7d17", @"/Views/_ViewImports.cshtml")]
    public class Views_Grupo_RemoverStarters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projetomvc.Models.Starter>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#modelo').DataTable({
            ""language"": {
                ""lengthMenu"": ""Mostrar _MENU_ registros por paginas"",
                ""zeroRecords"": ""Nada encontrado"",
                ""info"": ""Mostrando a pagina _PAGE_ de _PAGES_"",
                ""infoEmpty"": ""Nada a exibir"",
                ""infoFiltered"": ""(filtrado de _MAX_ registros)""
            }
        });
    });
</script>


<h1>Remover Starter</h1>

<hr>
<br>

<table id=""modelo"" class=""table table-sm table-hover table-striped table-bordered"">
    <thead>
        <tr class=""table-primary"">
            <th>Id</th>
            <th>Nome</th>
            <th>Letras</th>
            <th></th>
        </tr>
    </thead>
    <tbody> 
");
#nullable restore
#line 33 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\RemoverStarters.cshtml"
         foreach(var starter in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\RemoverStarters.cshtml"
               Write(starter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\RemoverStarters.cshtml"
               Write(starter.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\RemoverStarters.cshtml"
               Write(starter.Letras);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 1086, "\"", 1126, 2);
            WriteAttributeValue("", 1093, "/Grupo/ExcluirStarter/", 1093, 22, true);
#nullable restore
#line 39 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\RemoverStarters.cshtml"
WriteAttributeValue("", 1115, starter.Id, 1115, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a></button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\RemoverStarters.cshtml"
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projetomvc.Models.Starter>> Html { get; private set; }
    }
}
#pragma warning restore 1591
