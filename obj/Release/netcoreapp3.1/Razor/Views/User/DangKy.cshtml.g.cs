#pragma checksum "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Views\User\DangKy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c738cf332653c6ec51fb12f61db9122e612c2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DangKy), @"mvc.1.0.view", @"/Views/User/DangKy.cshtml")]
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
#line 1 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Views\_ViewImports.cshtml"
using ShoesLover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Views\User\DangKy.cshtml"
using ShoesLover.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c738cf332653c6ec51fb12f61db9122e612c2f", @"/Views/User/DangKy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d652e32e50049a3a6fb731130cf3a1e6ecd20d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_DangKy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/InsertIn4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Views\User\DangKy.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    * {
        box-sizing: border-box;
    }


    .container h1 {
        font-weight: bold;
        margin: 1px;
    }

    .container p {
        font-size: 14px;
        font-weight: 100;
        line-height: 20px;
        letter-spacing: 0.5px;
        margin: 20px 0 30px;
    }

    .container button {
        border-radius: 20px;
        border: 2px solid green;
        background-color: green;
        color: #FFFFFF;
        font-size: 12px;
        font-weight: bold;
        padding: 12px 45px;
        letter-spacing: 2px;
        text-transform: uppercase;
    }

    .container button:active {
        transform: scale(0.9);
    }

    .container button.ghost {
        background-color: transparent;
        border-color: #FFFFFF;
    }

    .container form {
        background-color: #FFFFFF;
        display: flex;
        align-items: center;
        justify-content: center;
        flex-direction: column;
        padding: 0px 50px;
        h");
            WriteLiteral(@"eight: 90%;
        text-align: center;
    }
      
    .container {
        background-color: #fff;
        border-radius: 10px;
        box-shadow: 0 15px 28px rgba(0, 0, 0, 0.25), 0 10px 10px rgba(0, 0, 0, 0.22);
        position: relative;
        overflow: hidden;
        width: 800px;
        max-width: 100%;
        min-height: 500px;
        padding: 200px 50px 200px 0;
        display: flex;
        margin-left: 400px;
        margin-bottom: 100px;
        margin-top: 100px;
    }

    .form-container {
        position: absolute;
        top: 0;
        height: 100%;
        transition: all 0.6s ease-in-out;
    }

    .sign-in-container {
        width: 50%;
    }


    .overlay-container {
        position: absolute;
        top: 0;
        left: 50%;
        width: 50%;
        height: 100%;
        overflow: hidden;
        transition: transform 0.6s ease-in-out;
    }


    .overlay {
        background: #FF416C;
        background: -webkit-linear-g");
            WriteLiteral(@"radient(to right, #FF4B2B, #FF416C);
        background: linear-gradient(to right, #FF4B2B, #FF416C);
        background-repeat: no-repeat;
        background-size: cover;
        background-position: 0 0;
        color: #FFFFFF;
        position: relative;
        left: -100%;
        height: 100%;
        width: 200%;
        transform: translateX(0);
        transition: transform 0.6s ease-in-out;
    }


    .overlay-panel {
        position: absolute;
        display: flex;
        align-items: center;
        justify-content: center;
        flex-direction: column;
        padding: 0 40px;
        text-align: center;
        top: 0;
        height: 100%;
        width: 50%;
        transform: translateX(0);
        transition: transform 0.6s ease-in-out;
    }


    .overlay-right {
        right: 0;
    }
     
</style>

<script>
const indicator = document.querySelector("".indicator"");
const input = document.querySelector("".password"");
const weak = document.queryS");
            WriteLiteral(@"elector("".yeu"");
const medium = document.querySelector("".binh-thuong"");
const strong = document.querySelector("".manh"");
const text = document.querySelector("".text"");
let regExpWeak = /[a-z]/;
let regExpMedium = /\d+/;
let regExpStrong = /.[!,#,$,%,^,&,*,?,_,~,-,(,)]/;
function trigger() {
    if (input.value != """") {
        indicator.style.display = ""block"";
        indicator.style.display = ""flex"";
        if (input.value.length <= 3 &&
            (input.value.match(regExpWeak) ||
                input.value.match(regExpMedium) ||
                input.value.match(regExpStrong))) no = 1;
        if (input.value.length >= 6 &&
            ((input.value.match(regExpWeak) &&
                input.value.match(regExpMedium)) ||
                (input.value.match(regExpMedium) &&
                    input.value.match(regExpStrong)) || (input.value.match(regExpWeak) &&
                        input.value.match(regExpStrong)))) no = 2;
        if (input.value.length >= 6 &&
            input.");
            WriteLiteral(@"value.match(regExpWeak) &&
            input.value.match(regExpMedium) && input.value.match(regExpStrong)) no = 3;
        if (no == 1) {
            weak.classList.add(""active"");
            text.style.display = ""block"";
            text.textContent = ""Mật Khẩu Bạn Yếu"";
            text.classList.add(""weak"");
        }
        if (no == 2) {
            medium.classList.add(""active"");
            text.textContent = ""Mật Khẩu Bạn Bình Thường"";
            text.classList.add(""medium"");
        } else {
            medium.classList.remove(""active"");
            text.classList.remove(""medium"");
        }
        if (no == 3) {
            weak.classList.add(""active"");
            medium.classList.add(""active"");
            strong.classList.add(""active"");
            text.textContent = ""Mật Khẩu Bạn  Mạnh"";
            text.classList.add(""strong"");
        } else {
            strong.classList.remove(""active"");
            text.classList.remove(""strong"");
        }        
    } 
    e");
            WriteLiteral("lse {\r\n        indicator.style.display = \"none\";\r\n        text.style.display = \"none\";        \r\n    }\r\n}\r\n\r\n</script>\r\n\r\n");
#nullable restore
#line 196 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Views\User\DangKy.cshtml"
  
    ViewData["Title"] = "DangKy";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c738cf332653c6ec51fb12f61db9122e612c2f9904", async() => {
                WriteLiteral("\r\n                                    <div class=\"container\" id=\"container\">\r\n                                        <div class=\"form-container sign-in-container\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c738cf332653c6ec51fb12f61db9122e612c2f10380", async() => {
                    WriteLiteral(@"
                                             <div>
                                                <h1>
                                                    Đăng ký
                                                </h1>
                                                <label for=""Fullname""></label><input style="" background-color: #eee; border: none; padding: 12px 15px; margin: 8px 0; width: 100%;"" required type=""text"" placeholder=""Tên đăng nhập"" name=""fullname"" />
                                                <label for=""Email""></label><input style="" background-color: #eee; border: none; padding: 12px 15px; margin: 8px 0; width: 100%;"" required type=""email"" placeholder=""Nhập email"" name=""email"" />
                                                <label for=""Password""></label><input class=""password""  style="" background-color: #eee; border: none; padding: 12px 15px; margin: 8px 0; width: 100%;"" onkeyup=""trigger()"" required type=""password"" placeholder=""Nhập password"" name=""password""  />             
     ");
                    WriteLiteral(@"                                        </div>   
                                             <div class=""indicator"">
                                              <span class=""yeu""></span>
                                              <span class=""binh-thuong""></span>
                                              <span class=""manh""></span>
                                             </div>
                                             <div class=""text""></div>
                                             <div>
                                                <button type=""submit"" name=""submit"">Đăng ký </button>
                                             </div>                
                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""overlay-container"">
                                            <div class=""overlay"">
                                                <div class=""overlay-panel overlay-right"">
                                                    <h1>Hello!</h1>
                                                    <p>Bạn đã có tài khoản</p>
                                                    <button class=""ghost""");
                BeginWriteAttribute("onclick", " onclick=\"", 7886, "\"", 7943, 3);
                WriteAttributeValue("", 7896, "location.href=\'", 7896, 15, true);
#nullable restore
#line 226 "E:\Bảo mật web và ứng dụng\Đồ án\Web_ShoesLover\Views\User\DangKy.cshtml"
WriteAttributeValue("", 7911, Url.Action("DangNhap", "User"), 7911, 31, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7942, "\'", 7942, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Đăng nhập</button>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                     </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
