#pragma checksum "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20d4ecd17214860b09b6eedd7c1a77143d69241e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Starter_Consultar), @"mvc.1.0.view", @"/Views/Starter/Consultar.cshtml")]
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
#line 1 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\_ViewImports.cshtml"
using ProjetoProgramaStart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\_ViewImports.cshtml"
using ProjetoProgramaStart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20d4ecd17214860b09b6eedd7c1a77143d69241e", @"/Views/Starter/Consultar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4010fbf0197e4fb3803f79735f8c6d255a7d17", @"/Views/_ViewImports.cshtml")]
    public class Views_Starter_Consultar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projetomvc.Models.Starter>>
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


<h1>Starters</h1>

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
#line 33 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml"
         foreach(var starter in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml"
               Write(starter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml"
               Write(starter.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml"
               Write(starter.Letras);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                <td>\r\n                    <button class=\"btn btn-secondary\"><a");
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1119, 2);
            WriteAttributeValue("", 1092, "/Starter/Editar/", 1092, 16, true);
#nullable restore
#line 41 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml"
WriteAttributeValue("", 1108, starter.Id, 1108, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></button> \r\n                    <button class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 1196, "\"", 1231, 2);
            WriteAttributeValue("", 1203, "/Starter/Excluir/", 1203, 17, true);
#nullable restore
#line 42 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml"
WriteAttributeValue("", 1220, starter.Id, 1220, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></button>\r\n                    <button class=\"btn btn-info\"><a");
            BeginWriteAttribute("href", " href=\"", 1306, "\"", 1343, 2);
            WriteAttributeValue("", 1313, "/Starter/Avaliacao/", 1313, 19, true);
#nullable restore
#line 43 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml"
WriteAttributeValue("", 1332, starter.Id, 1332, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Avaliações</a></button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\ROTL\My Private Documents\MVC\projetomvc\Views\Starter\Consultar.cshtml"
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
