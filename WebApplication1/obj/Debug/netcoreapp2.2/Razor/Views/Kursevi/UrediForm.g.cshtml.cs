#pragma checksum "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d0abb2364e1bfd6684890a8bcd3288dc8ae3c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kursevi_UrediForm), @"mvc.1.0.view", @"/Views/Kursevi/UrediForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kursevi/UrediForm.cshtml", typeof(AspNetCore.Views_Kursevi_UrediForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d0abb2364e1bfd6684890a8bcd3288dc8ae3c2", @"/Views/Kursevi/UrediForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kursevi_UrediForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Uređivanje/UrediKursevi.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Kursevi/Uredi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7d0abb2364e1bfd6684890a8bcd3288dc8ae3c24523", async() => {
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
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
  
    Kurs podaci = (Kurs)ViewData["uredi"];
    string nazivSP = (string)ViewData["naziv"];

#line default
#line hidden
            BeginContext(168, 38, true);
            WriteLiteral("\r\n\r\n<h1>Uredi podatke kursa</h1>\r\n\r\n\r\n");
            EndContext();
            BeginContext(206, 2297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d0abb2364e1bfd6684890a8bcd3288dc8ae3c26154", async() => {
                BeginContext(236, 82, true);
                WriteLiteral("\r\n    <center>\r\n        <input type=\"text\" hidden=\"hidden\" name=\"studijskiProgram\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 318, "\"", 357, 1);
#line 13 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 326, podaci.Studijski_Program_ID_FK, 326, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(358, 57, true);
                WriteLiteral(" />\r\n        <input type=\"text\" hidden=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 415, "\"", 437, 1);
#line 14 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 423, podaci.KursID, 423, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(438, 231, true);
                WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>Naziv</label>\r\n                </td>\r\n                <td>\r\n                    <input id=\"kurs_\" type=\"text\" readonly=\"readonly\" name=\"naziv\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 669, "\"", 690, 1);
#line 21 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 677, podaci.Naziv, 677, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(691, 253, true);
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Studijski program</label>\r\n                </td>\r\n                <td>\r\n                    <input id=\"sp_\" type=\"text\" readonly=\"readonly\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 944, "\"", 960, 1);
#line 29 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 952, nazivSP, 952, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(961, 229, true);
                WriteLiteral("/>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>ECTS bodova</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"ects\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1190, "\"", 1210, 1);
#line 37 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 1198, podaci.ECTS, 1198, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1211, 227, true);
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Cijena</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"cijena\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1438, "\"", 1460, 1);
#line 45 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 1446, podaci.Cijena, 1446, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1461, 231, true);
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Trajanje</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"trajanje\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1692, "\"", 1716, 1);
#line 53 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 1700, podaci.Trajanje, 1700, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1717, 233, true);
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Traženost</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"trazenost\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1950, "\"", 1975, 1);
#line 61 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 1958, podaci.Trazenost, 1958, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1976, 223, true);
                WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <label>Cilj</label>\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"cilj\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2199, "\"", 2219, 1);
#line 69 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\UrediForm.cshtml"
WriteAttributeValue("", 2207, podaci.Cilj, 2207, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2220, 276, true);
                WriteLiteral(@" />
                </td>
            </tr>
        </table>
        <br/>
        <br/>
        <button id=""go"" class=""btn btn-primary"" type=""submit"">Snimi</button>
        <a id=""back"" class=""btn btn-default"" href=""/Kursevi/PrikaziKurseve/"">Nazad</a>
    </center>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
