#pragma checksum "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bed8873b18a376458e16e1740d2420bdfab7f646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Process_Page), @"mvc.1.0.view", @"/Views/Process/Page.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bed8873b18a376458e16e1740d2420bdfab7f646", @"/Views/Process/Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddd06f74bb3e856055650c4a7ef10b90939c9e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Process_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OA.WEB.Models.ViewModel.PinfoVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
  
    ViewData["Title"] = "Process";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title""> pinfo Us</h4>
            <p class=""card-description"">
                pinfo us is the display content in pinfo us page dynamically
            </p>
            <div class=""table-responsive pt-3"">
                <table class=""table table-bordered table-hover table-striped"">
                    <thead>
                        <tr>
                            <th hidden>
                            </th>
                            <th>
                                Step-1
                            </th>
                            <th>
                                Step-2
                            </th>
                            <th>
                                Step-3
                            </th>
                            <th>
                                Step-4
                            </th>
                          ");
            WriteLiteral(@"  <th>
                                Step-5
                            </th>
                            <th>
                                Step-6
                            </th>
                            <th style=""width:25%""><a href=""#"" id=""createNew"" style=""color:red"">Create New</a></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 43 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td hidden>\r\n                                    ");
#nullable restore
#line 47 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 50 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Step1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 53 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Step2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 56 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Step3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 59 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Step4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 62 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Step5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 65 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Step6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2887, "\"", 2918, 3);
            WriteAttributeValue("", 2897, "showForEdit(", 2897, 12, true);
#nullable restore
#line 68 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
WriteAttributeValue("", 2909, item.Id, 2909, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2917, ")", 2917, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-success btn-circle mdi mdi-circle-edit-outline\"></button>\r\n                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3052, "\"", 3085, 3);
            WriteAttributeValue("", 3062, "showForDelete(", 3062, 14, true);
#nullable restore
#line 69 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
WriteAttributeValue("", 3076, item.Id, 3076, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3084, ")", 3084, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-danger btn-circle mdi mdi-trash-can-outline\"></button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 72 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"modal fade\" id=\"mdlAddNew\" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3428, "\"", 3446, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                <div class=""modal-lg modal-dialog"" role=""document"" style=""width: 75%"">
                    <div class=""modal-content"">
                        <div class=""modal-header"" "">
                            <h3 class=""modal-title"">Add Preocess for how it works page</h3>
                            <h4>No need to add everything but add minimum three.</h4>
                            <button type=""button"" id=""addClose"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"" style="""">
                            <p style=""color:darkorange"">Please delete all before add!</p>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-1</label>
                                </div>
                         ");
            WriteLiteral("       <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 93 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("step1", new { @class = "form-control", @placeholder = "Step-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-2</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 101 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("step2", new { @class = "form-control", @placeholder = "Step-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-3</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 109 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("step3", new { @class = "form-control", @placeholder = "Step-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-4</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 117 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("step4", new { @class = "form-control", @placeholder = "Step-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-5</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 125 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("step5", new { @class = "form-control", @placeholder = "Step-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-6</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 133 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("step6", new { @class = "form-control", @placeholder = "Step-6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" id=""addConfirm"" class=""btn btn-primary"">Save</button>
                            <button type=""button"" id=""addCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal fade"" id=""mdlUpdate"" tabindex=""-1"" role=""dialog"" aria-labelledby="""" aria-hidden=""true"">
                <div class=""modal-lg modal-dialog"" role=""document"" style=""width: 75%"">
                    <div class=""modal-content"">
                        <div class=""modal-header"" "">
                            <h3 class=""modal-title"">Update process information</h3>
                            <button type=""button"" id=""updateClose"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
       ");
            WriteLiteral("                         <span aria-hidden=\"true\">&times;</span>\r\n                            </button>\r\n                        </div>\r\n                        <div class=\"modal-body\"");
            BeginWriteAttribute("style", " style=\"", 8054, "\"", 8062, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div>\r\n                                ");
#nullable restore
#line 155 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                           Write(Html.Hidden("UpddateID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <label>Step-1</label>\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 160 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("upstep1", new { @class = "form-control", @placeholder = "Step-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-2</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 168 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("upstep2", new { @class = "form-control", @placeholder = "Step-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-3</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 176 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("upstep3", new { @class = "form-control", @placeholder = "Step-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-4</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 184 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("upstep4", new { @class = "form-control", @placeholder = "Step-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-5</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 192 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("upstep5", new { @class = "form-control", @placeholder = "Step-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div>
                                <div class=""form-group"">
                                    <label>Step-6</label>
                                </div>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 200 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                               Write(Html.TextArea("upstep6", new { @class = "form-control", @placeholder = "Step-6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" id=""UpdateConfirm"" class=""btn btn-primary"">Update</button>
                            <button type=""button"" id=""UpdateCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal fade"" id=""mdlDelete"" tabindex=""-1"" role=""dialog""");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 11315, "\"", 11333, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                <div class=""modal-lg modal-dialog"" role=""document"" style=""width: 75%"">
                    <div class=""modal-content"">
                        <div class=""modal-header"" style=""background-color:orangered;color:white"">
                            <h3 class=""modal-title"">Delete</h3>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body""");
            BeginWriteAttribute("style", " style=\"", 11954, "\"", 11962, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 221 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\Process\Page.cshtml"
                       Write(Html.Hidden("deleteID"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            Are you sure to delete? No data can be recover in future.
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" id=""deleteConfirm"" class=""btn btn-primary"">Delete</button>
                            <button type=""button"" id=""deleteCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script src=""../../CustomScripts/pinfoManager.js""></script>

<script>
    //var _id = $(this).closest(""tr"").find(""td:eq(0) input"").val();
    $(document).ready(function () {
        $(""#createNew"").click(function (e) {
            e.preventDefault();
            $(""#mdlAddNew"").modal(""show"");
        });
        $(""#addConfirm"").click(function (e) {
            if (pinfoManager.CreateValidation() === true) {
                pinfoManager.Insertpinfo();
  ");
            WriteLiteral(@"          }
        });
        $(""#addCancel,addClose"").click(function (e) {
            pinfoManager.clearSaveInformation();
            $(""#mdlAddNew"").modal(""hide"");
        });

        $(""#UpdateConfirm"").click(function (e) {
            if (pinfoManager.UpdateValidation() === true) {
                pinfoManager.Updatepinfo();
            }
        });
        $(""#UpdateCancel,updateClose"").click(function (e) {
            pinfoManager.clearUpdateInformation();
            $(""#mdlUpdate"").modal(""hide"");
        });
        $(""#deleteConfirm"").click(function (e) {
            pinfoManager.Deletepinfo();
        });
        $(""#deleteCancel"").click(function (e) {
            $(""#mdlDelete"").modal(""hide"");
        });
    });
    function showForEdit(_id) {
        pinfoManager.GetForUpdate(_id);
    }
    function showForDelete(_id) {
        $(""#deleteID"").val(_id);
        $(""#mdlDelete"").modal(""show"");
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OA.WEB.Models.ViewModel.PinfoVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
