#pragma checksum "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9dada74d7efaf494d7e8eb1eea6d46696016cc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Empleados.Pages_Empleados_Delete), @"mvc.1.0.razor-page", @"/Pages/Empleados/Delete.cshtml")]
namespace FrontEnd.Pages.Empleados
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
#line 1 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9dada74d7efaf494d7e8eb1eea6d46696016cc3", @"/Pages/Empleados/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empleados_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>EMPLEADO A ELIMINAR</h1>\r\n<div>\r\n   <div class=\"row\">\r\n      <dt class=\"col-md-2\">\r\n         ");
#nullable restore
#line 9 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayNameFor(model=>model.EmpleadoEliminar.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-10\">\r\n         ");
#nullable restore
#line 12 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayFor(model=> model.EmpleadoEliminar.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-2\">\r\n         ");
#nullable restore
#line 15 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayNameFor(model=>model.EmpleadoEliminar.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-10\">\r\n         ");
#nullable restore
#line 18 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayFor(model=> model.EmpleadoEliminar.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-2\">\r\n         ");
#nullable restore
#line 21 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayNameFor(model=>model.EmpleadoEliminar.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-10\">\r\n         ");
#nullable restore
#line 24 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayFor(model=> model.EmpleadoEliminar.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-2\">\r\n         ");
#nullable restore
#line 27 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayNameFor(model=>model.EmpleadoEliminar.Tipo_empleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-10\">\r\n         ");
#nullable restore
#line 30 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayFor(model=> model.EmpleadoEliminar.Tipo_empleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-2\">\r\n         ");
#nullable restore
#line 33 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayNameFor(model=>model.EmpleadoEliminar.Cantidad_subordinados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n      <dt class=\"col-md-10\">\r\n         ");
#nullable restore
#line 36 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
    Write(Html.DisplayFor(model=> model.EmpleadoEliminar.Cantidad_subordinados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </dt>\r\n\r\n   </div>\r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9dada74d7efaf494d7e8eb1eea6d46696016cc37704", async() => {
                WriteLiteral("\r\n\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9dada74d7efaf494d7e8eb1eea6d46696016cc37966", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 45 "C:\Users\franz\Documents\mintic 2021\CICLO3\reto4\FrontEnd\Pages\Empleados\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmpleadoEliminar.ID);

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
                WriteLiteral("\r\n<input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\"> \r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9dada74d7efaf494d7e8eb1eea6d46696016cc39762", async() => {
                    WriteLiteral(" Regresar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeleteEmpleados> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeleteEmpleados> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeleteEmpleados>)PageContext?.ViewData;
        public DeleteEmpleados Model => ViewData.Model;
    }
}
#pragma warning restore 1591
