#pragma checksum "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02587f744b7b11492e8f4432b675f55677611f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inquilino_Editar), @"mvc.1.0.view", @"/Views/Inquilino/Editar.cshtml")]
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
#line 1 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\_ViewImports.cshtml"
using Inmobiliaria_NetApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\_ViewImports.cshtml"
using Inmobiliaria_NetApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02587f744b7b11492e8f4432b675f55677611f03", @"/Views/Inquilino/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d14f3c47dc399470d098747695894ab470f8087", @"/Views/_ViewImports.cshtml")]
    public class Views_Inquilino_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inmobiliaria_NetApi.Models.Inquilino>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
  
    ViewData["Title"] = "Editar";
    int id = Model.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
 if(!User.Identity.IsAuthenticated)
 {
     await Html.RenderPartialAsync("_Login", new LoginView());
 }
 else
 {


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Editar el Inquilino: ");
#nullable restore
#line 15 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
                    Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02587f744b7b11492e8f4432b675f55677611f035265", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02587f744b7b11492e8f4432b675f55677611f035535", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"dni_id\" class=\"control-label\">DNI</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"dni_id\" name=\"dni\"");
                BeginWriteAttribute("value", " value=\"", 607, "\"", 625, 1);
#nullable restore
#line 23 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 615, Model.Dni, 615, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"name_id\" class=\"control-label\">Nombre</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"name_id\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 844, "\"", 865, 1);
#nullable restore
#line 27 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 852, Model.Nombre, 852, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"mail\" class=\"control-label\">Mail</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"mail\" name=\"mail\"");
                BeginWriteAttribute("value", " value=\"", 1074, "\"", 1093, 1);
#nullable restore
#line 31 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 1082, Model.Mail, 1082, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"dire\" class=\"control-label\">Direccion</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"direccion\" name=\"direccion\"");
                BeginWriteAttribute("value", " value=\"", 1317, "\"", 1341, 1);
#nullable restore
#line 35 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 1325, Model.Direccion, 1325, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"tel\" class=\"control-label\">Tele. de Inquilino</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"tel_inquilino\" name=\"tel_inquilino\"");
                BeginWriteAttribute("value", " value=\"", 1581, "\"", 1609, 1);
#nullable restore
#line 39 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 1589, Model.tel_inquilino, 1589, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"trabajo\" class=\"control-label\">Lugar de Trabajo</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"lugartrabajo\" name=\"lugartrabajo\"");
                BeginWriteAttribute("value", " value=\"", 1849, "\"", 1876, 1);
#nullable restore
#line 43 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 1857, Model.lugarTrabajo, 1857, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"dire\" class=\"control-label\">Nombre del Garante</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"nom_garante\" name=\"nom_garante\"");
                BeginWriteAttribute("value", " value=\"", 2113, "\"", 2139, 1);
#nullable restore
#line 47 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 2121, Model.nom_garante, 2121, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"dire\" class=\"control-label\">DNI del Garante </label>\r\n                <input type=\"text\" class=\"form-control\" id=\"dni_garante\" name=\"dni_garante\"");
                BeginWriteAttribute("value", " value=\"", 2374, "\"", 2400, 1);
#nullable restore
#line 51 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 2382, Model.dni_garante, 2382, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"dire\" class=\"control-label\">Telef. del garante</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"tel_garante\" name=\"tel_garante\"");
                BeginWriteAttribute("value", " value=\"", 2637, "\"", 2663, 1);
#nullable restore
#line 55 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
WriteAttributeValue("", 2645, Model.tel_garante, 2645, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <input type=\"submit\" value=\"Confirmar\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 61 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inquilino\Editar.cshtml"
 }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inmobiliaria_NetApi.Models.Inquilino> Html { get; private set; }
    }
}
#pragma warning restore 1591
