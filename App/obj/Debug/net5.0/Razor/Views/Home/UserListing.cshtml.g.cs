#pragma checksum "D:\Enterprise Software\Assignment1\App\Views\Home\UserListing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c910c1341d3e3ada51bcac67b053b0a89b3e84c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserListing), @"mvc.1.0.view", @"/Views/Home/UserListing.cshtml")]
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
#line 1 "D:\Enterprise Software\Assignment1\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Enterprise Software\Assignment1\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c910c1341d3e3ada51bcac67b053b0a89b3e84c7", @"/Views/Home/UserListing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserListing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Enterprise Software\Assignment1\App\Views\Home\UserListing.cshtml"
  
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>User Listing</h2>\r\n\r\n");
            WriteLiteral(@"<a href=""javascript:history.back()"">Dashboard</a>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Phone Number</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "D:\Enterprise Software\Assignment1\App\Views\Home\UserListing.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 25 "D:\Enterprise Software\Assignment1\App\Views\Home\UserListing.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 26 "D:\Enterprise Software\Assignment1\App\Views\Home\UserListing.cshtml"
               Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\Enterprise Software\Assignment1\App\Views\Home\UserListing.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\Enterprise Software\Assignment1\App\Views\Home\UserListing.cshtml"
               Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "D:\Enterprise Software\Assignment1\App\Views\Home\UserListing.cshtml"

            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591