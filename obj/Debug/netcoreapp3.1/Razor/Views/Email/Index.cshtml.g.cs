#pragma checksum "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b250168d008b62b6df312281ed605f4b7391042f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Email_Index), @"mvc.1.0.view", @"/Views/Email/Index.cshtml")]
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
#line 1 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/_ViewImports.cshtml"
using Myapp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/_ViewImports.cshtml"
using Myapp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b250168d008b62b6df312281ed605f4b7391042f", @"/Views/Email/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55774ea745b1d0cb39370904776b851ccc4ea743", @"/Views/_ViewImports.cshtml")]
    public class Views_Email_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Myapp.Web.Models.EmailModel>
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
            WriteLiteral("\n\n    <!DOCTYPE html>\n\n    <html>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b250168d008b62b6df312281ed605f4b7391042f3264", async() => {
                WriteLiteral(@"
        <meta name=""viewport"" content=""width=device-width"" />
        <title>Index</title>
        <style type=""text/css"">
            body {
                font-family: Arial;
                font-size: 10pt;
            }

            table th, table td {
                padding: 5px;
            }
        </style>
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
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b250168d008b62b6df312281ed605f4b7391042f4546", async() => {
                WriteLiteral("\n        <div>\n");
#nullable restore
#line 23 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
             using (Html.BeginForm("Index", "Email", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <table border=""0"" cellpadding=""0"" cellspacing=""0"">
                    <tr>
                        <td style=""width: 80px"">
                            To:
                        </td>
                        <td>
                            ");
#nullable restore
#line 31 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
                       Write(Html.TextBoxFor(model => model.To));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <td>\n                            Subject:\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 39 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
                       Write(Html.TextBoxFor(model => model.Subject));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <td valign=\"top\">\n                            Body:\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 47 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
                       Write(Html.TextAreaFor(model => model.Body, new { rows = "3", cols = "20" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <td>\n                            File Attachment:\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 55 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
                       Write(Html.TextBoxFor(model => model.Attachment, new { type = "file" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <td>\n                            Gmail Email:\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 63 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
                       Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <td>\n                            Gmail Password:\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 71 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
                       Write(Html.TextBoxFor(model => model.Password, new { type = "password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <input type=""submit"" class=""btn btn-primary"" value=""Send"" />
                        </td>
                    </tr>
                </table>
                <br />
                <span style=""color:green"">");
#nullable restore
#line 82 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
                                     Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n");
#nullable restore
#line 83 "/Users/muhammadnuridin/Sites/playground/dotnetcore/Myapp.Web/Myapp.Web/Views/Email/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    ");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Myapp.Web.Models.EmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591