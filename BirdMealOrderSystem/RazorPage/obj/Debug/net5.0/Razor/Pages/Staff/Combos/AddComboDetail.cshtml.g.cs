#pragma checksum "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cacab78bf7f297e11032e9f08d9e9988c11d8791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPage.Pages.Staff.Combos.Pages_Staff_Combos_AddComboDetail), @"mvc.1.0.razor-page", @"/Pages/Staff/Combos/AddComboDetail.cshtml")]
namespace RazorPage.Pages.Staff.Combos
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
#line 1 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\_ViewImports.cshtml"
using RazorPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cacab78bf7f297e11032e9f08d9e9988c11d8791", @"/Pages/Staff/Combos/AddComboDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ab4f57d421e7a740b1d5664c5e40e4f30e7bfe", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Staff_Combos_AddComboDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "BuyNow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
  
    Layout = "LayoutStaff";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Product List</h3>\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Image</th>\r\n        <th>Name</th>\r\n        <th>Max Quantity</th>\r\n        <th>Price</th>\r\n        <th>Discount</th>\r\n        <th>Description</th>\r\n        <th>Supllier</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr align=\"center\">\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cacab78bf7f297e11032e9f08d9e9988c11d87915486", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 458, "~/uploads/", 458, 10, true);
#nullable restore
#line 20 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
AddHtmlAttributeValue("", 468, product.ImageLink, 468, 18, false);

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
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
           Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
           Write(product.UnitInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
           Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
           Write(product.ProductDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (%)</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
           Write(product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
           Write(product.Supplier.SupplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cacab78bf7f297e11032e9f08d9e9988c11d87919211", async() => {
                WriteLiteral("Add to combo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
                                                                   WriteLiteral(product.ProductId);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Admin\OneDrive\Máy tính\CN7 Summer 2023\PRN221\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\AddComboDetail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPage.Pages.Staff.Combos.AddComboDetailModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.Staff.Combos.AddComboDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.Staff.Combos.AddComboDetailModel>)PageContext?.ViewData;
        public RazorPage.Pages.Staff.Combos.AddComboDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
