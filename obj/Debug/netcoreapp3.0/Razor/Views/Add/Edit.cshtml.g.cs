#pragma checksum "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66415e41e4bb6e6103416ed0e51edfe3a0160ad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Add_Edit), @"mvc.1.0.view", @"/Views/Add/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66415e41e4bb6e6103416ed0e51edfe3a0160ad3", @"/Views/Add/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae704499564c51386f8cbc7db1f8d99c6833b460", @"/Views/_ViewImports.cshtml")]
    public class Views_Add_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrendyShop.ViewModels.EditAddViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<!-- Navigation -->\r\n<div class=\"col-lg-8 mx-auto mt-4\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"card-title border-bottom\">Editar Artículo</h1>\r\n\r\n");
#nullable restore
#line 15 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
             using (Html.BeginForm("SaveEdition", "Add"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 18 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.LabelFor(a => a.Add.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.TextBoxFor(a => a.Add.Article.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.ValidationMessageFor(a => a.Add.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 24 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.LabelFor(a => a.Add.Article.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.TextBoxFor(a => a.Add.Article.Brand, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.ValidationMessageFor(a => a.Add.Article.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 30 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.LabelFor(a => a.Add.Article.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.TextBoxFor(a => a.Add.Article.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.ValidationMessageFor(a => a.Add.Article.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 36 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.LabelFor(a => a.Add.Article.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.TextBoxFor(a => a.Add.Article.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.ValidationMessageFor(a => a.Add.Article.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 42 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.LabelFor(a => a.Add.Article.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 43 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.DropDownListFor(a => a.Add.Article.CategoryId, new SelectList(Model.Categories, "CategoryId", "Name"), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 47 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.LabelFor(a => a.Add.Article.IsNew));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 48 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.CheckBoxFor(a => a.Add.Article.IsNew, new { @class = "checkbox" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 49 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.ValidationMessageFor(a => a.Add.Article.IsNew));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 53 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.LabelFor(a => a.Add.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 54 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.TextBoxFor(a => a.Add.Amount, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 55 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.ValidationMessageFor(a => a.Add.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\" form-group\">\r\n                    ");
#nullable restore
#line 59 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.LabelFor(a => a.Add.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 60 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.TextBoxFor(a => a.Add.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 61 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
               Write(Html.ValidationMessageFor(a => a.Add.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 64 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
           Write(Html.HiddenFor(a => a.Add.UserId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
           Write(Html.HiddenFor(a => a.Add.ArticleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"submit\" class=\" btn btn-dark\">Editar Anuncio</button>\r\n");
#nullable restore
#line 68 "E:\Cibernetics Core\3er Año\+IS+\TrendyShop\TrendyShop\Views\Add\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrendyShop.ViewModels.EditAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591