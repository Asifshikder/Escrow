#pragma checksum "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e4ab068f4eac5c3bcf50197f0b56f890a7737e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_Dashboard), @"mvc.1.0.view", @"/Views/Manage/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e4ab068f4eac5c3bcf50197f0b56f890a7737e4", @"/Views/Manage/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddd06f74bb3e856055650c4a7ef10b90939c9e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-12 flex-column d-flex stretch-card"">
        <div class=""row"">
            <div class=""col-lg-6 d-flex grid-margin stretch-card"">
                <div class=""card sale-diffrence-border"">
                    <div class=""card-body"">
                        <h2 class=""text-dark mb-2 font-weight-bold"">");
#nullable restore
#line 12 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml"
                                                               Write(ViewBag.Employee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h4 class=\"card-title mb-2\">Employee</h4>\r\n                        <small class=\"text-muted\">");
#nullable restore
#line 14 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml"
                                             Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </div>
                </div>
            </div>          
            <div class=""col-lg-6 d-flex grid-margin stretch-card"">
                <div class=""card sale-diffrence-border"">
                    <div class=""card-body"">
                        <h2 class=""text-dark mb-2 font-weight-bold"">");
#nullable restore
#line 21 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml"
                                                               Write(ViewBag.Seller);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h4 class=\"card-title mb-2\">Seller</h4>\r\n                        <small class=\"text-muted\">");
#nullable restore
#line 23 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml"
                                             Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
   
    <div class=""col-lg-4 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body pb-0"">
                <div class=""d-flex align-items-center justify-content-between"">
                    <h2 class=""text-danger font-weight-bold"">");
#nullable restore
#line 36 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml"
                                                        Write(ViewBag.allTransaction);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <i class=""mdi mdi-refresh mdi-18px text-dark""></i>
                </div>
            </div>
            <canvas id=""allProducts""></canvas>
            <div class=""line-chart-row-title"">All Transactions</div>
        </div>
    </div>
    <div class=""col-lg-4 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body pb-0"">
                <div class=""d-flex align-items-center justify-content-between"">
                    <h2 class=""text-info font-weight-bold"">");
#nullable restore
#line 48 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml"
                                                      Write(ViewBag.pendingTransaction);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <i class=""mdi mdi-file-document-outline mdi-18px text-dark""></i>
                </div>
            </div>
            <canvas id=""invoices""></canvas>
            <div class=""line-chart-row-title"">Pending Payment</div>
        </div>
    </div>
   
    <div class=""col-lg-4 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body pb-0"">
                <div class=""d-flex align-items-center justify-content-between"">
                    <h2 class=""text-dark font-weight-bold"">");
#nullable restore
#line 61 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Manage\Dashboard.cshtml"
                                                      Write(ViewBag.allPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <i class=""mdi mdi-cash text-dark mdi-18px""></i>
                </div>
            </div>
            <canvas id=""transactions""></canvas>
            <div class=""line-chart-row-title"">All Payment</div>
        </div>
    </div>
</div>");
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
