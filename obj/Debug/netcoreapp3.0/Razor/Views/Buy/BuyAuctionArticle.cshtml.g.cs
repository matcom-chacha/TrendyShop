#pragma checksum "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "412fb00cf27dacf2dad38c68143f92e266e1eea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buy_BuyAuctionArticle), @"mvc.1.0.view", @"/Views/Buy/BuyAuctionArticle.cshtml")]
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
#line 1 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\_ViewImports.cshtml"
using TrendyShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"412fb00cf27dacf2dad38c68143f92e266e1eea4", @"/Views/Buy/BuyAuctionArticle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Buy_BuyAuctionArticle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrendyShop.ViewModels.BuyAuctionArticleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""col-lg-5 mx-auto mt-4"">
    <div class=""card"">
        <div class=""card-body"">
            <h5 class=""card-title border-bottom"">Felicidades por su reciente apuesta ganadora.</h5>
            <h5 class=""card-title border-bottom"">Llegó la hora de adquirir su ");
#nullable restore
#line 11 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
                                                                         Write(Model.Auction.Article.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 12 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
             using (Html.BeginForm("EffectAuctionBuy", "Buy", FormMethod.Post, new { id = "bform" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 15 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
               Write(Html.LabelFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
               Write(Html.TextBoxFor(m => m.Address, new { @class = "form-control", @id = "address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
               Write(Html.ValidationMessageFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""d-flex"">
                    <button class=""btn btn-secondary ml-auto"" type=""button"" data-toggle=""modal"" data-target=""#confirmodal"">Realizar pedido</button>
                    <button class=""btn btn-dark ml-1"" type=""button"" onclick=""location.pathname='/Add'"">Cancelar</button>
                </div>
");
#nullable restore
#line 25 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
           Write(Html.HiddenFor(m => m.Auction.UserId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
           Write(Html.HiddenFor(m => m.Auction.ArticleId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
           Write(Html.HiddenFor(m => m.Auction.Article.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
           Write(Html.HiddenFor(m => m.Auction.Article.Price));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
           Write(Html.HiddenFor(m => m.CustomerId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\BuyAuctionArticle.cshtml"
                                                  
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""modal fade"" id=""confirmodal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ConfirmationModal"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""ConfirmationModalLongTitle"">¿Está seguro que desea realizar esta compra?</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h5>Se aplicará un extra por el envio.</h5>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary ml-auto"" onclick=""finishOperation()"">Continuar</button>
                <button class=""btn btn-dark ml-1"" data-dismiss=""modal"">Cancelar</button>
            </div>
        </div");
            WriteLiteral(@">
    </div>
</div>

<script>
    var shippingCharge = 0;

    document.getElementById(""amount"").select();
    
    function validateForm() {
        var address = document.getElementById('address').value;

        if (address == """" || address == null){
            alert(""Por favor especifique una dirección a la cual enviar su más reciente adquisición."");
            return false;
        }

        return true;
    }

    function finishOperation() {
        isvalid = validateForm();
        if (isvalid) {
            saveShippingCharge();
            submitForm();
        }
    }

    function submitForm() {
        document.getElementById('bform').submit();
    }

    function saveShippingCharge() {
        shippingCharge = Math.floor((Math.random() * 10) + 1);

        form = document.getElementById('bform');

        var input = document.createElement(""INPUT"");
        input.setAttribute(""type"", ""hidden"");
        input.setAttribute(""value"", shippingCharge);
      ");
            WriteLiteral("  input.setAttribute(\"name\", \"ShippingCharge\");\r\n        form.appendChild(input);\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrendyShop.ViewModels.BuyAuctionArticleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591