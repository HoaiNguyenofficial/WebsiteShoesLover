#pragma checksum "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158621d82eee14346f38349b369d400c2e34eda8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\_ViewImports.cshtml"
using ShoesLover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\_ViewImports.cshtml"
using ShoesLover.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158621d82eee14346f38349b369d400c2e34eda8", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d652e32e50049a3a6fb731130cf3a1e6ecd20d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Comment";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""card border-info"">
        <div class=""card-header d-flex justify-content-between"">
            <h3 class=""card-title align-middle"">Danh mục bình luận</h3>
             <div id=""notify-comment-admin""></div>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">

                <table id=""main_table"" class=""table-card align-middle"" style=""width:100%"">
                    <thead>
                        <tr>

                            <th scope=""col"">Tên người gửi</th>
                            <th scope=""col"">Bình luận</th>
                            <th scope=""col"">Ngày bình luận</th>
                            <th scope=""col"">Sản phẩm</th>
                            <th scope=""col"">Trạng thái</th>
                            <th scope=""col"">Quản lý</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr scope=\"row\">\r\n                            <td style=\"vertical-align:top;\">");
#nullable restore
#line 31 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                       Write(item.CommentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                          \r\n\r\n\r\n                            <td >\r\n                                ");
#nullable restore
#line 37 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                           Write(item.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <ul style=\"text-align: left; padding: unset; margin-top: 1rem; \">\r\n                               <span>Admin Reply:</span>\r\n");
#nullable restore
#line 40 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                 foreach (var com in item.listparentcomment)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 42 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                   Write(com.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 43 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                            <p class=\"test\"></p>\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1818, "\"", 1845, 1);
#nullable restore
#line 46 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1826, item.CommentStatus, 1826, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"list-comment-parent\"></div>\r\n                            <textarea data-comment_id=\"");
#nullable restore
#line 47 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                  Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 1944, "\"", 1992, 3);
            WriteAttributeValue("", 1952, "reply-comment-text-", 1952, 19, true);
#nullable restore
#line 47 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1971, item.ID, 1971, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1979, "form-control", 1980, 13, true);
            EndWriteAttribute();
            WriteLiteral(" rows=\"3\"></textarea><br />\r\n                            <button style=\"margin:10px 0;\" class=\"btn-reply-admin btn-xs\" data-color_id=\"");
#nullable restore
#line 48 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                                    Write(item.CommentColorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-comment_id=\"");
#nullable restore
#line 48 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                                                                           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-comment_product_id=\"");
#nullable restore
#line 48 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                                                                                                              Write(item.CommentProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Trả lời </button>\r\n                        </td>\r\n                        <td style=\"vertical-align:top;\">");
#nullable restore
#line 50 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                   Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"vertical-align:top;\"><a style=\"color: blue;\"");
            BeginWriteAttribute("href", " href=\"", 2434, "\"", 2539, 4);
            WriteAttributeValue("", 2441, "../product/ShowProductDetailObject?product_id=", 2441, 46, true);
#nullable restore
#line 51 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 2487, item.CommentProductID, 2487, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2509, "&color_id=", 2509, 10, true);
#nullable restore
#line 51 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 2519, item.CommentColorID, 2519, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 51 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                                                                                                                                     Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n\r\n");
#nullable restore
#line 53 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                         if (item.CommentStatus == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"vertical-align:top;\"><input type=\"button\" data-color_id=\"");
#nullable restore
#line 55 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                           Write(item.CommentColorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-comment_status=\"1\" data-comment_id=\"");
#nullable restore
#line 55 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                                                                                          Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-comment_product_id=\"");
#nullable restore
#line 55 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                                                                                                                             Write(item.CommentProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"width: 90px\" class=\"btn btn-primary btn-sm comment_inactive_btn\" value=\"Chưa duyệt\" /></td>\r\n");
#nullable restore
#line 56 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                         if (item.CommentStatus == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"vertical-align:top;\"><input type=\"button\" data-color_id=\"");
#nullable restore
#line 59 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                           Write(item.CommentColorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-comment_status=\"0\" data-comment_id=\"");
#nullable restore
#line 59 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                                                                                          Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-comment_product_id=\"");
#nullable restore
#line 59 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                                                                                                                             Write(item.CommentProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"width: 90px\" class=\"btn btn-danger btn-sm comment_active_btn\" value=\"Đã duyệt\" /></td>\r\n");
#nullable restore
#line 60 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"vertical-align:top;\">\r\n                            <a><i class=\"far fa-trash-alt\"></i></a>\r\n                        </td>\r\n                        </tr>\r\n");
#nullable restore
#line 65 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Areas\Admin\Views\Comment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>

                </table>
            </div>
        </div>

    </div>

