#pragma checksum "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afae4a69233b87841be6f7d5d08d12a53d83ba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_ViewDetails), @"mvc.1.0.view", @"/Views/Transaction/ViewDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afae4a69233b87841be6f7d5d08d12a53d83ba5", @"/Views/Transaction/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddd06f74bb3e856055650c4a7ef10b90939c9e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_ViewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OA.WEB.Models.ViewModel.TransactionDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
  
    ViewData["Title"] = "View Transaction";
    Layout = "~/Views/Shared/_LayoutTransaction.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2afae4a69233b87841be6f7d5d08d12a53d83ba54983", async() => {
                WriteLiteral(@"
    <style>
        .intro-section1 {
  position: relative; }
            .intro-section1, .intro-section1 .container .row {
                height: 13vh;
                min-height: 50px;
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
                WriteLiteral("  .intro-section1 h1 {\r\n    font-size: 3rem;\r\n    font-weight: 900;\r\n    color: #fff; }\r\n  .intro-section1 p {\r\n    color: rgba(255, 255, 255, 0.5);\r\n    font-size: 1.1rem;\r\n    max-width: 400px; }\r\n\r\n    </style>\r\n");
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
        <div class=""row contentcenterp "">
        </div>
    </div>
</div>

<div class=""card"" style=""padding-top:30px;background-color:#e4f4fb"">
    <div class=""card-title"">
        <div class=""col-sm-12"">
        </div>
    </div>
    <div class=""card-body"">
        <div class=""row"" style=""align-content: center;"">
            <div class=""col-1""></div>
            <div class=""col-10"" style=""background-color:white;padding: 10px;"">
                <div");
            BeginWriteAttribute("style", " style=\"", 1466, "\"", 1474, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"row\" style=\"padding:12px\">\r\n                        <div class=\"col-7\"> <h6 style=\"color:darkblue\">Transaction Code: ");
#nullable restore
#line 56 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                                                                    Write(Model.LinkCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6> </div>\r\n                        <div class=\"col-5\" style=\"text-align:right\">");
#nullable restore
#line 57 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                                               Write(Html.Raw(Model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 60 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                 if (Model.statusID != 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"divReplace\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2afae4a69233b87841be6f7d5d08d12a53d83ba58603", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 64 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                       Write(Html.HiddenFor(item => Model.TransactionID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-12\">\r\n                                ");
#nullable restore
#line 66 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                           Write(Html.DropDownList("statusID", (SelectList)ViewBag.StatusEs, "Select Status", new { @class = "form-control cutomtextbox", @required = "required", @style = "border-color:red;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""col-12"">
                                <button onclick=""changeStaus()"" class=""btn btn-block btn-outline-primary"">Update Status</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-12"">
                    <div style=""background-color:white;padding:12px;font-size:12px;"">
                        <div>
                            <div class=""row"" style=""padding:12px"">
                                <div class=""col-7""> <h7 style=""color:black"">Seller Informations</h7> </div>
                            </div>
                        </div>
                        <table class=""table table-bordered"">
                            <thead>
                                <tr hidden></tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Seller Name</td>
");
#nullable restore
#line 89 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                     if (Model.SellerName == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Not set</td>\r\n");
#nullable restore
#line 92 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 95 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                       Write(Model.SellerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 96 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                                <tr>\r\n                                    <td>Email Address</td>\r\n\r\n                                    <td>");
#nullable restore
#line 101 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.SellerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>

                <div class=""col-12"">
                    <div style=""background-color:white;padding:12px;font-size:12px"">
                        <div>
                            <div class=""row"" style=""padding:12px"">
                                <div class=""col-7""> <h7 style=""color:black"">Buyer Informations</h7> </div>
                            </div>
                        </div>
                        <table class=""table table-bordered"">
                            <thead>
                                <tr hidden></tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Buyer Name</td>
");
#nullable restore
#line 122 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                     if (Model.FirstName == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Not set</td>\r\n");
#nullable restore
#line 125 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 128 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 128 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                                        Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 129 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                                <tr>\r\n                                    <td>Email Address</td>\r\n\r\n                                    <td>");
#nullable restore
#line 134 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.BuyerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>

                <div class=""col-12"">
                    <div style=""background-color:white;padding:12px;font-size:12px"">
                        <div>
                            <div class=""row"" style=""padding:12px"">
                                <div class=""col-7""> <h7 style=""color:black"">Product Informations</h7> </div>
                            </div>
                        </div>
                        <table class=""table table-bordered"">
                            <thead>
                                <tr hidden></tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Item Name</td>


                                    <td>");
#nullable restore
#line 157 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Description</td>\r\n\r\n                                    <td>");
#nullable restore
#line 162 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.DescriptionOfItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Terms of return</td>\r\n\r\n                                    <td>");
#nullable restore
#line 167 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.TermsOfReturns);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n");
#nullable restore
#line 176 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                 if (Model.ProductImageUrl != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-12"">
                        <div style=""background-color:white;padding:12px;font-size:12px"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr hidden></tr>
                                </thead>
                                <tbody>

                                    <tr>
                                        <td>Product Images</td>

                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 7646, "\"", 7687, 1);
#nullable restore
#line 189 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
WriteAttributeValue("", 7652, Url.Content(Model.ProductImageUrl), 7652, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"160\" /> </td>\r\n\r\n                                    </tr>\r\n\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 198 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 200 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                 if (Model.ProductImageUrl1 != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-12"">
                        <div style=""background-color:white;padding:12px;font-size:12px"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr hidden></tr>
                                </thead>
                                <tbody>

                                    <tr>
                                        <td>Product Images</td>

                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 8542, "\"", 8584, 1);
#nullable restore
#line 213 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
WriteAttributeValue("", 8548, Url.Content(Model.ProductImageUrl1), 8548, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"160\" /> </td>\r\n\r\n                                    </tr>\r\n\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 222 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 224 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                 if (Model.ProductImageUrl2 != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-12"">
                        <div style=""background-color:white;padding:12px;font-size:12px"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr hidden></tr>
                                </thead>
                                <tbody>

                                    <tr>
                                        <td>Product Images</td>

                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 9439, "\"", 9481, 1);
#nullable restore
#line 237 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
WriteAttributeValue("", 9445, Url.Content(Model.ProductImageUrl2), 9445, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"160\" /> </td>\r\n\r\n                                    </tr>\r\n\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 246 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 248 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                 if (Model.ProductImageUrl3 != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-12"">
                        <div style=""background-color:white;padding:12px;font-size:12px"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr hidden></tr>
                                </thead>
                                <tbody>

                                    <tr>
                                        <td>Product Images</td>

                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 10336, "\"", 10378, 1);
#nullable restore
#line 261 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
WriteAttributeValue("", 10342, Url.Content(Model.ProductImageUrl3), 10342, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"160\" /> </td>\r\n\r\n                                    </tr>\r\n\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 270 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                <div class=""col-12"">
                    <div style=""background-color:white;padding:12px;font-size:12px"">
                        <div>
                            <div class=""row"" style=""padding:12px"">
                                <div class=""col-7""> <h7 style=""color:black"">Transaction Informations</h7> </div>
                            </div>
                        </div>
                        <table class=""table table-bordered"">
                            <thead>
                                <tr hidden></tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Transaction ID</td>
                                    <td>");
#nullable restore
#line 289 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.TransactionID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Delivery Type</td>\r\n\r\n                                    <td>");
#nullable restore
#line 295 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.DeliveryType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Delivery Fee</td>\r\n");
#nullable restore
#line 299 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                     if (Model.Deliveryfee == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>0.00</td>\r\n");
#nullable restore
#line 302 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 306 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                       Write(Model.Deliveryfee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 307 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                                <tr>\r\n                                    <td>Delivery Time</td>\r\n\r\n                                    <td>");
#nullable restore
#line 312 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.DeliveryTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Amount</td>\r\n\r\n                                    <td>");
#nullable restore
#line 317 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Escrow Fee</td>\r\n\r\n                                    <td>");
#nullable restore
#line 322 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.escrowfee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Total Fee</td>\r\n\r\n                                    <td>");
#nullable restore
#line 327 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Transaction\ViewDetails.cshtml"
                                   Write(Model.Totalfee);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""col-1""></div>
        </div>
    </div>
</div>
<div>
</div>
<script>
    function changeStaus() {
        $(""#formid"").submit();
        $(""#divReplace"").empty();
        $(""#divReplace"").append(""<div class=\""text-center\""><h5 style=\""color:red\"">Please wait this could take sometime.</h5></div>"");

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OA.WEB.Models.ViewModel.TransactionDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
