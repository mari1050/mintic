#pragma checksum "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb593f68e8790265869c74178eba3d59066892c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Pages_Persona), @"mvc.1.0.razor-page", @"/Pages/Persona.cshtml")]
namespace FrontEnd.Pages
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
#line 1 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb593f68e8790265869c74178eba3d59066892c", @"/Pages/Persona.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Persona : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml"
  
    ViewData["Title"] = "Persona";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Listado de Personas Registradas en localhost.</p>\r\n<table class=\"table\">\r\n");
#nullable restore
#line 10 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml"
     foreach (var Persona in Model.Personas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml"
           Write(Persona.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml"
           Write(Persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml"
           Write(Persona.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml"
           Write(Persona.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\franz\Documents\mintic 2021\CICLO3\grupo56\FrontEnd\Pages\Persona.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PersonaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PersonaModel>)PageContext?.ViewData;
        public PersonaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591