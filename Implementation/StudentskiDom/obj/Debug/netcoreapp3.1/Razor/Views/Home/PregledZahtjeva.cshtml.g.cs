#pragma checksum "C:\Users\5440\Source\Repos\ooad-2019-2020\Grupa3-Domari\Implementation\StudentskiDom\Views\Home\PregledZahtjeva.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec5e4498a2ca041f56ed96a5868feb295505a4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PregledZahtjeva), @"mvc.1.0.view", @"/Views/Home/PregledZahtjeva.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec5e4498a2ca041f56ed96a5868feb295505a4a", @"/Views/Home/PregledZahtjeva.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e410ba33bd577e25e300ef3e44af039cd8b56ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PregledZahtjeva : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec5e4498a2ca041f56ed96a5868feb295505a4a3764", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec5e4498a2ca041f56ed96a5868feb295505a4a5035", async() => {
                WriteLiteral(@"
    <h1 class=""text-left"" style=""margin-top: 50px;margin-left: 200px;"">Pregled zahtjeva</h1>
    <ul class=""list-group text-left bg-secondary border rounded border-dark"" style=""width: 800px;margin-top: 50px;margin-left: 200px;background-color: rgb(108,117,125);"">
        <li class=""list-group-item"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col"">
                        <h4 class=""text-left"">Tip zahtjeva</h4>
                        <h5 class=""text-left"">Podnosilac zahtjeva</h5>
                    </div>
                    <div class=""col text-right align-self-center""><button class=""btn btn-primary"" type=""button"" style=""width: 200px;height: 50px;font-size: 20px;"">Otvori zahtjev</button></div>
                </div>
            </div>
        </li>
        <li class=""list-group-item"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col"">
                        <h4 class=""text-");
                WriteLiteral(@"left"">Tip zahtjeva</h4>
                        <h5 class=""text-left"">Podnosilac zahtjeva</h5>
                    </div>
                    <div class=""col text-right align-self-center""><button class=""btn btn-primary"" type=""button"" style=""width: 200px;height: 50px;font-size: 20px;"">Otvori zahtjev</button></div>
                </div>
            </div>
        </li>
        <li class=""list-group-item"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col"">
                        <h4 class=""text-left"">Tip zahtjeva</h4>
                        <h5 class=""text-left"">Podnosilac zahtjeva</h5>
                    </div>
                    <div class=""col text-right align-self-center""><button class=""btn btn-primary"" type=""button"" style=""width: 200px;height: 50px;font-size: 20px;"">Otvori zahtjev</button></div>
                </div>
            </div>
        </li>
        <li class=""list-group-item"">
            <div class=""container"">
    ");
                WriteLiteral(@"            <div class=""row"">
                    <div class=""col"">
                        <h4 class=""text-left"">Tip zahtjeva</h4>
                        <h5 class=""text-left"">Podnosilac zahtjeva</h5>
                    </div>
                    <div class=""col text-right align-self-center""><button class=""btn btn-primary"" type=""button"" style=""width: 200px;height: 50px;font-size: 20px;"">Otvori zahtjev</button></div>
                </div>
            </div>
        </li>
        <li class=""list-group-item"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col"">
                        <h4 class=""text-left"">Tip zahtjeva</h4>
                        <h5 class=""text-left"">Podnosilac zahtjeva</h5>
                    </div>
                    <div class=""col text-right align-self-center""><button class=""btn btn-primary"" type=""button"" style=""width: 200px;height: 50px;font-size: 20px;"">Otvori zahtjev</button></div>
                </div>
    ");
                WriteLiteral("        </div>\r\n        </li>\r\n    </ul>\r\n    <script src=\"assets/js/jquery.min.js\"></script>\r\n    <script src=\"assets/bootstrap/js/bootstrap.min.js\"></script>\r\n");
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
