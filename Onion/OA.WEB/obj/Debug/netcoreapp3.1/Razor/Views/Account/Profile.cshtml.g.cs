#pragma checksum "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88e28945f3b17de5a2a518a519ac9c8201ff7728"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e28945f3b17de5a2a518a519ac9c8201ff7728", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddd06f74bb3e856055650c4a7ef10b90939c9e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OA.DATA.Entities.ApplicationUser>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88e28945f3b17de5a2a518a519ac9c8201ff77283302", async() => {
                WriteLiteral(@"
    <style>
        .span30 {
            padding-left: 30px;
        }
        .box-smaller {
            height: 25px;
        }
        .box-md {
            height: 35px;
        }

        .intro-section1 {
            position: relative;
        }

            .intro-section1, .intro-section1 .container .row {
                min-height: 90px;
                background-color: #01426a;
            }

        .intro-section:before {
            content: """";
            position: absolute;
            height: 10%;
            width: 100%;
            border-bottom-right-radius: 0px;
        }

");
                WriteLiteral(@"        .intro-section1 h1 {
            font-size: 3rem;
            font-weight: 900;
            color: #fff;
        }

        .intro-section1 p {
            color: rgba(255, 255, 255, 0.5);
            font-size: 1.1rem;
            max-width: 400px;
        }

    </style>
");
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
            WriteLiteral(@"
<div class=""intro-section1"" id=""home-section"">
    <div class=""container"">

    </div>
</div>
<div class=""container"" style=""background-color:#c7ebeb"">
    <div style=""padding:15px;"">
        <div class=""row"" style=""background-color:white"">
            <div class=""col-md-12"">
                <div>
                    <div class=""row"" style=""padding:12px"">
                        <div class=""col-7"">
");
#nullable restore
#line 68 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                             if (Model.FirstName == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h6 style=\"color:darkblue\">Not set</h6>\r\n");
#nullable restore
#line 71 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h6 style=\"color:darkblue\">");
#nullable restore
#line 75 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                                      Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 75 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                                                       Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</h6>\r\n");
#nullable restore
#line 76 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    
                        <div class=""col-5"" style=""text-align:right""> <a href=""/Account/EditProfile"" class=""btn btn-outline-success"">Edit Profile</a></div>
                    </div>
                </div>
            </div>
            <div class=""col-md-12"">
                <div>
                    <div style=""background-color:white;padding:12px;font-size:12px"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr hidden></tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Your Name</td>
");
#nullable restore
#line 93 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                     if (Model.FirstName == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Not set</td>\r\n");
#nullable restore
#line 96 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 99 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 99 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                                        Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 100 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                                <tr>\r\n                                    <td>Email Address</td>\r\n\r\n                                    <td>");
#nullable restore
#line 105 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Phone Number</td>\r\n");
#nullable restore
#line 109 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                     if (Model.PhoneNumber == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Not set</td>\r\n");
#nullable restore
#line 112 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 115 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"
                                       Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 116 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Account\Profile.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

            <div class=""col-md-12"">
                <div>
                    <div class=""row"" style=""padding:12px"">
                        <div class=""col-12"" style=""text-align:center""><a href=""/account/ChangePassword"" class=""btn btn-outline-success"">Change Password</a></div>
                    </div>
                </div>
            </div>
          
        </div>
    </div>
</div>
");
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