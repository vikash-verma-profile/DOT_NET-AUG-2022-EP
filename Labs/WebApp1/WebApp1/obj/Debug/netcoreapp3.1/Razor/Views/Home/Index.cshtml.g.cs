#pragma checksum "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "274def2adeafa2dcff12f9a7511850cb6689a3f5"
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
#line 1 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\_ViewImports.cshtml"
using WebApp1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274def2adeafa2dcff12f9a7511850cb6689a3f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d4aef54156ba08c67a5c94f870cc1df9346736", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp1.Models.TblUserDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "274def2adeafa2dcff12f9a7511850cb6689a3f53693", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 4 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\Index.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"row mb-3\">\r\n        <label for=\"inputEmail3\" class=\"col-sm-2 col-form-label\">Email</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 8 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control", @id = "inputEmail3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">First Name</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 14 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">Last Name</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">Gender</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Gender, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label for=\"inputPassword3\" class=\"col-sm-2 col-form-label\">Age</label>\r\n        <div class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Age, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Create</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp1.Models.TblUserDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
