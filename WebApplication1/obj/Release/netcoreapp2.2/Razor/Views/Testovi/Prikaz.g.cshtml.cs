#pragma checksum "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af3b1c6284572bd91efc4f8c4cd8b8a818cc67f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testovi_Prikaz), @"mvc.1.0.view", @"/Views/Testovi/Prikaz.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Testovi/Prikaz.cshtml", typeof(AspNetCore.Views_Testovi_Prikaz))]
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
#line 4 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af3b1c6284572bd91efc4f8c4cd8b8a818cc67f", @"/Views/Testovi/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Testovi_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<podaciTestPrikazVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Prikaz/TestPrikaz.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Poruke_Span.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3af3b1c6284572bd91efc4f8c4cd8b8a818cc67f4394", async() => {
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3af3b1c6284572bd91efc4f8c4cd8b8a818cc67f5644", async() => {
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
            BeginContext(116, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
  
    ViewData["Title"] = "Prikaz";
    int b = 1;

    string porukaUspjeh = (string)TempData["uspjesno"];

#line default
#line hidden
            BeginContext(298, 20, true);
            WriteLiteral("<h1>Testovi</h1>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
 if (porukaUspjeh != null)
{

#line default
#line hidden
            BeginContext(349, 40, true);
            WriteLiteral("    <center>\r\n        <div id=\"poruka2\">");
            EndContext();
            BeginContext(390, 12, false);
#line 17 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
                     Write(porukaUspjeh);

#line default
#line hidden
            EndContext();
            BeginContext(402, 201, true);
            WriteLiteral("</div>\r\n    </center>\r\n    <script>\r\n        $(\"#poruka2\").slideUp(1);\r\n        $(\"#poruka2\").slideDown(1500);\r\n        $(\"#poruka2\").delay(2000);\r\n        $(\"#poruka2\").slideUp(1500);\r\n    </script>\r\n");
            EndContext();
#line 25 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
}

#line default
#line hidden
            BeginContext(606, 206, true);
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n    <th>RB</th>\r\n    <th>Kurs</th>\r\n    <th>Broj pitanja</th>\r\n    <th>Trajanje (minuta)</th>\r\n    <th>Maksimalno bodova</th>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
         foreach (var x in Model.row)
        {

#line default
#line hidden
            BeginContext(862, 41, true);
            WriteLiteral("            <tr>\r\n                <td><b>");
            EndContext();
            BeginContext(905, 3, false);
#line 39 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
                   Write(b++);

#line default
#line hidden
            EndContext();
            BeginContext(909, 31, true);
            WriteLiteral("</b></td>\r\n                <td>");
            EndContext();
            BeginContext(941, 6, false);
#line 40 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
               Write(x.kurs);

#line default
#line hidden
            EndContext();
            BeginContext(947, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(975, 14, false);
#line 41 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
               Write(x.broj_pitanja);

#line default
#line hidden
            EndContext();
            BeginContext(989, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1017, 10, false);
#line 42 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
               Write(x.trajanje);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1055, 12, false);
#line 43 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
               Write(x.max_bodova);

#line default
#line hidden
            EndContext();
            BeginContext(1067, 29, true);
            WriteLiteral("</td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1096, "\"", 1134, 2);
            WriteAttributeValue("", 1103, "/Testovi/UrediForm?id=", 1103, 22, true);
#line 44 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
WriteAttributeValue("", 1125, x.testId, 1125, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1135, 60, true);
            WriteLiteral(" class=\"btn btn-info\">Uredi</a></td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1195, "\"", 1229, 2);
            WriteAttributeValue("", 1202, "/Testovi/Brisi?id=", 1202, 18, true);
#line 45 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
WriteAttributeValue("", 1220, x.testId, 1220, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1230, 60, true);
            WriteLiteral(" class=\"btn btn-danger\">Ukloni</a></td>\r\n            </tr>\r\n");
            EndContext();
#line 47 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Testovi\Prikaz.cshtml"
        }

#line default
#line hidden
            BeginContext(1301, 116, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<center>\r\n    <a href=\"/Testovi/DodajForm\" class=\"btn btn-success\">Dodaj test</a>\r\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<podaciTestPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
