#pragma checksum "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12b8b98c1013f006edafb2a6dfd574d0267d27ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Shared.Empleados.Pages_Shared_Empleados_Detalle_Empleado), @"mvc.1.0.razor-page", @"/Pages/Shared/Empleados/Detalle_Empleado.cshtml")]
namespace Frontend.Pages.Shared.Empleados
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
#line 1 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b8b98c1013f006edafb2a6dfd574d0267d27ff", @"/Pages/Shared/Empleados/Detalle_Empleado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Empleados_Detalle_Empleado : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Consultas_Empleados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>DETALLE EMPLEADO</h1>\r\n\r\n<div>\r\n<div class=\"row\">\r\n   <dt class=\"col-md-2\">\r\n      ");
#nullable restore
#line 9 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayNameFor(model=>model.Empleado_get.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n   <dt class=\"col-md-10\">\r\n      ");
#nullable restore
#line 12 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayFor(model=> model.Empleado_get.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n   <dt class=\"col-md-2\">\r\n      ");
#nullable restore
#line 15 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayNameFor(model=>model.Empleado_get.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n   <dt class=\"col-md-10\">\r\n      ");
#nullable restore
#line 18 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayFor(model=> model.Empleado_get.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n   <dt class=\"col-md-2\">\r\n      ");
#nullable restore
#line 21 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayNameFor(model=>model.Empleado_get.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n   <dt class=\"col-md-10\">\r\n      ");
#nullable restore
#line 24 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayFor(model=> model.Empleado_get.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n      <dt class=\"col-md-2\">\r\n      ");
#nullable restore
#line 27 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayNameFor(model=>model.Empleado_get.Tipo_empleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n   <dt class=\"col-md-10\">\r\n      ");
#nullable restore
#line 30 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayFor(model=> model.Empleado_get.Tipo_empleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n      <dt class=\"col-md-2\">\r\n      ");
#nullable restore
#line 33 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayNameFor(model=>model.Empleado_get.Cantidad_subordinados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n   <dt class=\"col-md-10\">\r\n      ");
#nullable restore
#line 36 "C:\Users\milto\OneDrive\Documents\Grupo56\frontend\Pages\Shared\Empleados\Detalle_Empleado.cshtml"
 Write(Html.DisplayFor(model=> model.Empleado_get.Cantidad_subordinados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dt>\r\n\r\n</div>\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b8b98c1013f006edafb2a6dfd574d0267d27ff6729", async() => {
                WriteLiteral(" Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.Detalle_Empleado> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.Detalle_Empleado> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.Detalle_Empleado>)PageContext?.ViewData;
        public Frontend.Pages.Detalle_Empleado Model => ViewData.Model;
    }
}
#pragma warning restore 1591
