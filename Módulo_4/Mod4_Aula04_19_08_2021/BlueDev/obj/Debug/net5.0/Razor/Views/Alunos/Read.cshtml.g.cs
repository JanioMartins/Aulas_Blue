#pragma checksum "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "165d1f397a9fe5c9f39ec1c649014363f33653ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Read), @"mvc.1.0.view", @"/Views/Alunos/Read.cshtml")]
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
#line 1 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\_ViewImports.cshtml"
using BlueDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\_ViewImports.cshtml"
using BlueDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"165d1f397a9fe5c9f39ec1c649014363f33653ed", @"/Views/Alunos/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e399024f77e8a9977f3867709102956161b2e5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Alunos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Alunos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
 if(Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>ALUNO NÃO EXISTE</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165d1f397a9fe5c9f39ec1c649014363f33653ed4330", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
}
else { 


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Visualizando Aluno ");
#nullable restore
#line 10 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("<dl class=\"row\">\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 14 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 15 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 17 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 18 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 20 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 21 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n");
            WriteLiteral("</dl><br />\r\n");
#nullable restore
#line 26 "E:\Dev\Blue_Edtech\Aulas_Blue\Módulo_4\Mod4_Aula04_19_08_2021\BlueDev\Views\Alunos\Read.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165d1f397a9fe5c9f39ec1c649014363f33653ed8179", async() => {
                WriteLiteral("Voltar!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Alunos> Html { get; private set; }
    }
}
#pragma warning restore 1591
