#pragma checksum "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03d1c90791ca6e4e59b8718ec761f0c7463f63a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPage.Pages.Admin.Combos.Pages_Admin_Combos_Details), @"mvc.1.0.razor-page", @"/Pages/Admin/Combos/Details.cshtml")]
namespace RazorPage.Pages.Admin.Combos
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
#line 1 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\_ViewImports.cshtml"
using RazorPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
using BussinessObject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d1c90791ca6e4e59b8718ec761f0c7463f63a9", @"/Pages/Admin/Combos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ab4f57d421e7a740b1d5664c5e40e4f30e7bfe", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Combos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Combo</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.ComboName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.ComboName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.Ratingavg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.Ratingavg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.ComboDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.ComboDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.ComboStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.ComboStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n\r\n    <h3>Combo details:</h3>\r\n    <div>\r\n");
#nullable restore
#line 57 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
         foreach(var item in Model.ComboDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03d1c90791ca6e4e59b8718ec761f0c7463f63a99995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1788, "~/uploads/", 1788, 10, true);
#nullable restore
#line 61 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
AddHtmlAttributeValue("", 1798, item.Product.ImageLink, 1798, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </dt>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 64 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
               Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 67 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n");
#nullable restore
#line 70 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d1c90791ca6e4e59b8718ec761f0c7463f63a912756", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
                           WriteLiteral(Model.Combo.ComboId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d1c90791ca6e4e59b8718ec761f0c7463f63a914948", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 78 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
     foreach (OrderComboDetail d in Model.orderComboDetails)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>\r\n            ");
#nullable restore
#line 81 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(d.Order.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h4>\r\n        <h5>\r\n            ");
#nullable restore
#line 84 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(d.Feedback);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h5>\r\n        <h6>\r\n            ");
#nullable restore
#line 87 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
       Write(d.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sao\r\n        </h6>\r\n        <br />\r\n");
#nullable restore
#line 90 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Combos\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPage.Pages.Admin.Combos.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.Admin.Combos.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.Admin.Combos.DetailsModel>)PageContext?.ViewData;
        public RazorPage.Pages.Admin.Combos.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
