#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Student\ZahtjevZaPremjestanje.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10066f19f9b3bc6069dd416028035444f22608ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ZahtjevZaPremjestanje), @"mvc.1.0.view", @"/Views/Student/ZahtjevZaPremjestanje.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10066f19f9b3bc6069dd416028035444f22608ad", @"/Views/Student/ZahtjevZaPremjestanje.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e410ba33bd577e25e300ef3e44af039cd8b56ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ZahtjevZaPremjestanje : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>
<html>

<head>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>zahtjevZaPremjestanje</title>
    <link rel=""stylesheet"" href=""../../wwwroot/lib/bootstrap/dist/css/bootstrapZahtjevZaPremjestanje.min.css"">
    <link rel=""stylesheet"" href=""../../wwwroot/css/stylesZahtjevZaPremjestanje.css"">
</head>

<body>
    <h1 class=""text-center text-primary"" style=""font-style: normal;"">Zahtjev za premještanje</h1>
    <div>
        <div class=""container text-left"" style=""width: 1000px;margin: 70px;"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr style=""height: 80px;"">
                                    <td>Trenutni paviljon</td>
                                    <td><select style=""width: 250px;height: 30px;""><optg");
            WriteLiteral("roup label=\"This is a group\"><option value=\"12\"");
            BeginWriteAttribute("selected", " selected=\"", 1071, "\"", 1082, 0);
            EndWriteAttribute();
            WriteLiteral(@">This is item 1</option><option value=""13"">This is item 2</option><option value=""14"">This is item 3</option></optgroup></select></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>Trenutna soba</td>
                                    <td><select style=""width: 250px;height: 30px;""><optgroup label=""This is a group""><option value=""12""");
            BeginWriteAttribute("selected", " selected=\"", 1512, "\"", 1523, 0);
            EndWriteAttribute();
            WriteLiteral(@">This is item 1</option><option value=""13"">This is item 2</option><option value=""14"">This is item 3</option></optgroup></select></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td>Novi paviljon<br><br></td>
                                    <td><select style=""width: 250px;height: 30px;""><optgroup label=""This is a group""><option value=""12""");
            BeginWriteAttribute("selected", " selected=\"", 1961, "\"", 1972, 0);
            EndWriteAttribute();
            WriteLiteral(@">This is item 1</option><option value=""13"">This is item 2</option><option value=""14"">This is item 3</option></optgroup></select></td>
                                </tr>
                                <tr style=""height: 80px;"">
                                    <td><label>Nova soba<br></label><br><br><br></td>
                                    <td><select style=""width: 250px;height: 30px;""><optgroup label=""This is a group""><option value=""12""");
            BeginWriteAttribute("selected", " selected=\"", 2429, "\"", 2440, 0);
            EndWriteAttribute();
            WriteLiteral(@">This is item 1</option><option value=""13"">This is item 2</option><option value=""14"">This is item 3</option></optgroup></select></td>
                                </tr>
                                <tr style=""height: 150px;"">
                                    <td></td>
                                    <td><button class=""btn btn-primary"" type=""button"" style=""margin: 50px;"">Pošalji zahtjev</button></td>
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
                                    <td style=""height: 80px;"">Razlog premještanja</td>
                                </tr>
                                <tr>
                                    <td><textarea class=""form");
            WriteLiteral(@"-control-lg"" style=""width: 400px;height: 234px;""></textarea></td>
                                </tr>
                                <tr style=""height: 150px;"">
                                    <td>
                                        <div class=""btn-group"" role=""group""><button class=""btn btn-secondary"" type=""button"" style=""margin: 50px;"">Odbaci zahtjev</button></div>
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
</body>

</html>");
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
