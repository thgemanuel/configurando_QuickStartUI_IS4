#pragma checksum "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c232cb3a6fd4eb51cb4e4e0d7a8ae3ed4bf3e63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
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
#line 1 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c232cb3a6fd4eb51cb4e4e0d7a8ae3ed4bf3e63", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b49bb18fbe88f2fb7e20eb130e64338d7f2c37", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScopeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 180, "\"", 219, 2);
            WriteAttributeValue("", 201, "scopes_", 201, 7, true);
#nullable restore
#line (8,27)-(8,38) 29 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 208, Model.Name, 208, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 220, "\"", 255, 1);
#nullable restore
#line (9,23)-(9,34) 29 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 244, Model.Name, 244, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 256, "\"", 296, 1);
#nullable restore
#line (10,25)-(10,39) 29 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 282, Model.Checked, 282, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 297, "\"", 339, 1);
#nullable restore
#line (11,26)-(11,41) 29 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 324, Model.Required, 324, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 461, "\"", 500, 1);
#nullable restore
#line (16,27)-(16,38) 29 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 489, Model.Name, 489, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line (18,18)-(18,35) 6 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 19 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
#nullable restore
#line 22 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\r\n");
#nullable restore
#line 24 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\r\n");
#nullable restore
#line 27 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 888, "\"", 912, 2);
            WriteAttributeValue("", 894, "scopes_", 894, 7, true);
#nullable restore
#line (31,32)-(31,43) 29 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 901, Model.Name, 901, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line (31,46)-(31,63) 6 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Thiago\Documents\cursos\configurando_QuickStartUI_IS4\IdentityServer4Curso\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScopeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
