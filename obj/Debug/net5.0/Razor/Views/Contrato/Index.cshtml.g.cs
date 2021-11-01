#pragma checksum "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172169f36a3d6a01916ae817e9190b1273d875e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contrato_Index), @"mvc.1.0.view", @"/Views/Contrato/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172169f36a3d6a01916ae817e9190b1273d875e2", @"/Views/Contrato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d14f3c47dc399470d098747695894ab470f8087", @"/Views/_ViewImports.cshtml")]
    public class Views_Contrato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria_NetApi.Models.Contrato>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarPorFecha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inmueble", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
  
    ViewData["Title"] = "Index Contratos";
    List<Contrato> contratos = ViewData[nameof(Contrato)] as List<Contrato>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
 if(!User.Identity.IsAuthenticated)
 {
     await Html.RenderPartialAsync("_Login", new LoginView());
 }
 else
 {


#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
 if(ViewBag.multa == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""alert alert-danger aler-dismissible fade show"" role=""alert"">
            <strong>El Señor debe pagar una Multa de 2(Dos) Meses de alquiler por terminar antes su Contrato!!</strong>
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""cloce"">
                <span arial-hidden=""true""><span class=""fa fa-radiation-alt""></span></span>
            </button>
        </div>
");
#nullable restore
#line 23 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
 if(ViewBag.multa == 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""alert alert-danger aler-dismissible fade show"" role=""alert"">
            <strong>El Señor debe pagar una Multa de 1(Un) Meses de alquiler por terminar antes su Contrato!!</strong>
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""cloce"">
                <span arial-hidden=""true""><span class=""fa fa-radiation-alt""></span></span>
            </button>
        </div>
");
#nullable restore
#line 33 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5>Buscar Inmuebles por fecha:</h5><br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172169f36a3d6a01916ae817e9190b1273d875e27729", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""FechaInicio"">Fecha desde:</label>
        <input type=""date"" class=""form-control"" id=""desde"" name=""FechaInicio"">
    </div>
    <div class=""form-group"">
        <label for=""FechaFin"">Fecha hasta:</label>
        <input type=""date"" class=""form-control"" id=""hasta"" name=""FechaFin"">
    </div>
    &nbsp;
    <button type=""submit"" class=""btn btn-danger"">Ver disponibles</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br>\r\n");
            WriteLiteral("<h1>Nuestros Contratos Vigentes</h1>\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                Pagar $$\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fe_ini));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fe_fin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Inquilino.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Inmueble.Direccion_in));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th class=\"text-center\">\r\n                \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172169f36a3d6a01916ae817e9190b1273d875e211766", async() => {
                WriteLiteral(" Crear Contratos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                \r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 80 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
         foreach (var item in contratos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <big><big>\r\n                    <i class=\"fa fa-usd\"></i>\r\n                    ");
#nullable restore
#line 86 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
               Write(Html.ActionLink("Pagar", "Pagar", "Pago",new { id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </big></big>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.fe_ini, "{0:dd/MM/yyyy}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.fe_fin, "{0:dd/MM/yyyy}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Inquilino.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Inmueble.Direccion_in));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                <i class=\"fa fa-history\"></i>\r\n                ");
#nullable restore
#line 104 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
           Write(Html.ActionLink("Ver pagos", "PorContrato", "Pago", new { id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                <i class=\"fa fa-edit\"></i>\r\n                ");
#nullable restore
#line 106 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
           Write(Html.ActionLink("Editar", "Editar", new { id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                <i class=\"fa fa-info-circle\"></i>\r\n                ");
#nullable restore
#line 108 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
           Write(Html.ActionLink("Detalles", "Detalles", new { id=item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                \r\n");
#nullable restore
#line 110 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
                 if(ViewContext.HttpContext.User.IsInRole("Administrador"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fa fa-trash\"></i>\r\n");
#nullable restore
#line 113 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
               Write(Html.ActionLink("Cancelar", "Delete", new { id=item.Id}, new { onclick = "return confirm('Cancelar el Contrato de: " + @item.Inquilino.Nombre + "?')" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
                                                                                                                                                                             
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 118 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172169f36a3d6a01916ae817e9190b1273d875e217798", async() => {
                WriteLiteral("Crear Contratos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 125 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Contrato\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inmobiliaria_NetApi.Models.Contrato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
