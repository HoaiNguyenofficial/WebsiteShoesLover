#pragma checksum "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb767b7b9e28b97a0b2867246a1c281cfa13a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_CreateProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/CreateProduct.cshtml")]
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
#line 1 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\_ViewImports.cshtml"
using ShoesLover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\_ViewImports.cshtml"
using ShoesLover.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
using ShoesLover.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb767b7b9e28b97a0b2867246a1c281cfa13a8c", @"/Areas/Admin/Views/Product/CreateProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d652e32e50049a3a6fb731130cf3a1e6ecd20d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_CreateProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger col-3 m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
  
    ViewData["Title"] = "Add_product";
    IEnumerable<CategoryMasterModel> categoryMasterData = ViewData["category"] as IEnumerable<CategoryMasterModel>;
    IEnumerable <Brand> brands = ViewData["brand"] as IEnumerable<Brand>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h3");
            BeginWriteAttribute("class", " class=\"", 342, "\"", 350, 0);
            EndWriteAttribute();
            WriteLiteral(">Thêm mới sản phẩm</h3>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bb767b7b9e28b97a0b2867246a1c281cfa13a8c6848", async() => {
                WriteLiteral(@"
            <input name=""Id"" type=""hidden"" class=""col-lg-9 col-md-9 col-sm-9 p-0"" />

            <div class=""row m-3"">
                <label for=""ProductName"" class=""col-form-label col-sm-2"">Tên</label>
                <div class=""col-sm-10"">
                    <input name=""ProductName"" type=""text"" class=""form-control"" required />
                </div>
            </div>
            <div class=""row m-3"">
                <label for=""ProductTag"" class=""col-form-label col-sm-2"">Mã sản phẩm</label>
                <div class=""col-sm-10"">
                    <input name=""ProductTag"" type=""text"" class=""form-control"" required />
                </div>
            </div>
            <div class=""row m-3"">
                <label for=""ImageFile"" class=""col-form-label col-sm-2"">Ảnh đại diện sản phẩm</label>
                <div class=""col-sm-10"">
                    <input name=""ImageFile"" type=""file"" class=""form-control"" accept=""image/*"" required>
                </div>
            </div>       ");
                WriteLiteral(@"   
            <div class=""row m-3"">
                <label class=""col-form-label col-sm-2"">Danh mục</label>
                <div class=""col-sm-4"">
                    <select id=""CategorySelect"" class=""form-select"" required>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bb767b7b9e28b97a0b2867246a1c281cfa13a8c8479", async() => {
                    WriteLiteral("Chọn danh mục");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
                         foreach (var item in categoryMasterData)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bb767b7b9e28b97a0b2867246a1c281cfa13a8c10481", async() => {
#nullable restore
#line 41 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
                                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>

            <div class=""row m-3"">
                <label for=""SubcategoryId"" class=""col-form-label col-sm-2"">Danh mục con</label>
                <div class=""col-sm-4"">
                    <select name=""SubcategoryId"" class=""form-select"" id=""subcategory"" required>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bb767b7b9e28b97a0b2867246a1c281cfa13a8c13060", async() => {
                    WriteLiteral("Chọn danh mục con");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""row m-3"">
                <label for=""BrandId"" class=""col-form-label col-sm-2"">Thương hiệu</label>
                <div class=""col-sm-4"">
                    <select name=""BrandId"" class=""form-select"" required>
");
#nullable restore
#line 59 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
                         foreach (var item in brands)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bb767b7b9e28b97a0b2867246a1c281cfa13a8c15380", async() => {
#nullable restore
#line 61 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
                                                Write(item.BrandName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>

            <div class=""row m-3"">
                <label for=""Gender"" class=""col-form-label col-sm-2"">Giới tính</label>
                <div class=""col-sm-4"">
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" name=""Gender"" value=""0"" class=""form-check-input"" id=""genderMale"" />
                        <label class=""form-check-label"" for=""genderMale"">Nữ</label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" name=""Gender"" value=""1"" class=""form-check-input"" id=""genderFemale"" />
                        <label class=""form-check-label"" for=""genderFemale"">Nam</label>
                    </div>
                    <div class=""form-check form-check-inline"">
                        <input type=""radio"" name=""Gender"" value=""2"" class=""form-check-input"" id=""genderBoth"" checked />
               ");
                WriteLiteral(@"         <label class=""form-check-label"" for=""genderBoth"">Cả hai</label>
                    </div>
                </div>
            </div>

            <div class=""row m-3"">
                <label for=""RegularPrice"" class=""col-form-label col-sm-2"">Giá thường</label>
                <div class=""col-sm-4"">
                    <input name=""RegularPrice"" type=""number"" value=""0"" required />
                </div>
            </div>

            <div class=""row m-3"">
                <label for=""SalePrice"" class=""col-form-label col-sm-2"">Giá khuyến mãi</label>
                <div class=""col-sm-4"">
                    <input name=""SalePrice"" type=""number"" value=""0"" required />
                </div>
            </div>
            <div class=""row m-3"">
                <label for=""Description"" class=""col-form-label col-sm-2"">Mô tả</label>
                <div class=""col-sm-10"">
                    <textarea name=""Description"" style=""height: 250px; width: 100%;"" required></textarea>
           ");
                WriteLiteral(@"     </div>
            </div>

            <div class=""row m-3 justify-content-center"">

                <input type=""hidden"" name=""redirectOption"" id=""redirectOption"" />

                <input type=""submit"" value=""Tiếp tục thiết lập biến thể"" id=""continue"" class=""btn btn-success col-3 m-2"" />
                <input type=""submit"" value=""Lưu và trở về"" id=""saveAndExit"" class=""btn btn-primary col-3 m-2"" />

                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bb767b7b9e28b97a0b2867246a1c281cfa13a8c20209", async() => {
                    WriteLiteral("Hủy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>
    $(""#CategorySelect"").change(() => {
        console.log(this);
        console.log($(""#CategorySelect"").val());
        var subcate = $(""#subcategory"");
        subcate.html("""");
        subcate.append(""<option disabled selected>Chọn danh mục con</option>"");
        $.ajax({
            url: '");
#nullable restore
#line 129 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Areas\Admin\Views\Product\CreateProduct.cshtml"
             Write(Url.Action( "GetSubCategoryList","Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
            type: ""POST"",
            dataType: ""JSON"",
            data: { id: $(""#CategorySelect"").val().toString() },
            success: function (data) {
                console.log(data);
                data.forEach((element, index, array) => {
                    console.log(element);
                    console.log(index);
                    console.log(array);
                    var str = '<option value=""' + element.id + '"">' + element.subCategoryName + '</option>';
                    subcate.append(str);
                })
            },
            error: () => alert(""something wrong"")
        })
        
    })
    $(""#continue"").click(() => $(""#redirectOption"").val(""continue""));
    $(""#saveAndExit"").click(() => $(""#redirectOption"").val(""exit""));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
