#pragma checksum "E:\Projects\Tranning Hoang\html\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4038eaf32245b61f7cec6f9cda96e88908ca993a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "E:\Projects\Tranning Hoang\html\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\_ViewImports.cshtml"
using TodoListApp.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Tranning Hoang\html\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\_ViewImports.cshtml"
using TodoListApp.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4038eaf32245b61f7cec6f9cda96e88908ca993a", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e0d3f31185703021a62c43bdaff5ecd68a7a58", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Projects\Tranning Hoang\html\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Login -->
<div class=""container"">

    <!-- Outer Row -->
    <div class=""row justify-content-center"">
        <div class=""card o-hidden border-0 shadow-lg my-5"">
            <div class=""card-body p-0"">
                <!-- Nested Row within Card Body -->
                <div class=""row"">
                    <div class=""p-5"">
                        <div class=""text-center"">
                            <h1 class=""h4 text-gray-900 mb-4"">Chào mừng đến với Full House!</h1>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4038eaf32245b61f7cec6f9cda96e88908ca993a4563", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control form-control-user""
                                       id=""exampleInputEmail"" aria-describedby=""emailHelp""
                                       placeholder=""Tài khoản đăng nhập"">
                            </div>
                            <div class=""form-group"">
                                <input type=""password"" class=""form-control form-control-user""
                                       id=""exampleInputPassword"" placeholder=""Mật khẩu"">
                            </div>
                            <div class=""form-group"">
                                <div class=""custom-control custom-checkbox small"">
                                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck"">
                                    <label class=""custom-control-label"" for=""customCheck"">Ghi nhớ</label>
                                </div>
      ");
                WriteLiteral(@"                      </div>
                            <a href=""index.html"" class=""btn btn-primary btn-user btn-block"">
                                Đăng nhập
                            </a>
                            <hr>
                            <a href=""index.html"" class=""btn btn-google btn-user btn-block"">
                                <i class=""fab fa-google fa-fw""></i> Đăng nhập với Google
                            </a>
                            <a href=""index.html"" class=""btn btn-facebook btn-user btn-block"">
                                <i class=""fab fa-facebook-f fa-fw""></i> Đăng nhập với Facebook
                            </a>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <hr>
                        <div class=""text-center"">
                            <a class=""small"" href=""#"">Quên Mật khẩu?</a>
                        </div>
                        <div class=""text-center"">
                            <a class=""small"" href=""#"" data-toggle=""modal"" data-target=""#createModal"">Tạo Tài Khoản!</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- End of Login -->
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
