#pragma checksum "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\PregledDnevniMeni.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5e485d2e077c11ad04b86dbaaea0b60d9a92293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restoran_PregledDnevniMeni), @"mvc.1.0.view", @"/Views/Restoran/PregledDnevniMeni.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5e485d2e077c11ad04b86dbaaea0b60d9a92293", @"/Views/Restoran/PregledDnevniMeni.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Restoran_PregledDnevniMeni : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5e485d2e077c11ad04b86dbaaea0b60d9a922933566", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>dnevnimeni</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5e485d2e077c11ad04b86dbaaea0b60d9a922934835", async() => {
                WriteLiteral(@"
    <div style=""width: 430px;height: 60px;margin: 15px 0px 0px 420px;"">
        <h1 class=""text-left"" style=""font-size: 50px;font-family: cooper;"">DNEVNI MENI</h1>
    </div>
    <div class=""d-flex"" style=""margin: 80px 0px 0px 0px;height: 316px;"">
        <div class=""container border rounded-0 border-primary"" style=""width: 550px;margin: 20px 0px 0px 20px;"">
            <div class=""row"">
                <div class=""col"" style=""background-color: #98a1c3;""><label class=""col-form-label"" style=""font-size: 30px;"">Ručak</label></div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <ul class=""list-unstyled"" style=""font-size: 20px;"">
");
#nullable restore
#line 24 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\PregledDnevniMeni.cshtml"
                         foreach (Rucak r in ViewBag.rucak)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>");
#nullable restore
#line 26 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\PregledDnevniMeni.cshtml"
                           Write(r.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 27 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\PregledDnevniMeni.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
        <div class=""container border rounded-0 border-primary"" style=""width: 550px;margin: 20px 0px 0px 80px;"">
            <div class=""row"">
                <div class=""col"" style=""background-color: #98a1c3;""><label class=""col-form-label"" style=""font-size: 30px;"">Večera</label></div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <ul class=""list-unstyled"" style=""font-size: 20px;"">
");
#nullable restore
#line 39 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\PregledDnevniMeni.cshtml"
                         foreach (Vecera v in ViewBag.vecera)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>");
#nullable restore
#line 41 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\PregledDnevniMeni.cshtml"
                           Write(v.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 42 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\PregledDnevniMeni.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div style=""height: 200px;margin: 40px 0px 0px 0px;"">
        <div class=""row"" style=""width: 1000px;margin: 20px;"">
            <div class=""col""><button class=""btn btn-primary""");
                BeginWriteAttribute("onclick", " onclick=\"", 2181, "\"", 2249, 3);
                WriteAttributeValue("", 2191, "window.location.href=\'", 2191, 22, true);
#nullable restore
#line 50 "C:\Users\Nedo\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\PregledDnevniMeni.cshtml"
WriteAttributeValue("", 2213, Url.Action("Restoran", "Restoran"), 2213, 35, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2248, "\'", 2248, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" style=\"margin: 0px 0px 0px 430px;width: 200px;\">Gotovo</button></div>\r\n        </div>\r\n    </div>\r\n    <script src=\"assets/js/jquery.min.js\"></script>\r\n    <script src=\"assets/bootstrap/js/bootstrap.min.js\"></script>\r\n");
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
