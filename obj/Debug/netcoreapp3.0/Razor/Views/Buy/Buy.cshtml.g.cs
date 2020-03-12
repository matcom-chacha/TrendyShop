#pragma checksum "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a691d62b8a1296beb5456162988db7cd8043f810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buy_Buy), @"mvc.1.0.view", @"/Views/Buy/Buy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a691d62b8a1296beb5456162988db7cd8043f810", @"/Views/Buy/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Buy_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrendyShop.ViewModels.BuyViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
  
    ViewData["Title"] = "Compra";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Para efectuar su compra rellene los puntos siguientes:</h1>\r\n");
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
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                        <a class=""dropdown-item"" ");
            WriteLiteral(@"href=""/Add/NewAdd"">Anunciar</a>
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
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/Home/Contact"">Co");
            WriteLiteral(@"ntáctanos</a>
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

");
#nullable restore
#line 62 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
 using (Html.BeginForm("EffectBuy", "Buy", new { aid = @Model.Add.ArticleId, uid = @Model.Add.UserId, card = @Model.Card, amountToBuy = @Model.AmountToBuy }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 65 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
   Write(Html.LabelFor(m => m.AmountToBuy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 66 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
   Write(Html.TextBoxFor(m => m.AmountToBuy, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 67 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
   Write(Html.ValidationMessageFor(m => m.AmountToBuy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\" form-group\">\r\n        ");
#nullable restore
#line 71 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
   Write(Html.LabelFor(m => m.Card));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 72 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
   Write(Html.TextBoxFor(m => m.Card, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 73 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
   Write(Html.ValidationMessageFor(m => m.Card));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\" btn btn-primary\">Comprar</button>\r\n");
#nullable restore
#line 77 "C:\Users\Gabriela\source\repos\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrendyShop.ViewModels.BuyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