</div>

<style>
    li{
        list-style:none;
    }
    #main_table_filter {
        margin-bottom: 10px;
    }

    .icon-eye-remove {
        display: none;
    }
    .block .icon-eye-remove{
        display: block;
    }
   
</style>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/rowreorder/1.2.8/js/dataTables.rowReorder.min.js""></script>
    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/responsive/2.2.9/js/dataTables.responsive.min.js""></script>
    <script src=""https://code.jquery.com/jquery-3.6.0.js"" integrity=""sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="" crossorigin=""anonymous""></script>
    <script>
        $("".comment_inactive_btn"").each(function () {
            $(this).on(""click"", function () {
                var comment_status = $(this).data(""comment_status"");
                var comment_id = $(this).data(""comment_id"");
                var comment_product_id = $(this).data(""comment_product_id"");
                var color_id = $(this).data(""color_id"");
                 
               
                $.ajax({
    ");
                WriteLiteral(@"                url: ""../comment/UpdateComment"",
                    type: ""POST"",
                    dataType: ""html"",
                    data: { product_id: comment_product_id, comment_id: comment_id, comment_status: comment_status, color_id: color_id },
                    success: function (data) {           //Xoá tất cả dữ liệu trước đó                     
                        alert(""Duyệt thành công bình luận"");
                    },
                    error: () => alert(""something wrong"")


                });
            })
          
            // location.reload(false);
        });

        $("".comment_active_btn"").each(function () {
            $(this).on(""click"", function () {

                var comment_status = $(this).data(""comment_status"");
                var comment_id = $(this).data(""comment_id"");
                var comment_product_id = $(this).data(""comment_product_id"");
                var color_id = $(this).data(""color_id"");                
             ");
                WriteLiteral(@"   $.ajax({
                    url: ""../comment/UpdateComment"",
                    type: ""POST"",
                    dataType: ""html"",
                    data: { product_id: comment_product_id, comment_id: comment_id, comment_status: comment_status, color_id: color_id },
                    success: function (data) {           //Xoá tất cả dữ liệu trước đó                     
                        alert(""Huỷ duyệt bình luận"");
                    },
                    error: () => alert(""something wrong"")

                });
            });
            
            // location.reload(false);
        });

        $("".btn-reply-admin"").on(""click"", function () {
            var comment_parent_comment = $(this).data(""comment_id"");
            var comment_text = $("".reply-comment-text-"" + comment_parent_comment).val();
            var comment_product_id = $(this).data(""comment_product_id"");
            var color_id = $(this).data(""color_id"");           
            var comment_status =");
                WriteLiteral(@" 1;
            var comment_name = 'Admin';           
            $.ajax({
                url: ""../comment/ReplyComment"",
                type: ""POST"",
                dataType: ""html"",
                data: { comment_name:comment_name, product_id: comment_product_id, comment_text: comment_text, comment_status: comment_status, comment_color_id: color_id, comment_parent_comment: comment_parent_comment },
                success: function (data) {
                    $("".reply-comment-"" + comment_parent_comment).val('');//Xoá tất cả dữ liệu trước đó
                    alert(""Trả lời bình luận thành công"");
                },
                error: () => alert(""something wrong"")
            });
        });


        $("".btn-reply-admin"").each(function () {
            var comment_parent_comment = $(this).data(""comment_id"");

            $.ajax({
                url: ""Comment/ShowCommentParent"",
                type: ""Get"",
                dataType: ""html"",
                data: { commen");
                WriteLiteral(@"t_id: comment_parent_comment },
                success: function (data) {
                  
                    $(""#list-comment-parent"").html(data);

                }
              //  error: () => alert(""something wrong"")


            });

        });
       


    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591