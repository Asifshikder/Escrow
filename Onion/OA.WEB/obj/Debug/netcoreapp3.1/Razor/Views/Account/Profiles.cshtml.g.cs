#pragma checksum "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a8b196d9aa794c11410e61216614636e50fffbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profiles), @"mvc.1.0.view", @"/Views/Account/Profiles.cshtml")]
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
#line 1 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\_ViewImports.cshtml"
using OA.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\_ViewImports.cshtml"
using OA.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8b196d9aa794c11410e61216614636e50fffbf", @"/Views/Account/Profiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddd06f74bb3e856055650c4a7ef10b90939c9e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OA.DATA.Entities.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
  
    ViewData["Title"] = "Profiles";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
             if (Model.Email == "sysadmin@admin.com")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 class=\"mb-4 mt-4\">\r\n                    Pay Guardex\r\n                </h3>\r\n");
#nullable restore
#line 15 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
            }
            else if (@Model.FirstName == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 class=\"mb-4 mt-4\">\r\n                    Not Set yet\r\n                </h3>\r\n");
#nullable restore
#line 21 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
                            Write(Model.LastName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
                                                

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""row"">
                <div class=""col-6"" style=""text-align:left"">
                    <a href=""/Account/EditProfiles"" class=""btn btn-sm btn-outline-success"">Edit Profile</a>
                </div>
                <div class=""col-6"" style=""text-align:right"">
                    <a href=""/account/ChangePassword"" class=""btn btn-sm btn-outline-success"">Change Password</a>
                </div>
            </div>
            <div class=""row"">
                <table class=""table table-bordered"">
                    <tbody>
                        <tr>
                            <td>Name</td>
                            <td> ");
#nullable restore
#line 41 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
                            Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
                                             Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Email</td>\r\n                            <td>");
#nullable restore
#line 45 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Phone </td>\r\n                            <td> ");
#nullable restore
#line 49 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profiles.cshtml"
                            Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OA.DATA.Entities.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
