#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f6e990f983dd0108360009b67ffd48f5964e2a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_PregledZahtjeva), @"mvc.1.0.view", @"/Views/Zahtjev/PregledZahtjeva.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f6e990f983dd0108360009b67ffd48f5964e2a6", @"/Views/Zahtjev/PregledZahtjeva.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_PregledZahtjeva : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html class=\"text-center\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6e990f983dd0108360009b67ffd48f5964e2a63928", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>ViewCreating</title>
    <link rel=""stylesheet"" href=""assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""assets/css/styles.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6e990f983dd0108360009b67ffd48f5964e2a65199", async() => {
                WriteLiteral(@"
    <h1 class=""text-left"" style=""margin-top: 50px;margin-left: 200px;"">Pregled zahtjeva</h1>
    <ul class=""list-group text-left bg-secondary border rounded border-dark"" style=""width: 800px;margin-top: 50px;margin-left: 200px;background-color: rgb(108,117,125);"">
");
#nullable restore
#line 19 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
         foreach (var zahtjev in ViewBag.Zahtjevi)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li class=\"list-group-item\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col\">\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                             if (zahtjev is ZahtjevZaUpis)
                            {
                                var z = zahtjev as ZahtjevZaUpis;


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h4 class=\"text-left\">Zahtjev za upis</h4>\r\n                                <h5 class=\"text-left\">");
#nullable restore
#line 32 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                                                 Write(z.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                                                                        Write(z.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 33 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                            }
                            else if (zahtjev is ZahtjevZaCimeraj)
                            {
                                var z = zahtjev as ZahtjevZaCimeraj;


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h4 class=\"text-left\">Zahtjev za cimeraj</h4>\r\n                                <h5 class=\"text-left\">");
#nullable restore
#line 39 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                                                 Write(z.Student.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                                                                                Write(z.Student.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 40 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                            }
                            else if (zahtjev is ZahtjevZaPremjestanje)
                            {
                                var z = zahtjev as ZahtjevZaPremjestanje;


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h4 class=\"text-left\">Zahtjev za premještanje</h4>\r\n                                <h5 class=\"text-left\">");
#nullable restore
#line 46 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                                                 Write(z.Student.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                                                                                Write(z.Student.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 47 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                            }
                            else if (zahtjev is ZahtjevZaNabavkuNamirnica)
                            {
                                var z = zahtjev as ZahtjevZaNabavkuNamirnica;


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h4 class=\"text-left\">Zahtjev za nabavku namirnica</h4>\r\n                                <h5 class=\"text-left\">Restoran</h5>\r\n");
#nullable restore
#line 54 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n\r\n");
#nullable restore
#line 58 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                         if (zahtjev is ZahtjevZaUpis)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col text-right align-self-center\"><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2761, "\"", 2870, 5);
                WriteAttributeValue("", 2771, "window.location.href=\'", 2771, 22, true);
#nullable restore
#line 60 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue("", 2793, Url.Action("PregledUpis","Zahtjev"), 2793, 36, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2829, "?id=\'", 2829, 5, true);
                WriteAttributeValue(" ", 2834, "+", 2835, 2, true);
#nullable restore
#line 60 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue(" ", 2836, (zahtjev as Zahtjev).ZahtjevId, 2837, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" type=\"button\" style=\"width: 200px;height: 50px;font-size: 20px;\">Otvori zahtjev</button></div>\r\n");
#nullable restore
#line 61 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                        }
                        else if (zahtjev is ZahtjevZaCimeraj)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col text-right align-self-center\"><button");
                BeginWriteAttribute("onclick", " onclick=\"", 3190, "\"", 3302, 5);
                WriteAttributeValue("", 3200, "window.location.href=\'", 3200, 22, true);
#nullable restore
#line 64 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue("", 3222, Url.Action("PregledCimeraj","Zahtjev"), 3222, 39, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3261, "?id=\'", 3261, 5, true);
                WriteAttributeValue(" ", 3266, "+", 3267, 2, true);
#nullable restore
#line 64 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue(" ", 3268, (zahtjev as Zahtjev).ZahtjevId, 3269, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" type=\"button\" style=\"width: 200px;height: 50px;font-size: 20px;\">Otvori zahtjev</button></div>\r\n");
#nullable restore
#line 65 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                        }
                        else if (zahtjev is ZahtjevZaPremjestanje)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col text-right align-self-center\"><button");
                BeginWriteAttribute("onclick", " onclick=\"", 3627, "\"", 3744, 5);
                WriteAttributeValue("", 3637, "window.location.href=\'", 3637, 22, true);
#nullable restore
#line 68 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue("", 3659, Url.Action("PregledPremjestanje","Zahtjev"), 3659, 44, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3703, "?id=\'", 3703, 5, true);
                WriteAttributeValue(" ", 3708, "+", 3709, 2, true);
#nullable restore
#line 68 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue(" ", 3710, (zahtjev as Zahtjev).ZahtjevId, 3711, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" type=\"button\" style=\"width: 200px;height: 50px;font-size: 20px;\">Otvori zahtjev</button></div>\r\n");
#nullable restore
#line 69 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                        }
                        else if (zahtjev is ZahtjevZaNabavkuNamirnica)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col text-right align-self-center\"><button");
                BeginWriteAttribute("onclick", " onclick=\"", 4073, "\"", 4185, 5);
                WriteAttributeValue("", 4083, "window.location.href=\'", 4083, 22, true);
#nullable restore
#line 72 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue("", 4105, Url.Action("PregledNabavka","Zahtjev"), 4105, 39, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4144, "?id=\'", 4144, 5, true);
                WriteAttributeValue(" ", 4149, "+", 4150, 2, true);
#nullable restore
#line 72 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue(" ", 4151, (zahtjev as Zahtjev).ZahtjevId, 4152, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" type=\"button\" style=\"width: 200px;height: 50px;font-size: 20px;\">Otvori zahtjev</button></div>\r\n");
#nullable restore
#line 73 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 78 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <li class=\"list-group-item\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <div class=\"col text-center align-self-center\"><button");
                BeginWriteAttribute("onclick", " onclick=\"", 4625, "\"", 4709, 3);
                WriteAttributeValue("", 4635, "window.location.href=\'", 4635, 22, true);
#nullable restore
#line 83 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledZahtjeva.cshtml"
WriteAttributeValue("", 4657, Url.Action("Uprava", "Uprava", new { ViewBag.id }), 4657, 51, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4708, "\'", 4708, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary border rounded"" type=""button"" style=""padding: 6px;margin: 15px;padding-left: 23;font-size: 20px; width: 200px;"">Gotovo</button></div>
                </div>
            </div>
        </div>
    </li>
    </ul>
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/bootstrap/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
