#pragma checksum "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\UserManage\EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3869ec77cbb4f3fb3bd5c8398cee8d331c4f54b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManage_EmployeeList), @"mvc.1.0.view", @"/Views/UserManage/EmployeeList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3869ec77cbb4f3fb3bd5c8398cee8d331c4f54b", @"/Views/UserManage/EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddd06f74bb3e856055650c4a7ef10b90939c9e6", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManage_EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\UserManage\EmployeeList.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\UserManage\EmployeeList.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title""> List of Employee</h4>
            <p class=""card-description"">

            </p>
            <div class=""table-responsive pt-3"">
                <table id=""tblEmployee"" class=""table table-bordered table-hover table-striped"">
                    <thead>
                        <tr>
                            <th hidden></th>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th style=""width:25%""><a href=""#"" id=""createNew"" style=""color:red"">Create New</a></th>
                        </tr>
                    </thead>
                </table>
            </div>
            <div class=""modal fade"" id=""mdlAddNew"" tabindex=""-1"" role=""dialog""");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1089, "\"", 1107, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                <div class=""modal-lg modal-dialog"" role=""document"" style=""width: 75%"">
                    <div class=""modal-content"">
                        <div class=""modal-header"" "">
                            <h3 class=""modal-title"">Add new employee</h3>
                            <button type=""button"" id=""addClose"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"" style="""">
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label>First Name</label>
                                    </div>
                                    <div class=""form-group"">
                                        <input id=""addFirstName"" class=""for");
            WriteLiteral(@"m-control"" placeholder=""Fist Name"" />
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label>Last Name</label>
                                    </div>
                                    <div class=""form-group"">
                                        <input id=""addLastName"" class=""form-control"" placeholder=""Last Name"" />
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label>Phone</label>
                                    </div>
                                    <div class=""form-group"">
                                        <input id=""addPhone"" class=""form-control"" placeholder=""Phone"" />
                      ");
            WriteLiteral(@"              </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Email</label>
                                    </div>
                                    <div class=""form-group"">
                                        <input id=""addEmail"" class=""form-control"" placeholder=""Email"" />
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Password</label>
                                    </div>
                                    <div class=""form-group"">
                                        <input id=""addPassword"" class=""form-control"" placeholder=""Password"" />
                                    </div>
                                </div>
 ");
            WriteLiteral(@"                           </div>                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" id=""addConfirm"" class=""btn btn-primary"">Save</button>
                            <button type=""button"" id=""addCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal fade"" id=""mdlDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby="""" aria-hidden=""true"">
                <div class=""modal-lg modal-dialog"" role=""document"" style=""width: 75%"">
                    <div class=""modal-content"">
                        <div class=""modal-header"" style=""background-color:orangered;color:white"">
                            <h3 class=""modal-title"">Delete</h3>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-h");
            WriteLiteral(@"idden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"" style="""">
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

<script src=""../../CustomScripts/UserManager.js""></script>
<script>
    var _ID;
    var table;
    var StatusIsActive = 1;
    $(document).ready(function () {
        table = $(""#tblEmployee"").DataTable
            ({
                ""language"":
                {
                    ""processing"": ""<");
            WriteLiteral(@"div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>""
                },
                ""processing"": true,
                ""serverSide"": true,

                ""ajax"":
                {
                    ""url"": ""/UserManage/GetAllEmployees"",
                    ""type"": ""POST"",
                    ""dataType"": ""JSON"",
                    data: function (d) {
                        d.__RequestVerificationToken = $('[name=__RequestVerificationToken]').val();
                    }
                },
                ""columnDefs"": [
                    { ""targets"": [0], ""width"": ""5%"" },
                    { ""targets"": [0], ""data"": ""id"", ""render"": function (data, type, row, meta) { return ""<td hidden><input type='hidden' id='id' name='id' value="" + row.id + ""></td>"" } },
                    { ""targets"": [5], ""width"": ""15%"", ""style"": ""align='center'"", ""orderable"": false, ""data"": ""Action"", ""render"": function (data, type, row, meta) { return '<bu");
            WriteLiteral(@"tton id=""showForUpdate"" class=""btn btn-sm btn-outline-success btn-circle mdi mdi-circle-edit-outline""></button><button id=""showForDelete"" class=""btn btn-sm btn-outline-danger btn-circle mdi mdi-trash-can-outline""></button>   ' } }
                ],
                ""fnRowCallback"": function (nRow, aData, iDisplayIndex, iDisplayIndexFull) {
                    $(nRow).find(""td:eq(0)"").attr(""hidden"", true);
                    return nRow;
                },
                ""columns"": [
                    {
                        ""data"": ""id""
                    },
                    {
                        ""data"": ""firstName""
                    },
                    {
                        ""data"": ""lastName""
                    },
                    {
                        ""data"": ""email""
                    },
                    {
                        ""data"": ""phone""
                    },
                    {
                        ""data"":""""
                    }
  ");
            WriteLiteral(@"              ],
                ""bFilter"": false
            });


        $(""#tblEmployee"").on(""click"", ""#showForDelete"", function (e) {

            e.preventDefault();
            _ID = $(this).closest(""tr"").find(""td:eq(0) input"").val();
            $(""#mdlDelete"").modal(""show"");
        });

        $(""#createNew"").click(function (e) {
            e.preventDefault();
            $(""#mdlAddNew"").modal(""show"");
        });
        $(""#addConfirm"").click(function (e) {
            if (UserManager.CreateValidation() === true) {
                UserManager.InsertEmployee();
            }
        });
        $(""#addCancel,addClose"").click(function (e) {
            UserManager.clearSaveInformation();
            $(""#mdlAddNew"").modal(""hide"");
        });

        $(""#deleteConfirm"").click(function () {
            UserManager.DeleteEmployee(_ID);
        });

        $(""#deleteCancel"").click(function () {
            $(""#mdlDelete"").modal(""hide"");
        });
    });



</s");
            WriteLiteral("cript>\r\n\r\n");
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