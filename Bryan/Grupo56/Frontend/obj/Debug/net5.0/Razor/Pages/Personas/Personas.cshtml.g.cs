#pragma checksum "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\Personas\Personas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5867f1c7f78ddab363acba12d5afd4234636b68f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Personas.Pages_Personas_Personas), @"mvc.1.0.razor-page", @"/Pages/Personas/Personas.cshtml")]
namespace Frontend.Pages.Personas
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
#line 1 "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5867f1c7f78ddab363acba12d5afd4234636b68f", @"/Pages/Personas/Personas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_Personas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\Personas\Personas.cshtml"
  
    ViewData["Title"] = "Bryan";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\Personas\Personas.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>En esta pagina veremos los datos</p>\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 11 "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\Personas\Personas.cshtml"
     foreach (var Cliente in Model.Clientecitos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\Personas\Personas.cshtml"
           Write(Cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\Personas\Personas.cshtml"
           Write(Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\Personas\Personas.cshtml"
           Write(Cliente.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\milto\OneDrive\Documents\Github Proyecto Mintic\mintic\Bryan\Grupo56\frontend\Pages\Personas\Personas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.PrivacyModel>)PageContext?.ViewData;
        public Frontend.Pages.PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591