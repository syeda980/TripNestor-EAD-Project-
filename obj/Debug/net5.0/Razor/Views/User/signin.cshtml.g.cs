#pragma checksum "E:\semester 7\EAD\Project\TRIPNESTOR\TripNestor\Views\User\signin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512226db2c0971ae85260da58698ae15ac8757e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_signin), @"mvc.1.0.view", @"/Views/User/signin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512226db2c0971ae85260da58698ae15ac8757e8", @"/Views/User/signin.cshtml")]
    public class Views_User_signin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/loginsignup.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/signin-up.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!--<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@400;500;600;800&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""~/css/style.css"" />

    <title>Travel</title>
</head>
<body id=""main-page"" class=""main-page"">
    <a class=""logo"" href=""/home/index""><h1>Travel</h1></a>
    <div class=""signup-page"">
        <div class=""signup-form"">
            <h1>Travel</h1>
            <form name=""form"" onsubmit=""return validateForm()"">
                <div class=""input-field"">
                    <label>Email</label>
                    <input type=""email"" name=""mail"" />
                </div>
                <div class=""i");
            WriteLiteral(@"nput-field"">
                    <label>Password</label>
                    <input type=""password"" name=""password"" />
                </div>
                <p id=""alert""></p>
                <button class=""sub-btn"" id=""btn"" type=""submit"">Sign In</button>
            </form>
            <span>
                <a class=""link-signin"" href=""/user/SignUp"">Create an account</a>
            </span>
        </div>
    </div>

    <script>
      function validateForm() {
        event.preventDefault();

        let email = document.forms[""form""][""mail""].value;
        let password = document.forms[""form""][""password""].value;
        console.log(""here"");
        if (email && password) {
          const attr = document.createAttribute(""disabled"");
          attr.value = ""true"";
          document.getElementById(""btn"").setAttributeNode(attr);
          document.getElementById(""alert"").innerText = """";
          return true;
        } else {
          document.getElementById(""alert"").innerText =");
            WriteLiteral("\r\n            \"Invalid user name or password\";\r\n          return false;\r\n        }\r\n      }\r\n    </script>\r\n</body>\r\n</html>-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "512226db2c0971ae85260da58698ae15ac8757e86289", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://fonts.googleapis.com/css2?family=Arima:wght@600;700&family=Inconsolata&display=swap""
          rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "512226db2c0971ae85260da58698ae15ac8757e86866", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "512226db2c0971ae85260da58698ae15ac8757e88045", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>LOGIN/SIGNUP</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "512226db2c0971ae85260da58698ae15ac8757e89963", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <div class=""container"" id=""container"" style=""margin-top: 2rem"">
        <div class=""form-container sign-up-container"">
            <form  method=""post"">
                <h1>Create Account</h1>
                <input type=""text"" placeholder=""Name"" name=""userName"" />
                <input type=""email"" placeholder=""Email"" name=""userEmail"" />
                <input required type=""password"" placeholder=""Password"" name=""userPassword"" />
                <button id=""SIGNUP"" type=""submit"" name=""submit"">Sign Up</button>
            </form>
        </div>
        <div class=""form-container sign-in-container"">
            <!--                            <button id=""backBtn"" type=""submit""onclick=""history.back()"">&larr;</button>-->
            <form  method=""POST"">

                <h1>Sign in</h1>
                <input type=""email"" placeholder=""Email"" name=""email"" />
                <input type=""password"" required placeholder=""Password"" name=""password"" />
                <a href=""/forgotPassword""> <");
                WriteLiteral(@"u> Forgot your password?</u></a>
                <button id=""SIGNIN"" type=""submit"" name=""submit"">Sign In</button>
            </form>
        </div>
        <div class=""overlay-container"">
            <div class=""overlay"">
                <div class=""overlay-panel overlay-left"">
                    <h1>Welcome Back!</h1>
                    <p>To keep connected with us please login with your personal info</p>
                    <button class=""ghost"" id=""signIn"">Sign In</button>
                </div>
                <div class=""overlay-panel overlay-right"">
                    <h1 >TripNestor</h1>
                    <p>
                        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ullam
                    </p>
                    <p>Enter your personal details and start journey with us</p>
                    <button class=""ghost"" id=""signUp"">Sign Up</button>
                </div>
            </div>
        </div>
    </div>
    <div class=""MobileDisplay"" id=""Mobi");
                WriteLiteral(@"leDisplay"">
        <div class=""container-fluid"">
            <form  method=""POST"" style=""height: 26rem;"">
                <h1 style=""color:white"">TripNestor </h1>     
                <div class=""form-group"">
                    <input type=""email"" class=""form-control"" placeholder=""Email"" name=""email"">
                </div>
                <div class=""form-group"">
                    <input type=""password"" class=""form-control"" placeholder=""Enter password"" name=""password"">
                </div>
                <a href=""/forgotPassword""> <u style=""color:black""> Forgot your password?</u></a>

                <button type=""submit"" id=""SIGNIN"" class=""btn "">Sign In</button>
                <!--        <div class=""dropdown-divider""></div>-->
                <a style=""color:black"" class=""dropdown-item"" id=""MobileSignUp"" onclick=""displayfunc()"">New Member? <u>Sign up</u></a>

            </form>
        </div>
    </div>

");
                WriteLiteral(@"    <div class=""MobileDisplaySignUp"" id=""smallscreen"">
        <div class=""container-fluid "">
            <form method=""POST"" style=""height: 26rem;"">
                <h1 style=""color:white"">TripNestor</h1>
                <div class=""form-group"">
                    <input type=""text"" class=""form-control"" id=""name"" placeholder=""Enter your Name"" name=""userName"">
                </div>
                <div class=""form-group"">
                    <input type=""email"" class=""form-control"" id=""email"" placeholder=""Enter your Email"" name=""userEmail"">
                </div>
                <div class=""form-group"">
                    <input type=""password"" class=""form-control"" id=""pwd"" placeholder=""Enter your password"" name=""userPassword"">
                </div>
                <button type=""submit"" class=""btn "">Sign Up</button>
                <!--        <div class=""dropdown-divider""></div>-->

            </form>
");
                WriteLiteral(@"        </div>
    </div>

    <script type=""text/javascript"">
        const signUpButton = document.getElementById('signUp');
        const signInButton = document.getElementById('signIn');
        const container = document.getElementById('container');

        const mobileSignUpClick = document.getElementById('MobileSignUp');
        const mobileSignUp = document.getElementById('MobileDisplay');
        const mobileSignUpContainer = document.getElementById('smallscreen');
        // mobileSignUpClick.addEventListener('click',()=>{
        //     mobileSignUp.style.display=""None"";
        //     mobileSignUpContainer.style.display=""block"";
        // });
        function displayfunc() {
            mobileSignUp.style.display = ""None"";
            mobileSignUpContainer.style.display = ""block"";
            console.log(""abcdefgh"")

        }
        signUpButton.addEventListener('click', () => {
            container.classList.add(""right-panel-active"");
        });

        signInButto");
                WriteLiteral("n.addEventListener(\'click\', () => {\r\n            container.classList.remove(\"right-panel-active\");\r\n        });\r\n\r\n    </script>\r\n");
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
