#pragma checksum "C:\Users\ssiddiqui\source\repos\JavaScriptExample1\JavaScriptExample1\Views\Home\UserForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5cff051561953906cf7243ea966606e2a7801d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserForm), @"mvc.1.0.view", @"/Views/Home/UserForm.cshtml")]
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
#line 1 "C:\Users\ssiddiqui\source\repos\JavaScriptExample1\JavaScriptExample1\Views\_ViewImports.cshtml"
using JavaScriptExample1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ssiddiqui\source\repos\JavaScriptExample1\JavaScriptExample1\Views\_ViewImports.cshtml"
using JavaScriptExample1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5cff051561953906cf7243ea966606e2a7801d4", @"/Views/Home/UserForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f639bb3c6cdb9c5043c799161ba72ddf4db7027", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JavaScriptExample1.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validateForm()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ssiddiqui\source\repos\JavaScriptExample1\JavaScriptExample1\Views\Home\UserForm.cshtml"
  
    ViewData["Title"] = "UserForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>UserForm</h1>\r\n\r\n<h4>User</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5cff051561953906cf7243ea966606e2a7801d44643", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\" for=\"FirstName\" id=\"fNameLabel\">FirstName</label>\r\n                <input class=\"form-control\" type=\"text\" id=\"FirstName\" name=\"FirstName\"");
                BeginWriteAttribute("value", " value=\"", 484, "\"", 492, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""fNameFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""LastName"" id=""lNameLabel"">LastName</label>
                <input class=""form-control"" type=""text"" id=""LastName"" name=""LastName""");
                BeginWriteAttribute("value", " value=\"", 828, "\"", 836, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""lNameFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""Email"">Email</label>
                <input class=""form-control"" type=""text"" id=""Email"" name=""Email""");
                BeginWriteAttribute("value", " value=\"", 1144, "\"", 1152, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""EmailFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""Password"">Password</label>
                <input class=""form-control"" type=""text"" id=""Password"" name=""Password""");
                BeginWriteAttribute("value", " value=\"", 1472, "\"", 1480, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""PasswordFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""Password"">Confirm Password</label>
                <input class=""form-control"" type=""text"" id=""ConfirmPassword"" name=""ConfirmPassword""");
                BeginWriteAttribute("value", " value=\"", 1825, "\"", 1833, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""ConfirmPasswordFeedback""></span>
            </div>
            <div id=""Feedback""></div>
            <br/>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<script>

    function validateForm() {
        let result = validateFirstName() & validateLastName() & validateEmail() & validatePassword() & validateConfirmPassword();
        debugger;
        if (!result) {
            document.querySelector(""#Feedback"").innerHTML = ""<strong>Your form has errors. See above.</strong>"";
            return false;
        }
        else {
            return true;
        }
    }

    function validateFirstName() {
        let name = document.querySelector(""#FirstName"").value;
        let warning = '';

        if (!name || name.length < 2) {
            warning += 'Name is empty or too short. ';
        }

        if (warning == '') {
            document.querySelector(""#fNameLabel"").classList.remove('text-danger');
            document.querySelector(""#fNameFeedback"").innerHTML = '';
            return true;
        } else {
            document.querySelector(""#fNameFeedback"").innerHTML = warning;
            document.queryS");
            WriteLiteral(@"elector(""#fNameLabel"").classList.add('text-danger');
            return false;
        }
    }

    function validateLastName() {
        let name = document.querySelector(""#LastName"").value;
        let warning = '';

        if (!name || name.length < 2) {
            warning += 'Name is empty or too short. ';
        }

        if (warning == '') {
            document.querySelector(""#lNameFeedback"").innerHTML = '';
            return true;
        } else {
            document.querySelector(""#lNameFeedback"").innerHTML = warning;

            return false;
        }
    }

    function validateEmail() {
        let email = document.querySelector(""#Email"").value;
        let warning = '';

        let regex = /(\w){2,}");
            WriteLiteral(@"@(\w){2,}\.(\w){2,}/;
        if (!regex.test(email)) {
            warning += 'Invalid email';
        }

        if (warning == '') {
            return true;
        }
        else {
            document.querySelector(""#EmailFeedback"").innerHTML = warning;

        }
    }

    function validatePassword() {
        let password = document.querySelector('#Password').value;
        let warning = '';
        let regex = /(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{8,}/

        if (!regex.test(password)) {
            warning += 'Invalid password. Must have at least 8 characters, one capital letter, one lower-case letter, one number, and one symbol';
        }
        if (warning == '') {
            return true;
        }
        else {
            document.querySelector(""#PasswordFeedback"").innerHTML = warning;

        }
    }

    function validateConfirmPassword() {
        let password = document.querySelector('#Password').value;
        let confirmPassword");
            WriteLiteral(@" = document.querySelector('#ConfirmPassword').value;
        let warning = '';

        if (password != confirmPassword) {
            warning += 'Passwords do not match.';
        }
        if (warning == '') {
            return true;
        }
        else {
            document.querySelector(""#ConfirmPasswordFeedback"").innerHTML = warning;

        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JavaScriptExample1.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591