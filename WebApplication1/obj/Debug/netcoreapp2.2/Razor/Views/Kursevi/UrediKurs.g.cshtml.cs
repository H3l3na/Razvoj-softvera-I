#pragma checksum "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b0c636460eda296df501ae4fcf48a27d1ea2ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kursevi_UrediKurs), @"mvc.1.0.view", @"/Views/Kursevi/UrediKurs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kursevi/UrediKurs.cshtml", typeof(AspNetCore.Views_Kursevi_UrediKurs))]
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
#line 1 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b0c636460eda296df501ae4fcf48a27d1ea2ff", @"/Views/Kursevi/UrediKurs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kursevi_UrediKurs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.UrediKursVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Uređivanje/Pozadina.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Uređivanje/UrediKurs.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Kursevi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SnimiUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:Consolas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("forma"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09b0c636460eda296df501ae4fcf48a27d1ea2ff5877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09b0c636460eda296df501ae4fcf48a27d1ea2ff7127", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(127, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
  
    ViewData["Title"] = "UrediKurs";

#line default
#line hidden
            BeginContext(220, 97, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<center>\r\n    <h2 style=\"font-family:Consolas\">Uredite podatke o kursu ");
            EndContext();
            BeginContext(318, 11, false);
#line 12 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
                                                        Write(Model.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(329, 35, true);
            WriteLiteral("</h2>\r\n    <br />\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(364, 1735, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09b0c636460eda296df501ae4fcf48a27d1ea2ff9187", async() => {
                BeginContext(460, 44, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"KursID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 504, "\"", 525, 1);
#line 16 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 512, Model.KursID, 512, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(526, 117, true);
                WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label>Naziv:</label>\r\n            <input type=\"text\" name=\"Naziv\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 643, "\"", 663, 1);
#line 19 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 651, Model.Naziv, 651, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(664, 176, true);
                WriteLiteral(" class=\"form-control\"/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Studijski program:</label>\r\n            <input type=\"text\" name=\"StudijskiProgram\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 840, "\"", 871, 1);
#line 23 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 848, Model.StudijskiProgram, 848, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(872, 112, true);
                WriteLiteral(" readonly=\"readonly\" id=\"_sp\" class=\"form-control\"/>\r\n            <input type=\"hidden\" name=\"StudijskiProgramID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 984, "\"", 1017, 1);
#line 24 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 992, Model.StudijskiProgramID, 992, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1018, 131, true);
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>ECTS:</label>\r\n            <input type=\"text\" name=\"ECTS\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1149, "\"", 1168, 1);
#line 28 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 1157, Model.ECTS, 1157, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1169, 155, true);
                WriteLiteral(" class=\"form-control\"/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Cijena:</label>\r\n            <input type=\"text\" name=\"Cijena\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1324, "\"", 1345, 1);
#line 32 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 1332, Model.Cijena, 1332, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1346, 159, true);
                WriteLiteral(" class=\"form-control\"/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Trajanje:</label>\r\n            <input type=\"text\" name=\"Trajanje\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1505, "\"", 1528, 1);
#line 36 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 1513, Model.Trajanje, 1513, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1529, 161, true);
                WriteLiteral(" class=\"form-control\"/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Trazenost:</label>\r\n            <input type=\"text\" name=\"Trazenost\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1690, "\"", 1714, 1);
#line 40 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 1698, Model.Trazenost, 1698, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1715, 151, true);
                WriteLiteral(" class=\"form-control\"/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Cilj:</label>\r\n            <input type=\"text\" name=\"Cilj\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1866, "\"", 1885, 1);
#line 44 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediKurs.cshtml"
WriteAttributeValue("", 1874, Model.Cilj, 1874, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1886, 206, true);
                WriteLiteral(" class=\"form-control\"/>\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\" value=\"SnimiUpdate\">Snimi</button>\r\n        <a href=\"/Kursevi/Kursevi\" class=\"btn btn-default\" >Nazad</a>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2099, 13, true);
            WriteLiteral("\r\n</center>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.UrediKursVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
