#pragma checksum "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9163fce46dd505538f6338faa8fe0a5a21a7c2f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9163fce46dd505538f6338faa8fe0a5a21a7c2f8", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d4aef54156ba08c67a5c94f870cc1df9346736", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp1.Models.TblUserDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<table>\r\n    <tr>\r\n        <td>First Name</td>\r\n        <td>Last Name</td>\r\n        <td>Gender</td>\r\n        <td>Age</td>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 16 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\List.cshtml"
   Write(Html.Raw(item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 17 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\List.cshtml"
   Write(Html.Raw(item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 18 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\List.cshtml"
   Write(Html.Raw(item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\List.cshtml"
   Write(Html.Raw(item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 21 "C:\Users\LEVEL UP SOLUTIONS 1\Desktop\Dot-Net-Trainings\Labs\WebApp1\WebApp1\Views\Home\List.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp1.Models.TblUserDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
