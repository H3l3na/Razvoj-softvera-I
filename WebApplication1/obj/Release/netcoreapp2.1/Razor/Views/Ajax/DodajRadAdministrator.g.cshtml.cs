#pragma checksum "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4694e12b4d8a63d43031b7d0fd62c13106690170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_DodajRadAdministrator), @"mvc.1.0.view", @"/Views/Ajax/DodajRadAdministrator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ajax/DodajRadAdministrator.cshtml", typeof(AspNetCore.Views_Ajax_DodajRadAdministrator))]
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
#line 1 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4694e12b4d8a63d43031b7d0fd62c13106690170", @"/Views/Ajax/DodajRadAdministrator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_DodajRadAdministrator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.DodajDetaljeRadiVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Dodavanje/DodajDetaljiAdministrator.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Stalni", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Privremeni", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c01cfb4f16c942d491d033ef85b392a1", async() => {
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
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml"
  
    ViewData["Title"] = "DodajRadAdministrator";

    int admin_ID = (int)ViewData["_id_"];

#line default
#line hidden
            BeginContext(235, 51, true);
            WriteLiteral("\r\n<center>\r\n    <h2>Dodaj detalje rada</h2>\r\n\r\n    ");
            EndContext();
            BeginContext(286, 1867, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1599d560e9ff47239bf009e2d2e6f0d8", async() => {
                BeginContext(306, 32, true);
                WriteLiteral("\r\n        <input name=\"radnikID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 338, "\"", 355, 1);
#line 13 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml"
WriteAttributeValue("", 346, admin_ID, 346, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(356, 242, true);
                WriteLiteral(" hidden=\"hidden\" />\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <label>Akademija</label>\r\n                </td>\r\n                <td>\r\n                    <select name=\"akademijaID\">\r\n                        ");
                EndContext();
                BeginContext(598, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b60a7ff4f8f454eab65fd8c8205a3f2", async() => {
                    BeginContext(606, 15, true);
                    WriteLiteral("---Odaberite---");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(630, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(656, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3c57eaf60ed45b09471a8b5ccbf4039", async() => {
                    BeginContext(684, 19, true);
                    WriteLiteral("-------------------");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(712, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml"
                         foreach (var p in Model.akademije)
                        {

#line default
#line hidden
                BeginContext(802, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(830, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8586a85877478f9b34a7bdddf91d53", async() => {
                    BeginContext(862, 7, false);
#line 25 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml"
                                                      Write(p.Naziv);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 25 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml"
                               WriteLiteral(p.AkademijaID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(878, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml"
                        }

#line default
#line hidden
                BeginContext(907, 892, true);
                WriteLiteral(@"                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Broj sati u sedmici
                    </label>
                </td>
                <td>
                    <input type=""number"" name=""broj_sati"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Plata
                    </label>
                </td>
                <td>
                    <input name=""plata"" type=""number"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Vrsta ugovora
                    </label>
                </td>
                <td>
                    <select name=""ugovor"">
                        ");
                EndContext();
                BeginContext(1799, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1ed128c625744d394260c252102971c", async() => {
                    BeginContext(1807, 15, true);
                    WriteLiteral("---Odaberite---");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1831, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1857, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04f1ee3390304a9eb12101ba0e062072", async() => {
                    BeginContext(1885, 19, true);
                    WriteLiteral("-------------------");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1913, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1939, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9d711511ea34ff385a853f5873850b5", async() => {
                    BeginContext(1962, 6, true);
                    WriteLiteral("STALNI");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1977, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2003, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cbb2c2c328484ca1057b0c89c370f5", async() => {
                    BeginContext(2030, 10, true);
                    WriteLiteral("PRIVREMENI");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2049, 97, true);
                WriteLiteral("\r\n                    </select>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2153, 485, true);
            WriteLiteral(@"
    <br />
    <br />
    <a id=""snimi"" class=""btn btn-primary"">Snimi</a>
    <a id=""return_now"" class=""btn btn-default"">Nazad</a>
    <script>
        $(""#snimi"").click(function () {
            var forma = $(""#add_form"");
            $.ajax({
                type: ""POST"",
                url: ""/Ajax/SnimiRadAdministracija"",
                data: forma.serialize(),
                success: function (event) {
                    $.get(""/Ajax/DetaljiAdministracija?id=");
            EndContext();
            BeginContext(2639, 8, false);
#line 79 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml"
                                                     Write(admin_ID);

#line default
#line hidden
            EndContext();
            BeginContext(2647, 246, true);
            WriteLiteral("\", function (result) {\r\n                        $(\"#box2\").html(result);\r\n                    });\r\n                }\r\n            });\r\n        });\r\n\r\n        $(\"#return_now\").click(function () {\r\n            $.get(\"/Ajax/DetaljiAdministracija?id=");
            EndContext();
            BeginContext(2894, 8, false);
#line 87 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Ajax\DodajRadAdministrator.cshtml"
                                             Write(admin_ID);

#line default
#line hidden
            EndContext();
            BeginContext(2902, 119, true);
            WriteLiteral("\", function (result) {\r\n                $(\"#box2\").html(result);\r\n            });\r\n        })\r\n    </script>\r\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.DodajDetaljeRadiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
