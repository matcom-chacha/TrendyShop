#pragma checksum "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7a6dd3425017c3dd6792e89ce44fd97c8f1fc38"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7a6dd3425017c3dd6792e89ce44fd97c8f1fc38", @"/Views/Buy/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Buy_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrendyShop.ViewModels.BuyViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
  
    ViewData["Title"] = "Compra";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-lg-5 mx-auto mt-4\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"card-title border-bottom\">Compra de ");
#nullable restore
#line 10 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
                                                      Write(Model.Add.Article.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 11 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
             using (Html.BeginForm("EffectBuy", "Buy", new { aid = @Model.Add.ArticleId, uid = @Model.Add.UserId, card = @Model.Card, amountToBuy = @Model.AmountToBuy }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 14 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
               Write(Html.LabelFor(m => m.AmountToBuy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 15 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
               Write(Html.TextBoxFor(m => m.AmountToBuy, new { @class = "form-control", @id = "amount" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
               Write(Html.ValidationMessageFor(m => m.AmountToBuy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 20 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
               Write(Html.LabelFor(m => m.Card));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
               Write(Html.TextBoxFor(m => m.Card, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
               Write(Html.ValidationMessageFor(m => m.Card));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-flex\">\r\n                    <button type=\"submit\" class=\"btn btn-secondary ml-auto\">Comprar</button>\r\n                </div>\r\n");
#nullable restore
#line 27 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Buy\Buy.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n    document.getElementById(\"amount\").select();\r\n</script>");
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
