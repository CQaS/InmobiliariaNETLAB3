#pragma checksum "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cbb69c97a83718becbdaf2a61eeef0a45b4339e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inmueble_Editar), @"mvc.1.0.view", @"/Views/Inmueble/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cbb69c97a83718becbdaf2a61eeef0a45b4339e", @"/Views/Inmueble/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d14f3c47dc399470d098747695894ab470f8087", @"/Views/_ViewImports.cshtml")]
    public class Views_Inmueble_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inmobiliaria_NetApi.Models.Inmueble>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
  
    ViewData["Title"] = "Editar";
    int id = Model.Id_inmu;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
 if(!User.Identity.IsAuthenticated)
 {
     await Html.RenderPartialAsync("_Login", new LoginView());
 }
 else
 {


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Editar el Inmueble del Sr/a: \r\n");
#nullable restore
#line 16 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
     foreach (var item in (IList<Propietario>)ViewBag.Propietario)
    {
        if(item.Id == Model.id_propietario){ 

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
                                                                                        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cbb69c97a83718becbdaf2a61eeef0a45b4339e8016", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8cbb69c97a83718becbdaf2a61eeef0a45b4339e8286", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_inmu);

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
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"direccion\" class=\"control-label\">Direccion</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"direccion\" name=\"Direccion_in\"");
                BeginWriteAttribute("value", " value=\"", 837, "\"", 864, 1);
#nullable restore
#line 28 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
WriteAttributeValue("", 845, Model.Direccion_in, 845, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"uso\" class=\"control-label\">Uso</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"uso\" name=\"uso\"");
                BeginWriteAttribute("value", " value=\"", 1069, "\"", 1087, 1);
#nullable restore
#line 32 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
WriteAttributeValue("", 1077, Model.Uso, 1077, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"tipo\" class=\"control-label\">Tipo</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"tipo\" name=\"tipo\"");
                BeginWriteAttribute("value", " value=\"", 1296, "\"", 1315, 1);
#nullable restore
#line 36 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
WriteAttributeValue("", 1304, Model.Tipo, 1304, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"ambientes\" class=\"control-label\">Ambientes</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"ambientes\" name=\"ambientes\"");
                BeginWriteAttribute("value", " value=\"", 1544, "\"", 1568, 1);
#nullable restore
#line 40 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
WriteAttributeValue("", 1552, Model.ambientes, 1552, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"precio\" class=\"control-label\">Precio</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"precio\" name=\"precio\"");
                BeginWriteAttribute("value", " value=\"", 1785, "\"", 1806, 1);
#nullable restore
#line 44 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
WriteAttributeValue("", 1793, Model.precio, 1793, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div>\r\n                <label class=\"control-label\">Propietario</label>\r\n                <select class=\"form-control\" name=\"idPro\">\r\n");
#nullable restore
#line 49 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
                     foreach (var item in (IList<Propietario>)ViewBag.Propietario)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                WriteLiteral("<option ");
#nullable restore
#line 51 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
                              Write(item.Id == Model.id_propietario ? "Selected" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 51 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">");
#nullable restore
#line 51 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
                                                                                                    Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 52 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cbb69c97a83718becbdaf2a61eeef0a45b4339e14872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 54 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id_propietario);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <br>\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cbb69c97a83718becbdaf2a61eeef0a45b4339e16636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 58 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FotoFile);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"file\" name=\"FotoFile\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cbb69c97a83718becbdaf2a61eeef0a45b4339e18301", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 60 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FotoFile);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <br>\r\n            <input type=\"submit\" value=\"Confirmar\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cbb69c97a83718becbdaf2a61eeef0a45b4339e21573", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 71 "D:\Documentos\TUDS 202X\Net\proyectos\Inmobiliaria_NetApi\Views\Inmueble\Editar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inmobiliaria_NetApi.Models.Inmueble> Html { get; private set; }
    }
}
#pragma warning restore 1591
