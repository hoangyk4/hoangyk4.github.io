#pragma checksum "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "015f3ed5711782e3f8c619b077bbb8af49acf8b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\_ViewImports.cshtml"
using TodoListApp.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\_ViewImports.cshtml"
using TodoListApp.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015f3ed5711782e3f8c619b077bbb8af49acf8b0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d1c3396bc20ad4a3329ee71f281e63ed8f34fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015f3ed5711782e3f8c619b077bbb8af49acf8b06075", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 246, "\"", 256, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 282, "\"", 292, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <link rel=""stylesheet"" href=""style/style.css"">
    <title>TodoList App</title>
    <!-- Custom fonts for this template -->
    <link href=""style/vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i""
          rel=""stylesheet"">

    <!-- Custom styles for this template -->
    <link href=""style/css/sb-admin-2.min.css"" rel=""stylesheet"">

    <!-- Custom styles for this page -->
    <link href=""style/vendor/datatables/dataTables.bootstrap4.min.css"" rel=""stylesheet"">

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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015f3ed5711782e3f8c619b077bbb8af49acf8b08246", async() => {
                WriteLiteral(@"

    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">
        <!-- Main Content -->
        <div id=""content"">

            <!-- Topbar -->
            <nav class=""navbar navbar-expand navbar-dark bg-dark topbar mb-4 static-top shadow"">
                <a class=""navbar-brand"" href=""index.html"">Todo List App</a>
                <!-- Sidebar Toggle (Topbar) -->
                <!-- Topbar Navbar -->
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015f3ed5711782e3f8c619b077bbb8af49acf8b08965", async() => {
                    WriteLiteral("\n                    <button id=\"sidebarToggleTop\" class=\"btn btn-link d-md-none rounded-circle mr-3\">\n                        <i class=\"fa fa-bars\"></i>\n                    </button>\n                ");
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
                <ul class=""navbar-nav ml-auto"">

                    <!-- Nav Item - Search Dropdown (Visible Only XS) -->
                    <li class=""nav-item dropdown no-arrow d-sm-none"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-search fa-fw""></i>
                        </a>
                        <!-- Dropdown - Messages -->
                        <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                             aria-labelledby=""searchDropdown"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015f3ed5711782e3f8c619b077bbb8af49acf8b011302", async() => {
                    WriteLiteral(@"
                                <div class=""input-group"">
                                    <input type=""text"" class=""form-control bg-light border-0 small""
                                           placeholder=""Tìm kiếm..."" aria-label=""Search""
                                           aria-describedby=""basic-addon2"">
                                    <div class=""input-group-append"">
                                        <button class=""btn btn-primary"" type=""button"">
                                            <i class=""fas fa-search fa-sm""></i>
                                        </button>
                                    </div>
                                </div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </li>

                    <!-- Nav Item - Alerts -->
                    <li class=""nav-item dropdown no-arrow mx-1"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-bell fa-fw""></i>
                            <!-- Counter - Alerts -->
                            <span class=""badge badge-danger badge-counter"">3+</span>
                        </a>
                        <!-- Dropdown - Alerts -->
                        <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                             aria-labelledby=""alertsDropdown"">
                            <h6 class=""dropdown-header"">
                                Thông báo
                            </h6>
                            <a class=""dropdown-item d-flex align-item");
                WriteLiteral(@"s-center"" href=""#"">
                                <div class=""mr-3"">
                                    <div class=""icon-circle bg-primary"">
                                        <i class=""fas fa-file-alt text-white""></i>
                                    </div>
                                </div>
                                <div>
                                    <div class=""small text-gray-500"">June 16, 2021</div>
                                    <span class=""font-weight-bold"">Chào ngày mới! Hãy cập nhật tin bạn có thể đã bỏ qua.</span>
                                </div>
                            </a>
                            <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                <div class=""mr-3"">
                                    <div class=""icon-circle bg-success"">
                                        <i class=""fas fa-donate text-white""></i>
                                    </div>
                                </div>
            ");
                WriteLiteral(@"                    <div>
                                    <div class=""small text-gray-500"">June 16, 2021</div>
                                    Sắp tới sinh nhật, bạn đã chuẩn bị gì chưa?
                                </div>
                            </a>
                            <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                <div class=""mr-3"">
                                    <div class=""icon-circle bg-warning"">
                                        <i class=""fas fa-exclamation-triangle text-white""></i>
                                    </div>
                                </div>
                                <div>
                                    <div class=""small text-gray-500"">June 15, 2021</div>
                                    Tài khoản của bạn có thể đã bị truy cập trái phép.
                                </div>
                            </a>
                            <a class=""dropdown-item text-center small text-gray-5");
                WriteLiteral(@"00"" href=""#"">Hiển thị tất cả</a>
                        </div>
                    </li>

                    <!-- Nav Item - Messages -->
                    <li class=""nav-item dropdown no-arrow mx-1"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-envelope fa-fw""></i>
                            <!-- Counter - Messages -->
                            <span class=""badge badge-danger badge-counter"">2</span>
                        </a>
                        <!-- Dropdown - Messages -->
                        <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                             aria-labelledby=""messagesDropdown"">
                            <h6 class=""dropdown-header"">
                                Hộp Thư
                            </h6>
                          ");
                WriteLiteral(@"  <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                <div class=""dropdown-list-image mr-3"">
                                    <img class=""rounded-circle"" src=""style/img/undraw_profile_1.svg""
                                         alt=""..."">
                                    <div class=""status-indicator bg-success""></div>
                                </div>
                                <div class=""font-weight-bold"">
                                    <div class=""text-truncate"">Xin chào. Đây là tin nhắn từ Hệ thống. Bạn đã truy cập từ Hà Nội</div>
                                    <div class=""small text-gray-500"">Amdin · 10m</div>
                                </div>
                            </a>
                            <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                <div class=""dropdown-list-image mr-3"">
                                    <img class=""rounded-circle"" src=""style/img/undraw_profile_2.sv");
                WriteLiteral(@"g""
                                         alt=""..."">
                                    <div class=""status-indicator""></div>
                                </div>
                                <div>
                                    <div class=""text-truncate"">
                                        Tôi có một lời nhắn cho bạn. Tối này, trận bóng đá giữa ĐT Bồ Đào Nha gặp
                                        ĐT Pháp được truyền hình trực tiếp trên VTV3
                                    </div>
                                    <div class=""small text-gray-500"">C.Ronaldo · 1d</div>
                                </div>
                            </a>
                            <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Tất cả tin nhắn</a>
                        </div>
                    </li>

                    <div class=""topbar-divider d-none d-sm-block""></div>

                    <!-- Nav Item - User Information -->
                    <li class=""nav-item dropdown");
                WriteLiteral(@" no-arrow"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Hoàng Nguyễn Xuân</span>
                            <img class=""img-profile rounded-circle""
                                 src=""style/img/undraw_profile.svg"">
                        </a>
                        <!-- Dropdown - User Information -->
                        <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                             aria-labelledby=""userDropdown"">
                            <a class=""dropdown-item"" href=""admin.html"">
                                <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                                Quản Lý
                            </a>
                            <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data");
                WriteLiteral(@"-target=""#userModal"">
                                <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                                Tài khoản
                            </a>
                            <a class=""dropdown-item"" href=""#"">
                                <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                                Cài đặt
                            </a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                Đăng xuất
                            </a>
                        </div>
                    </li>

                </ul>

            </nav>
            <!-- End of Topbar -->
            <!-- Begin Page Content -->
            <div class=""container-fluid"">
                <!-- Page Heading -->
     ");
                WriteLiteral("           <div class=\"rowheader\">\n                    <h1>Todolist MVC App</h1>\n                </div>\n\n                <div class=\"text-center\">\n                    <button type=\"button\" class=\"btn btn-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 11540, "\"", 11595, 3);
                WriteAttributeValue("", 11550, "location.href=\'", 11550, 15, true);
#nullable restore
#line 208 "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 11565, Url.Action("Index", "Tasks"), 11565, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11594, "\'", 11594, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Home</button> |\n                    <button type=\"button\" class=\"btn btn-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 11675, "\"", 11730, 3);
                WriteAttributeValue("", 11685, "location.href=\'", 11685, 15, true);
#nullable restore
#line 209 "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 11700, Url.Action("Index", "Tasks"), 11700, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11729, "\'", 11729, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Tasks</button> |\n                    <button type=\"button\" class=\"btn btn-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 11811, "\"", 11871, 3);
                WriteAttributeValue("", 11821, "location.href=\'", 11821, 15, true);
#nullable restore
#line 210 "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 11836, Url.Action("Index", "Categories"), 11836, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11870, "\'", 11870, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Categories</button>\n                </div>\n\n\n                ");
#nullable restore
#line 214 "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <!-- /.container-fluid -->
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- DELETE MODAL -->
    <div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Thông báo</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">Bạn muốn xoá item này?</div>
                <div class=""modal-footer"">
                    <a class=""btn btn-primary"" href=""index.html"">Đồng ý</a>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Huỷ bỏ</butt");
                WriteLiteral(@"on>
                </div>
            </div>
        </div>
    </div>
    <!-- End of Funciton Delete -->
    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Thông báo</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Bạn muốn Đăng xuất?</div>
                <div class=""modal-footer"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015f3ed5711782e3f8c619b077bbb8af49acf8b026525", async() => {
                    WriteLiteral("Đăng xuất");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Huỷ bỏ</button>
                </div>
            </div>
        </div>
    </div>
    <!-- Footer -->
    <footer class=""sticky-footer bg-white"">
        <div class=""container my-auto"">
            <div class=""copyright text-center my-auto"">
                <span>&copy; Hoang Harry, June 23, 2021</span>
            </div>
        </div>
    </footer>
    <!-- End of Footer -->
    <!-- Bootstrap core JavaScript-->
    <script src=""style/vendor/jquery/jquery.min.js""></script>
    <script src=""style/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""style/vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""style/js/sb-admin-2.min.js""></script>
    <script src=""style/js/sb-admin-2.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015f3ed5711782e3f8c619b077bbb8af49acf8b028772", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 277 "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- Page level plugins -->
    <script src=""style/vendor/datatables/jquery.dataTables.min.js""></script>
    <script src=""style/vendor/datatables/dataTables.bootstrap4.min.js""></script>

    <!-- Page level custom scripts -->
    <script src=""style/js/demo/datatables-demo.js""></script>
    ");
#nullable restore
#line 284 "D:\ProjectHoang\hoangyk4.github.io\TodoListApp.WebApp\TodoListApp.WebApp\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
