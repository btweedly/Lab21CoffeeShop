#pragma checksum "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbd231ef19f2169191e8c7689c21591891429150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Database_RegisterUser), @"mvc.1.0.view", @"/Views/Database/RegisterUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Database/RegisterUser.cshtml", typeof(AspNetCore.Views_Database_RegisterUser))]
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
#line 1 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\_ViewImports.cshtml"
using Lab20CoffeeShopPt3;

#line default
#line hidden
#line 2 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\_ViewImports.cshtml"
using Lab20CoffeeShopPt3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd231ef19f2169191e8c7689c21591891429150", @"/Views/Database/RegisterUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9c916694dec1b37ef170a605eb3d4d1b1cd2eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Database_RegisterUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab20CoffeeShopPt3.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Database/RegisterUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
  
    ViewData["Title"] = "RegisterUser";

#line default
#line hidden
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(92, 50, true);
            WriteLiteral("<h1 style=\"color:burlywood\">Register User</h1>\r\n\r\n");
            EndContext();
            BeginContext(142, 1151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbd231ef19f2169191e8c7689c215918914291504574", async() => {
                BeginContext(194, 122, true);
                WriteLiteral("\r\n\r\n    <div class=\"fields\" style=\"color: burlywood\">\r\n        <div class=\"fields\">\r\n            <div>\r\n\r\n                ");
                EndContext();
                BeginContext(317, 43, false);
#line 15 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.LabelFor(m => m.UserName, "User Name"));

#line default
#line hidden
                EndContext();
                BeginContext(360, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(379, 32, false);
#line 16 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.TextBoxFor(m => m.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(411, 59, true);
                WriteLiteral("\r\n\r\n            </div>\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(471, 44, false);
#line 20 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.LabelFor(m => m.Email, "Email Address"));

#line default
#line hidden
                EndContext();
                BeginContext(515, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(534, 29, false);
#line 21 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(563, 57, true);
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(621, 42, false);
#line 24 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.LabelFor(m => m.UserPass, "Password"));

#line default
#line hidden
                EndContext();
                BeginContext(663, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(682, 32, false);
#line 25 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.TextBoxFor(m => m.UserPass));

#line default
#line hidden
                EndContext();
                BeginContext(714, 57, true);
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(772, 45, false);
#line 28 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.LabelFor(m => m.UserFirst, "First Name"));

#line default
#line hidden
                EndContext();
                BeginContext(817, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(836, 33, false);
#line 29 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.TextBoxFor(m => m.UserFirst));

#line default
#line hidden
                EndContext();
                BeginContext(869, 57, true);
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(927, 43, false);
#line 32 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.LabelFor(m => m.UserLast, "Last Name"));

#line default
#line hidden
                EndContext();
                BeginContext(970, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(989, 32, false);
#line 33 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.TextBoxFor(m => m.UserLast));

#line default
#line hidden
                EndContext();
                BeginContext(1021, 57, true);
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(1079, 40, false);
#line 36 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.LabelFor(m => m.UserFunds, "Money"));

#line default
#line hidden
                EndContext();
                BeginContext(1119, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1138, 33, false);
#line 37 "C:\Users\tweed\source\repos\Lab20CoffeeShopPt3\Lab20CoffeeShopPt3\Views\Database\RegisterUser.cshtml"
           Write(Html.TextBoxFor(m => m.UserFunds));

#line default
#line hidden
                EndContext();
                BeginContext(1171, 115, true);
                WriteLiteral("\r\n            </div>\r\n\r\n\r\n            <input type=\"submit\" value=\"Sign me up!\" />\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab20CoffeeShopPt3.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
