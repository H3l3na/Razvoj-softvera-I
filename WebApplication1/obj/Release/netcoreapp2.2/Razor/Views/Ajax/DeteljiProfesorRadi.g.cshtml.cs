#pragma checksum "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c5b69fef1e27951c1fc21dafb5604eddf717c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_DeteljiProfesorRadi), @"mvc.1.0.view", @"/Views/Ajax/DeteljiProfesorRadi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ajax/DeteljiProfesorRadi.cshtml", typeof(AspNetCore.Views_Ajax_DeteljiProfesorRadi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5b69fef1e27951c1fc21dafb5604eddf717c78", @"/Views/Ajax/DeteljiProfesorRadi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_DeteljiProfesorRadi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.adminROW>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
  
    ViewData["Title"] = "DeteljiProfesorRadi";
    string ime = (string)ViewData["prof_radi"];
    int ID = (int)ViewData["prof_id"];

#line default
#line hidden
            BeginContext(188, 89, true);
            WriteLiteral("<h1 align=\"center\" style=\"background-color:rgba(0,0,0,0.1)\">Detalji o profesor(u/ici) <b>");
            EndContext();
            BeginContext(278, 3, false);
#line 7 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
                                                                                    Write(ime);

#line default
#line hidden
            EndContext();
            BeginContext(281, 534, true);
            WriteLiteral(@"</b></h1>
<hr style=""width:99.8%; border:2px solid black;"" />
<h1 align=""center""; style=""margin-top:3%; margin-bottom:5%; background-color:rgba(0,0,0,0.1)"">Detalji o radu</h1>

<table class=""table table-striped"">
    <thead>
        <td>
            <b>Akademije u koje radi</b>
        </td>
        <td>
            <b>Broj radnih sati u sedmici</b>
        </td>
        <td>
            <b>Iznos plate (KM)</b>
        </td>
        <td>
            <b>Vrsta ugovora</b>
        </td>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
         foreach(var x in Model.row)
        {

#line default
#line hidden
            BeginContext(864, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(903, 11, false);
#line 30 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
               Write(x.Akademija);

#line default
#line hidden
            EndContext();
            BeginContext(914, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(942, 21, false);
#line 31 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
               Write(x.broj_sati_u_sedmici);

#line default
#line hidden
            EndContext();
            BeginContext(963, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(991, 7, false);
#line 32 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
               Write(x.plata);

#line default
#line hidden
            EndContext();
            BeginContext(998, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1026, 15, false);
#line 33 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
               Write(x.vrsta_ugovora);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 52, true);
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1093, "\"", 1121, 2);
            WriteAttributeValue("", 1098, "remove_detail_", 1098, 14, true);
#line 34 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
WriteAttributeValue("", 1112, x.rad_id, 1112, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1122, 85, true);
            WriteLiteral(">Ukloni</a>\r\n                    <script>\r\n                        $(\"#remove_detail_");
            EndContext();
            BeginContext(1208, 8, false);
#line 36 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
                                     Write(x.rad_id);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 91, true);
            WriteLiteral("\").click(function (event) {\r\n                            $.get(\"/Ajax/UkloniDetaljeRadi?id=");
            EndContext();
            BeginContext(1308, 8, false);
#line 37 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
                                                         Write(x.rad_id);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 9, true);
            WriteLiteral("&prof_id=");
            EndContext();
            BeginContext(1326, 13, false);
#line 37 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
                                                                           Write(x.profesor_id);

#line default
#line hidden
            EndContext();
            BeginContext(1339, 221, true);
            WriteLiteral("\", function (result) {\r\n                                $(\"#box_radi\").html(result);\r\n                            });\r\n                        });\r\n                    </script>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 44 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
        }

#line default
#line hidden
            BeginContext(1571, 64, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<center>\r\n    <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1635, "\"", 1658, 2);
            WriteAttributeValue("", 1640, "addDetaildWork_", 1640, 15, true);
#line 48 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
WriteAttributeValue("", 1655, ID, 1655, 3, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1659, 56, true);
            WriteLiteral(">Dodaj</a>\r\n</center>\r\n<script>\r\n    $(\"#addDetaildWork_");
            EndContext();
            BeginContext(1716, 2, false);
#line 51 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
                  Write(ID);

#line default
#line hidden
            EndContext();
            BeginContext(1718, 70, true);
            WriteLiteral("\").click(function (event) {\r\n        $.get(\"/Ajax/DodajDetaljeRadi?id=");
            EndContext();
            BeginContext(1789, 2, false);
#line 52 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DeteljiProfesorRadi.cshtml"
                                    Write(ID);

#line default
#line hidden
            EndContext();
            BeginContext(1791, 97, true);
            WriteLiteral("\", function (result) {\r\n            $(\"#box_radi\").html(result);\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.adminROW> Html { get; private set; }
    }
}
#pragma warning restore 1591
