#pragma checksum "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "122ea87f9044ff029b33121105c183b54ab2e1a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grupo_Consultar), @"mvc.1.0.view", @"/Views/Grupo/Consultar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"122ea87f9044ff029b33121105c183b54ab2e1a4", @"/Views/Grupo/Consultar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4010fbf0197e4fb3803f79735f8c6d255a7d17", @"/Views/_ViewImports.cshtml")]
    public class Views_Grupo_Consultar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projetomvc.Models.Grupo>>
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


<h1>Grupos</h1>

<hr>
<br>

<table id=""modelo"" class=""table table-sm table-hover table-striped table-bordered"">
    <thead>
        <tr class=""table-primary"">
            <th>Id</th>
            <th>Tecnologia</th>
            <th>Programa Start</th>
            <th>ScrumMaster</th>
            <th>Letras</th>
            <th></th>
        </tr>
    </thead>
    <tbody> 
");
#nullable restore
#line 35 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
         foreach(var grupo in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
               Write(grupo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
               Write(grupo.Tecnologia.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
               Write(grupo.ProgramaStart.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
               Write(grupo.ScrumMaster.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
               Write(grupo.ScrumMaster.Letras);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                \r\n                <td>\r\n                    <button class=\"btn btn-secondary\"><a");
            BeginWriteAttribute("href", " href=\"", 1306, "\"", 1336, 2);
            WriteAttributeValue("", 1313, "/Grupo/Editar/", 1313, 14, true);
#nullable restore
#line 44 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
WriteAttributeValue("", 1327, grupo.Id, 1327, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></button> \r\n                    <button class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 1413, "\"", 1444, 2);
            WriteAttributeValue("", 1420, "/Grupo/Excluir/", 1420, 15, true);
#nullable restore
#line 45 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
WriteAttributeValue("", 1435, grupo.Id, 1435, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Grupo\Consultar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projetomvc.Models.Grupo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
