#pragma checksum "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2e86f58131e5decb0602327d43c1e07d1b1fd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\_ViewImports.cshtml"
using PenaltyCalculation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\_ViewImports.cshtml"
using PenaltyCalculation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da2e86f58131e5decb0602327d43c1e07d1b1fd4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4add486ea28e751792854c2a630eee2f8004d174", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PenaltyCalculation.Models.InputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
 if (ViewBag.DateError != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 style=\"color:orangered\">");
#nullable restore
#line 10 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
                       Write(ViewBag.DateError);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 11 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da2e86f58131e5decb0602327d43c1e07d1b1fd44633", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                <h6 style=\"color:orangered\">CheckOut Date</h6>\r\n                ");
#nullable restore
#line 19 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(p => p.CheckOutDate, new { @class = "form-control", @type = "date" ,@required  = "required"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                <h6 style=\"color:orangered\">Returned Date</h6>\r\n                ");
#nullable restore
#line 25 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(p => p.ReturnDate, new { @class = "form-control", @type = "date" ,@required  = "required"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                <h6 style=\"color:orangered\">Country</h6>\r\n                ");
#nullable restore
#line 31 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(p => p.CountryId, (List<SelectListItem>)ViewBag.countryDropDownItems, new { @class = "form-control" ,@required  = "required"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <button style=\"float:right\" type=\"submit\" class=\"btn btn-danger\">Submit</button>\r\n        </div>\r\n\r\n        <h3 style=\"color:orangered\">");
#nullable restore
#line 36 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
                               Write(ViewBag.result);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\MERVE-AYYILDIZ-PC\source\repos\PenaltyCalculation\PenaltyCalculation\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PenaltyCalculation.Models.InputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
