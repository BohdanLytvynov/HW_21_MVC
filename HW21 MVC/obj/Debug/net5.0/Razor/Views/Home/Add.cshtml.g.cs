#pragma checksum "D:\C# Projects\HW21 MVC\HW21 MVC\Views\Home\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2eb8c45732acd4b5e894cf7a0445cfeba18e9cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Add), @"mvc.1.0.view", @"/Views/Home/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2eb8c45732acd4b5e894cf7a0445cfeba18e9cc", @"/Views/Home/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1188223533e3e3f7c9fd31678a2a31b306fb9771", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/AddNote"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\C# Projects\HW21 MVC\HW21 MVC\Views\Home\Add.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C# Projects\HW21 MVC\HW21 MVC\Views\Home\Add.cshtml"
Write(await Html.PartialAsync("PartialJs"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n<h1 class=\"h1\">To create a new note please fill the form bellow:</h1>\r\n<div class=\"form\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2eb8c45732acd4b5e894cf7a0445cfeba18e9cc3875", async() => {
                WriteLiteral(@"
        <div class=""formitem"">
            <label>Enter Surename:</label><br />
            <input class=""textinp"" type=""text"" name=""Surename"" id=""Surename"" />
            <br />
        </div>
        <div class=""formitem"">
            <label>Enter Name:</label><br />
            <input class=""textinp"" type=""text"" name=""Name"" id=""Name"" />
            <br />
        </div>
        <div class=""formitem"">
            <label>Enter Lastname:</label><br />
            <input class=""textinp"" type=""text"" name=""Lastname"" id=""Lastname"" />
            <br />
        </div>
        <div class=""formitem"">
            <label>Enter Phone:</label><br />
            <input class=""numbinp"" type=""text"" name=""Phone"" id=""Phone"" />
            <br />
        </div>
        <div class=""formitem"">
            <label>Enter Adress:</label><br />
            <textarea class=""numbtxt"" name=""Adress"" id=""Adress"" rows=""3"" cols=""70"" wrap=""soft"">
            </textarea>
            <br />
        </div>
        <");
                WriteLiteral(@"div class=""formitem"">
            <label>Enter Description:</label><br />
            <textarea class=""numbtxt"" name=""Description"" id=""Description"" rows=""3"" cols=""70"" wrap=""soft"">
            </textarea>
            <br />
            <p>
                <input type=""submit""
                       name=""AddNote""
                       value=""Add Note To DB""
                       class=""submit""
                       />
            </p>
        </div>
    ");
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
            WriteLiteral("\r\n\r\n</div>");
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
