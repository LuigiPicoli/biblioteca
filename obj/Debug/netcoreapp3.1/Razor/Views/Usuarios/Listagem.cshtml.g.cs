#pragma checksum "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fec3f2388fd730267884281d0da4b999504c983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Listagem), @"mvc.1.0.view", @"/Views/Usuarios/Listagem.cshtml")]
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
#line 1 "C:\Users\User\Desktop\uc07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\uc07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fec3f2388fd730267884281d0da4b999504c983", @"/Views/Usuarios/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
         if(Model.Count > 0)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped""> 
            <thead>
                <tr><th>Id</th>
                <th>Nome</th>
                <th>Login</th>
                <th>Senha</th>
                <th>Tipo</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
                 foreach(Usuario l in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
                   Write(l.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
                   Write(l.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
                   Write(l.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
                   Write(l.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                     <td>");
#nullable restore
#line 27 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
                    Write(l.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 716, "\"", 745, 2);
            WriteAttributeValue("", 723, "/Usuarios/Editar/", 723, 17, true);
#nullable restore
#line 28 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
WriteAttributeValue("", 740, l.Id, 740, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 790, "\"", 820, 2);
            WriteAttributeValue("", 797, "excluirUsuario?Id=", 797, 18, true);
#nullable restore
#line 29 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
WriteAttributeValue("", 815, l.Id, 815, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 34 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 style=\"text-align: center; color: red;\">Nenhum registro encontrado</h1>\r\n");
#nullable restore
#line 37 "C:\Users\User\Desktop\uc07\Biblioteca\Views\Usuarios\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a href=\"Registrar\">Registrar novo usuário</a>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
