#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e2ffdf60811f8d441e9eabd32f763726ab213e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restoran_Restoran), @"mvc.1.0.view", @"/Views/Restoran/Restoran.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2ffdf60811f8d441e9eabd32f763726ab213e3", @"/Views/Restoran/Restoran.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e410ba33bd577e25e300ef3e44af039cd8b56ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Restoran_Restoran : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>
<html>

<head>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>restoranview</title>
    <link rel=""stylesheet"" href=""assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""assets/css/styles.css"">
</head>

<body style=""padding: 0px;"">
    <div style=""width: 300px;height: 50px;margin: 50px 0px 0px 100px;"">
        <h1 style=""font-family: cooper;font-size: 50px;"">RESTORAN</h1>
    </div>
    <div class=""border rounded border-primary d-xl-flex align-items-xl-start"" style=""width: 750px;height: 350px;margin: 30px 0px 0px 20px;"">
        <div class=""container"" style=""width: 400px;margin: 50px 0px 0px 10px;"">
            <div class=""row"">
                <div class=""col""><label class=""col-form-label"">Ime</label></div>
            </div>
            <div class=""row"">
                <div class=""col""><label class=""col-form-label text-center border rounded border-secondary"" style=""wi");
            WriteLiteral(@"dth: 300px;"">Label</label></div>
            </div>
            <div class=""row"">
                <div class=""col""><label class=""col-form-label"">Prezime</label></div>
            </div>
            <div class=""row"">
                <div class=""col""><label class=""col-form-label text-center border rounded border-secondary"" style=""width: 300px;"">Label</label></div>
            </div>
        </div>
        <div class=""container"" style=""width: 300px;margin: 30px 0px 0px 10px;"">
            <div class=""row"">
                <div class=""col"" style=""height: 140px;""><img style=""width: 240px;height: 140px;""></div>
            </div>
            <div class=""row"">
                <div class=""col"" style=""height: 80px;margin: 30px 0px 0px 0px;""><button class=""btn btn-primary"" type=""button"" style=""padding: 8px;margin: 10px;width: 220px;"">Skini ručak</button></div>
            </div>
            <div class=""row"">
                <div class=""col"" style=""height: 50px;""><button class=""btn btn-primary"" type=""bu");
            WriteLiteral(@"tton"" style=""height: 42px;width: 220px;margin: 10px;"">Skini večeru</button></div>
            </div>
        </div>
    </div>
    <div class=""container"" style=""width: 400px;margin: -130px 0px 0px 30px;"">
        <div class=""row"">
            <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 65px;"">Ručak</label></div>
            <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 60px;"">Večera</label></div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <h1 class=""text-center border rounded-circle"">25</h1>
            </div>
            <div class=""col"">
                <h1 class=""text-center border rounded-circle"">25</h1>
            </div>
        </div>
    </div>
    <div class=""row"" style=""width: 750px;margin: 50px 0px 0px 20px;"">
        <div class=""col"" style=""width: 300px;""><label class=""col-form-label text-center"" style=""font-size: 24px;margin: 11px 0px 0px 40px;"">Unesite ID studenta:</label></di");
            WriteLiteral(@"v>
        <div class=""col"" style=""width: 350px;""><input type=""text"" style=""margin: 15px 0px 0px 40px;font-size: 24px;width: 300px;""></div>
    </div>
    <div class=""container float-right"" style=""width:350px;margin:-400px -10px 0px 15px;"">
        <div class=""row"" style=""width: 350px;"">
            <div class=""col"" style=""margin: 0px;""><button class=""btn btn-primary"" type=""button"" style=""width: 300px;margin: 10px;"">Zahtjev za nabavku namirnica</button></div>
        </div>
        <div class=""row"" style=""width: 350px;"">
            <div class=""col""><button class=""btn btn-primary"" type=""button"" style=""width: 300px;margin: 10px;"">Ažuriranje menija</button></div>
        </div>
        <div class=""row"" style=""width: 350px;"">
            <div class=""col""><button class=""btn btn-primary"" type=""button"" style=""width: 300px;margin: 10px;"">Pregled menija</button></div>
        </div>
        <div class=""row"" style=""width: 350px;"">
            <div class=""col""></div>
        </div>
    </div>
    <scri");
            WriteLiteral("pt src=\"assets/js/jquery.min.js\"></script>\r\n    <script src=\"assets/bootstrap/js/bootstrap.min.js\"></script>\r\n</body>\r\n\r\n</html>");
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
