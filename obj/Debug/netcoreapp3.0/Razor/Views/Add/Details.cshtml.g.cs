#pragma checksum "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb87c4a4c97eadc1de309940b0278451920026e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Add_Details), @"mvc.1.0.view", @"/Views/Add/Details.cshtml")]
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
#line 1 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
using TrendyShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb87c4a4c97eadc1de309940b0278451920026e", @"/Views/Add/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Add_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fb87c4a4c97eadc1de309940b0278451920026e3449", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 248, "\"", 258, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 285, "\"", 295, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>Compra Venta (Artículo x)</title>

    <!-- Bootstrap core CSS -->
    <link href=""/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- Custom styles for this template -->
    <link href=""/css/modern-business.css"" rel=""stylesheet"">

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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fb87c4a4c97eadc1de309940b0278451920026e5207", async() => {
                WriteLiteral(@"

    <!-- Navigation -->
    <nav class=""navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""/"">Inicio</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">

                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Anuncios
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfo");
                WriteLiteral(@"lio"">
                            <a class=""dropdown-item"" href=""/Add/NewAdd"">Anunciar</a>
                            <a class=""dropdown-item"" href=""/Add"">Lista de Anuncios</a>
                        </div>
                    </li>

                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Subasta
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                            <a class=""dropdown-item"" href=""/Auction/NewAuction"">Nueva Subasta</a>
                            <a class=""dropdown-item"" href=""/Auction"">Lista de Subastas</a>
                        </div>
                    </li>

                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Home/About"">Acerca de</a>
         ");
                WriteLiteral(@"           </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Home/Contact"">Contáctanos</a>
                    </li>

                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Usuario
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                            <a class=""dropdown-item"" href=""/User/Login"">Entrar</a>
                            <a class=""dropdown-item"" href=""/Home/Register"">Registrar</a>
                        </div>
                    </li>

                </ul>
            </div>
        </div>
    </nav>

    <!-- Page Content -->
    <div class=""container"">

        <!-- Page Heading/Breadcrumbs -->

        <div class=""row"">
            <h");
                WriteLiteral("3 class=\"col-lg-4 mt-4\">");
#nullable restore
#line 84 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
                                 Write(Model.Article.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
                WriteLiteral("            <p>");
#nullable restore
#line 86 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
          Write(Html.ActionLink(Model.UserName, "Details", "User", new { id = Model.UserId }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
        </div>




        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""/Home/Index"">Inicio</a>
            </li>
            <li class=""breadcrumb-item active""><a href=""/Home/Articles"">Artículos</a></li>
            <li class=""breadcrumb-item active"">");
#nullable restore
#line 97 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
                                          Write(Model.Article.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
        </ol>

        <div class=""row"">
            <div class=""col-lg-12 navbar-brand"">Imagen del producto</div>
            <div class=""col-lg-12"">
                <img src=""/images/img1.jpg"" height=""255"" width=""255"">
            </div>
        </div>

        <!-- Article Info -->
        <div class=""row"">
            <div class=""col-lg-12 mb-4"">
                <h4 class=""card-header my-4"">Descripción:</h4>
            </div>

            <div class=""col-lg-12 card-body"">
                <p class=""card-text"">
                    ");
#nullable restore
#line 115 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
               Write(Model.AddDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"col-lg-11 card-footer my-4\">\r\n                <h3>Precio: ");
#nullable restore
#line 120 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
                       Write(Model.Article.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"col-lg-11 card-footer my-4\">\r\n                <h3>Cantidad Disponible: ");
#nullable restore
#line 123 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
                                    Write(Model.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n            </div>\r\n\r\n            <div class=\"col-lg-1 card-footer my-4\">\r\n");
                WriteLiteral("                ");
#nullable restore
#line 128 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
           Write(Html.ActionLink("Comprar", "Buy", "Buy", new { uid = @Model.UserId, aid = @Model.Article.ArticleId }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"col-lg-1 card-footer my-4\">\r\n                ");
#nullable restore
#line 133 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
           Write(Html.ActionLink("Editar", "Edit", "Add", new { aid = @Model.Article.ArticleId, uid = Model.UserId }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n            <div class=\"col-lg-1 card-footer my-4\">\r\n                ");
#nullable restore
#line 138 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Add\Details.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", "Add", new { aid = @Model.Article.ArticleId, uid = @Model.UserId }, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n");
                WriteLiteral(@"
        </div>
        <!-- /.row -->

    </div>
    <!-- /.container -->
    <!-- Footer -->
    <footer class=""py-5 bg-dark"">
        <div class=""container"">
            <p class=""m-0 text-center text-white"">Copyright &copy; Your Website 2019</p>
        </div>
        <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src=""/vendor/jquery/jquery.min.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
