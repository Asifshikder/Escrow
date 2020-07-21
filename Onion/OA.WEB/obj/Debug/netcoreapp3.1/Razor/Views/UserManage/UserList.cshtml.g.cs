#pragma checksum "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\UserManage\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd7592549d36fa5e1067da5a6412719c736cb9af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManage_UserList), @"mvc.1.0.view", @"/Views/UserManage/UserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd7592549d36fa5e1067da5a6412719c736cb9af", @"/Views/UserManage/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddd06f74bb3e856055650c4a7ef10b90939c9e6", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManage_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\UserManage\UserList.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\UserManage\UserList.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title""> List of Users</h4>
            <p class=""card-description"">
                
            </p>
            <div class=""table-responsive pt-3"">
                <table id=""sellertbl"" class=""table table-bordered table-hover table-striped"">
                    <thead>
                        <tr>
                            <th hidden></th>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th>Transactions</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                </table>
            </div>
            <div class=""modal fade"" id=""mdlDelete"" tabindex=""-1"" role=""dialog""");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1081, "\"", 1099, 0);
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
            BeginWriteAttribute("style", " style=\"", 1720, "\"", 1728, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 39 "C:\Users\Asifs\Desktop\PayGuardex\Onion\OA.WEB\Views\UserManage\UserList.cshtml"
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

<script src=""../../CustomScripts/UserManager.js""></script>
<script>
    var _ID;
    var table;
    var StatusIsActive = 1;
    $(document).ready(function () {
        table = $(""#sellertbl"").DataTable
            ({
                ""language"":
                {
                    ""processing"": ""<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>""
                },
                ""processing"": tr");
            WriteLiteral(@"ue,
                ""serverSide"": true,

                ""ajax"":
                {
                    ""url"": ""/UserManage/GetAllUsers"",
                    ""type"": ""POST"",
                    ""dataType"": ""JSON"",
                    data: function (d) {
                        d.__RequestVerificationToken = $('[name=__RequestVerificationToken]').val();
                    }
                },
                ""columnDefs"": [
                    { ""targets"": [0], ""width"": ""5%"" },
                    { ""targets"": [0], ""data"": ""id"", ""render"": function (data, type, row, meta) { return ""<td hidden><input type='hidden' id='id' name='id' value="" + row.id + ""></td>"" } },
                    { ""targets"": [6], ""width"": ""15%"", ""style"": ""align='center'"", ""orderable"": false, ""data"": ""Action"", ""render"": function (data, type, row, meta) { return '<button id=""showForDelete"" class=""btn btn-sm btn-outline-danger btn-circle mdi mdi-trash-can-outline""></button>   ' } }
                ],
                ""fnRowCal");
            WriteLiteral(@"lback"": function (nRow, aData, iDisplayIndex, iDisplayIndexFull) {
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
                        ""data"":""transaction""
                    },
                    {
                        ""data"":""""
                    }
                ],
                ""bFilter"": false
            });


        $(""#sellertbl"").on(""click"", ""#showForDelete"", function (e) {

            e.preventDefault();
      ");
            WriteLiteral(@"      _ID = $(this).closest(""tr"").find(""td:eq(0) input"").val();
            $(""#mdlDelete"").modal(""show"");
        });

        $(""#deleteConfirm"").click(function () {
            UserManager.DeleteSeller(_ID);
        });

        $(""#deleteCancel"").click(function () {
            $(""#mdlDelete"").modal(""hide"");
        });
    });



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
