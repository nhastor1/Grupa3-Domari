#pragma checksum "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledNabavka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cfa17cda1cbe2808b28bebf4fa14da03e704b70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_PregledNabavka), @"mvc.1.0.view", @"/Views/Zahtjev/PregledNabavka.cshtml")]
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
#line 1 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfa17cda1cbe2808b28bebf4fa14da03e704b70", @"/Views/Zahtjev/PregledNabavka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_PregledNabavka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfa17cda1cbe2808b28bebf4fa14da03e704b703626", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>pregledNabavka</title>
    <link rel=""stylesheet"" href=""../../wwwroot/lib/bootstrap/dist/css/bootstrapPregledNabavka.min.css"">
    <link rel=""stylesheet"" href=""../../wwwroot/css/stylesPregledNabavka.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfa17cda1cbe2808b28bebf4fa14da03e704b704950", async() => {
                WriteLiteral(@"
    <h1 class=""text-center text-primary"" style=""font-style: normal;"">Pregled zahtjeva za nabavku namirnica</h1>
    <div>
        <div class=""container text-left"" style=""width: 1000px;margin: 70px;"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td style=""height: 80px;"">Lista namirnica za narudžbu</td>
                                </tr>
                                <tr>
                                    <td>
                                        <ul class=""list-group"">
");
#nullable restore
#line 27 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledNabavka.cshtml"
                                             foreach (StavkaNarudzbe sn in ViewBag.ZahtjevZaNabavkuNamirnica.StavkeNadruzbe)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <li class=\"list-group-item\"><span class=\"d-xl-flex justify-content-xl-start\">");
#nullable restore
#line 29 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledNabavka.cshtml"
                                                                                                                        Write(sn.Namirnica);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span><span class=\"d-xl-flex justify-content-xl-end\">");
#nullable restore
#line 29 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledNabavka.cshtml"
                                                                                                                                                                                           Write(sn.Kolicina);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledNabavka.cshtml"
                                                                                                                                                                                                        Write(sn.MjernaJedinica);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n");
#nullable restore
#line 30 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledNabavka.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </ul>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td style=""height: 80px;""></td>
                                </tr>
                                <tr>
                                    <td class=""text-center"" style=""height: 100px;""><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2285, "\"", 2417, 3);
                WriteAttributeValue("", 2295, "window.location.href=\'", 2295, 22, true);
#nullable restore
#line 47 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledNabavka.cshtml"
WriteAttributeValue("", 2317, Url.Action("OdobriNamirnice", "Zahtjev", new { id = ViewBag.ZahtjevZaNabavkuNamirnica.ZahtjevId }), 2317, 99, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2416, "\'", 2416, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Odobri nabavku</button></td>
                                </tr>
                                <tr style=""height: 150px;"">
                                    <td class=""text-center"">
                                        <div class=""btn-group"" role=""group""></div><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2789, "\"", 2920, 3);
                WriteAttributeValue("", 2799, "window.location.href=\'", 2799, 22, true);
#nullable restore
#line 51 "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledNabavka.cshtml"
WriteAttributeValue("", 2821, Url.Action("OdbijNamirnice", "Zahtjev", new { id = ViewBag.ZahtjevZaNabavkuNamirnica.ZahtjevId }), 2821, 98, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2919, "\'", 2919, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Odbij zahtjev</button>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/bootstrap/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
