#pragma checksum "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\ProgramaStart\ConsultarModulos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51f871fb5a7cbdb64a3e06c90b0b2aec027e775"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgramaStart_ConsultarModulos), @"mvc.1.0.view", @"/Views/ProgramaStart/ConsultarModulos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51f871fb5a7cbdb64a3e06c90b0b2aec027e775", @"/Views/ProgramaStart/ConsultarModulos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4010fbf0197e4fb3803f79735f8c6d255a7d17", @"/Views/_ViewImports.cshtml")]
    public class Views_ProgramaStart_ConsultarModulos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projetomvc.Models.Modulo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoModulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Modulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<button class=\"btn btn-primary btn-lg\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51f871fb5a7cbdb64a3e06c90b0b2aec027e7753982", async() => {
                WriteLiteral("Cadastrar novo modulo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n\r\n<hr>\r\n\r\n\r\n<table id=\"Programas\" class=\"table table-striped table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\ProgramaStart\ConsultarModulos.cshtml"
         foreach(var modulo in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\ProgramaStart\ConsultarModulos.cshtml"
               Write(modulo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\ProgramaStart\ConsultarModulos.cshtml"
               Write(modulo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <button class=\"btn btn-secondary\"><a");
            BeginWriteAttribute("href", " href=\"", 591, "\"", 623, 2);
            WriteAttributeValue("", 598, "/Modulo/Editar/", 598, 15, true);
#nullable restore
#line 23 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\ProgramaStart\ConsultarModulos.cshtml"
WriteAttributeValue("", 613, modulo.Id, 613, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></button> \r\n                    <button class=\"btn btn-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 733, 2);
            WriteAttributeValue("", 707, "/Modulo/Excluir/", 707, 16, true);
#nullable restore
#line 24 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\ProgramaStart\ConsultarModulos.cshtml"
WriteAttributeValue("", 723, modulo.Id, 723, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\ROTL\OneDrive - GFT Technologies SE\Desktop\Estágio\ProjetoMVC\ProjetoMVC\projetomvc\Views\ProgramaStart\ConsultarModulos.cshtml"
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    \r\n\r\n</table>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projetomvc.Models.Modulo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
