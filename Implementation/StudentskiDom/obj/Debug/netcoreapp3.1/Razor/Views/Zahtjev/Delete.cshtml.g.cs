#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c9ffe93616ba4a9c7f1c3f4daeddb3cab5b5af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_Delete), @"mvc.1.0.view", @"/Views/Zahtjev/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9ffe93616ba4a9c7f1c3f4daeddb3cab5b5af5", @"/Views/Zahtjev/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e410ba33bd577e25e300ef3e44af039cd8b56ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentskiDom.Models.Zahtjev>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\Delete.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>

<html>
<head>
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Delete</title>
</head>
<body>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Zahtjev</h4>
    <hr />
    <dl class=""row"">
        <dt class = ""col-sm-2"">
            ");
#nullable restore
#line 22 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Datum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Datum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Odobren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Odobren));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""ZahtjevId"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
</body>
</html>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentskiDom.Models.Zahtjev> Html { get; private set; }
    }
}
#pragma warning restore 1591
