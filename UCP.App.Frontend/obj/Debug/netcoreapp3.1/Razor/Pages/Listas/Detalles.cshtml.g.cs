#pragma checksum "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4a00ef9dace6962d01bd02c7b0872dfa8e0349b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UCP.App.Frontend.Pages.Listas.Pages_Listas_Detalles), @"mvc.1.0.razor-page", @"/Pages/Listas/Detalles.cshtml")]
namespace UCP.App.Frontend.Pages.Listas
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
#line 1 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\_ViewImports.cshtml"
using UCP.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a00ef9dace6962d01bd02c7b0872dfa8e0349b", @"/Pages/Listas/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3d4c9d00bb47d29c7c3d5319e146ba2d6a0c360", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_Detalles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Listas/Personas/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Detalle Profesor</h1>\r\n<table class=\"table\">\r\n<tr><td>");
#nullable restore
#line 7 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml"
   Write(Model.Profesor.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td>\r\n<tr><td>");
#nullable restore
#line 8 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml"
   Write(Model.Profesor.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td>\r\n<tr><td>");
#nullable restore
#line 9 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml"
   Write(Model.Profesor.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td>\r\n<tr><td>");
#nullable restore
#line 10 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml"
   Write(Model.Profesor.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td>\r\n<tr><td>");
#nullable restore
#line 11 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml"
   Write(Model.Profesor.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td>\r\n<tr><td>");
#nullable restore
#line 12 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml"
   Write(Model.Profesor.vehiculo_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td>\r\n<tr><td>");
#nullable restore
#line 13 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml"
   Write(Model.Profesor.facultad);

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td>\r\n<tr><td>");
#nullable restore
#line 14 "C:\UCParking23\UCP.App\UCP.App.Frontend\Pages\Listas\Detalles.cshtml"
   Write(Model.Profesor.cubiculo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td>\r\n<tr><td>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a00ef9dace6962d01bd02c7b0872dfa8e0349b5556", async() => {
                WriteLiteral("\r\nLista Personas ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<tr><td>\r\n<table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UCP.App.Frontend.Pages.DetallesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCP.App.Frontend.Pages.DetallesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCP.App.Frontend.Pages.DetallesModel>)PageContext?.ViewData;
        public UCP.App.Frontend.Pages.DetallesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
