#pragma checksum "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\Vet_Propietario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae76ed21593f92885602ada9b8360693dbca76cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Vet_Propietario.Pages_Vet_Propietario_Details), @"mvc.1.0.razor-page", @"/Pages/Vet_Propietario/Details.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Vet_Propietario
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
#line 1 "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae76ed21593f92885602ada9b8360693dbca76cf", @"/Pages/Vet_Propietario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vet_Propietario_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\Vet_Propietario\Details.cshtml"
Write(Model.Propietario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    Id: ");
#nullable restore
#line 7 "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\Vet_Propietario\Details.cshtml"
   Write(Model.Propietario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Apellidos: ");
#nullable restore
#line 10 "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\Vet_Propietario\Details.cshtml"
          Write(Model.Propietario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Telefono: ");
#nullable restore
#line 13 "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\Vet_Propietario\Details.cshtml"
         Write(Model.Propietario.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Cedula: ");
#nullable restore
#line 16 "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\Vet_Propietario\Details.cshtml"
       Write(Model.Propietario.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Direccion: ");
#nullable restore
#line 19 "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\Vet_Propietario\Details.cshtml"
          Write(Model.Propietario.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Correo: ");
#nullable restore
#line 22 "C:\MascotaFeliz\Proyecto-MASCOTAFELIZ-CYBERLOWE-8\Veterinaria.App.Presentacion\Pages\Vet_Propietario\Details.cshtml"
       Write(Model.Propietario.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae76ed21593f92885602ada9b8360693dbca76cf5840", async() => {
                WriteLiteral("Lista de Propietarios");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.DetailsModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
