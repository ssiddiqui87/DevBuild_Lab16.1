#pragma checksum "C:\Users\ssiddiqui\source\repos\JavaScriptExample1\JavaScriptExample1\Views\Home\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a3eb643af2afeb9c220702406a8495072aa8084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3eb643af2afeb9c220702406a8495072aa8084", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f639bb3c6cdb9c5043c799161ba72ddf4db7027", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JavaScriptExample1.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ssiddiqui\source\repos\JavaScriptExample1\JavaScriptExample1\Views\Home\Product.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .red {\r\n        color: red;\r\n    }\r\n</style>\r\n\r\n<h1>Product</h1>\r\n\r\n<h4>Product</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a3eb643af2afeb9c220702406a8495072aa80844713", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\" for=\"Name\" id=\"NameLabel\">Name</label>\r\n                <input class=\"form-control\" type=\"text\" id=\"Name\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 527, "\"", 535, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""NameFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""Category"" id=""CategoryLabel"">Category</label>
                <input class=""form-control"" type=""text"" id=""Category"" name=""Category""");
                BeginWriteAttribute("value", " value=\"", 873, "\"", 881, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""CategoryFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""QuantityInStock"" id=""QtyLabel"">QuantityInStock</label>
                <input class=""form-control"" type=""number"" id=""QuantityInStock"" name=""QuantityInStock""");
                BeginWriteAttribute("value", " value=\"", 1248, "\"", 1256, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""QtyFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""Price"" id=""PriceLabel"">Price</label>
                <input class=""form-control"" type=""number"" id=""Price"" name=""Price""");
                BeginWriteAttribute("value", " value=\"", 1580, "\"", 1588, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""PriceFeedback""></span>
            </div>
            <div id=""Feedback""></div>
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
        let result = validateName() & validateCategory() & validateQuantity();

        if (!result) {
            document.querySelector(""#Feedback"").innerHTML = ""Your form has errors. See above."";
            return false;
        } else {
            return true;
        }
    }

    function validateName() {
        let name = document.querySelector(""#Name"").value;
        let warning = '';

        if (!name || name.length < 3) {
            warning += 'Name is empty or too short. ';
        } else if (name.length > 30) {
            warning += 'Name is too long. ';
        }

        if (warning == '') {
            document.querySelector(""#NameLabel"").classList.remove('red');
            document.querySelector(""#NameFeedback"").innerHTML = '';
            return true;
        } else {
            //display the warning in the span set up for it
            document.querySelector(""#NameFeedback"").innerHTML = warning");
            WriteLiteral(@";
            //add a CSS class to an element
            document.querySelector(""#NameLabel"").classList.add('red');
            return false;
        }
    }

    function validateCategory() {
        //debugger;
        let category = document.querySelector(""#Category"").value;
        let warning = '';

        if (!category || category.length < 5) {
            warning += 'Category is empty or too short. ';
        } else if (category.length > 20) {
            warning += 'Category is too long. ';
        }

        console.log(""In validateCategory"");
        console.log(warning);

        if (warning == '') {
            document.querySelector(""#CategoryLabel"").classList.remove('red');
            document.querySelector(""#CategoryFeedback"").innerHTML = '';
            return true;
        } else {
            //display the warning in the span set up for it
            document.querySelector(""#CategoryFeedback"").innerHTML = warning;
            //add a CSS class to an element
 ");
            WriteLiteral(@"           document.querySelector(""#CategoryLabel"").classList.add('red');
            return false;
        }
    }

    function validateQuantity() {
        let quantity = document.querySelector(""#QuantityInStock"").value;
        let warning = '';

        if (!quantity) { //0 is '0'
            warning += 'Quantity cannot be blank.';
        } else if (quantity < 0) { //numerical comparison forces it to parse to a number
            warning += 'Quantity cannot be negative.';
        }

        //advanced: catch if it's non-integer

        if (warning == '') {
            document.querySelector(""#QtyLabel"").classList.remove('red');
            document.querySelector(""#QtyFeedback"").innerHTML = '';
            return true;
        } else {
            //display the warning in the span set up for it
            document.querySelector(""#QtyFeedback"").innerHTML = warning;
            //add a CSS class to an element
            document.querySelector(""#QtyLabel"").classList.add('red');
");
            WriteLiteral("            return false;\r\n        }\r\n    }\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JavaScriptExample1.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
