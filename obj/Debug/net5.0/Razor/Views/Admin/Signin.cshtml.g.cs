#pragma checksum "E:\semester 7\EAD\Project\TRIPNESTOR\TripNestor\Views\Admin\Signin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "290c84aa652c8c48380599fb3edf69be3f294ff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Signin), @"mvc.1.0.view", @"/Views/Admin/Signin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"290c84aa652c8c48380599fb3edf69be3f294ff6", @"/Views/Admin/Signin.cshtml")]
    public class Views_Admin_Signin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin-signup.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290c84aa652c8c48380599fb3edf69be3f294ff63588", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://fonts.googleapis.com/css2?family=Arima:wght@600;700&family=Inconsolata&display=swap""
          rel=""stylesheet"">
    <!--    <link rel=""stylesheet"" href=""static/welcome.css"">-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "290c84aa652c8c48380599fb3edf69be3f294ff64235", async() => {
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
                WriteLiteral("\r\n\r\n\r\n    <!--    <link rel=\"stylesheet\" href=\"static/forgotPwd.css\">-->\r\n    <title>AdminSignIn</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290c84aa652c8c48380599fb3edf69be3f294ff66234", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 18 "E:\semester 7\EAD\Project\TRIPNESTOR\TripNestor\Views\Admin\Signin.cshtml"
     if (ViewBag.invalid == true)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            <strong>");
#nullable restore
#line 22 "E:\semester 7\EAD\Project\TRIPNESTOR\TripNestor\Views\Admin\Signin.cshtml"
               Write(ViewBag.invalidmsg);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n            <span onclick=\"this.parentElement.style.display=\'none\'\"style=\"font-size:1rem\" ;>&times;</span>\r\n\r\n        </div>\r\n");
#nullable restore
#line 26 "E:\semester 7\EAD\Project\TRIPNESTOR\TripNestor\Views\Admin\Signin.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""container"" id=""container"">
        <div class=""form-container"">
            <form method=""POST""action=""/admin/Login"">
                <h1>Sign in</h1>
                <input type=""email"" placeholder=""Email"" name=""email"" />
                <input type=""password"" placeholder=""Password"" name=""password"" />
");
                WriteLiteral(@"                <button id=""SIGNIN"" type=""submit"" name=""submit"">Sign In</button>
            </form>
        </div>

        <!-- <div class=""formInput""></div> -->
        <!-- <form>

            <h1>Continur your Sign In As:</h1>

            <input type=""checkbox"" id=""user"" name=""user"" value=""user"">
            <label style=""color: white;""for=""user""> USER</label><br>
            <input type=""checkbox"" id=""editor"" name=""editor"" value=""Car"">
            <label  style=""color: white;""for=""editor"">EDITOR</label><br>
            <button type=""submit"">Submit
            </button>              </form> -->
        <!-- </div> -->

        <div class=""overlay-container"">
            <div class=""overlay"">
                <div class=""overlay-panel overlay-right"">
                    <h1>TripNestor</h1>
                    <p class=""text-break text-wrap text-center"" style="" color: #FFFFFF;"">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                        F");
                WriteLiteral(@"usce a feugiat nulla, vel efficitur augue.
                        Mauris blandit mauris ut lorem interdum volutpat.
                        Fusce semper urna.
                    </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""MobileDisplay"" id=""MobileDisplay"">
        <div class=""container-fluid"">
            <form method=""POST"" style=""height: 26rem;""action=""/admin/Login"">
                <h1 style=""color:white"">TripNestor </h1>
                <div class=""form-group"">
                    <input type=""email"" class=""form-control"" placeholder=""Email"" name=""email"">
                </div>
                <div class=""form-group"">
                    <input type=""password"" class=""form-control"" placeholder=""Enter password"" name=""password"">
                </div>
                <a href=""/forgotPassword""> <u> Forgot your password?</u></a>

                <button type=""submit"" id=""SIGNIN"" class=""btn "">Sign In</button>
            </form>
        </div>");
                WriteLiteral("\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
