#pragma checksum "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfacd642caef56ac0f0cde598af8d01f3a2718c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Colaboradores_Consultar), @"mvc.1.0.view", @"/Views/Colaboradores/Consultar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfacd642caef56ac0f0cde598af8d01f3a2718c0", @"/Views/Colaboradores/Consultar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4010fbf0197e4fb3803f79735f8c6d255a7d17", @"/Views/_ViewImports.cshtml")]
    public class Views_Colaboradores_Consultar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projetomvc.Models.Empregado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table id=""Programas"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Letras</th>
            <th>Email</th>
            <th>Cargo</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
         foreach(var empregado in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
               Write(empregado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
               Write(empregado.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
               Write(empregado.Letras);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
               Write(empregado.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
               Write(empregado.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  \r\n\r\n                <td>\r\n                    <button class=\"btn btn-secondary\"><a");
            BeginWriteAttribute("href", " href=\"", 682, "\"", 724, 2);
            WriteAttributeValue("", 689, "/Colaboradores/Editar/", 689, 22, true);
#nullable restore
#line 24 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
WriteAttributeValue("", 711, empregado.Id, 711, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></button> \r\n                    <button class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 801, "\"", 844, 2);
            WriteAttributeValue("", 808, "/Colaboradores/Excluir/", 808, 23, true);
#nullable restore
#line 25 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
WriteAttributeValue("", 831, empregado.Id, 831, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\Colaboradores\Consultar.cshtml"
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projetomvc.Models.Empregado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
