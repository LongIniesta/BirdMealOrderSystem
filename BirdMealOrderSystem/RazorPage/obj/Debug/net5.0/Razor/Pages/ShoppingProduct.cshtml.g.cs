#pragma checksum "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77c47c0d6efe38097d304dfbd76528427d08a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPage.Pages.Pages_ShoppingProduct), @"mvc.1.0.razor-page", @"/Pages/ShoppingProduct.cshtml")]
namespace RazorPage.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77c47c0d6efe38097d304dfbd76528427d08a03", @"/Pages/ShoppingProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ab4f57d421e7a740b1d5664c5e40e4f30e7bfe", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_ShoppingProduct : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Customer/CustomerCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "BuyNow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-type", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ProductDetailView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
  
    if (SessionHelper.checkPermission(HttpContext.Session, "customer"))
    {
        Layout = "LayoutCustomer";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Product Shopping</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77c47c0d6efe38097d304dfbd76528427d08a036026", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"strsearch\" />\r\n    <input type=\"submit\" name=\"search\" />\r\n    <div class=\"form-group\">\r\n");
#nullable restore
#line 14 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
         for (var i = 0; i < Model.listCategory.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-check\">\r\n                <input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 521, "\"", 533, 2);
                WriteAttributeValue("", 526, "item-", 526, 5, true);
#nullable restore
#line 17 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
WriteAttributeValue("", 531, i, 531, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"selectedItems\"");
                BeginWriteAttribute("value", " value=\"", 555, "\"", 596, 1);
#nullable restore
#line 17 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
WriteAttributeValue("", 563, Model.listCategory[i].CategoryId, 563, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 647, "\"", 660, 2);
                WriteAttributeValue("", 653, "item-", 653, 5, true);
#nullable restore
#line 18 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
WriteAttributeValue("", 658, i, 658, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
#nullable restore
#line 19 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
               Write(Model.listCategory[i].CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n");
#nullable restore
#line 22 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Image</th>\r\n        <th>Name</th>\r\n        <th>Price</th>\r\n        <th>Discount</th>\r\n        <th>Description</th>\r\n        <th>Supllier</th>\r\n        <th>Price after discounted</th>\r\n    </tr>\r\n");
#nullable restore
#line 35 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr align=\"center\">\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a77c47c0d6efe38097d304dfbd76528427d08a0310645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1144, "~/uploads/", 1144, 10, true);
#nullable restore
#line 38 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
AddHtmlAttributeValue("", 1154, product.ImageLink, 1154, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
           Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
           Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
           Write(product.ProductDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (%)</td>\r\n            <td>");
#nullable restore
#line 42 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
           Write(product.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
           Write(product.Supplier.SupplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
            Write((double)product.UnitPrice - (((double)product.UnitPrice)*product.ProductDiscount/100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77c47c0d6efe38097d304dfbd76528427d08a0314218", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
                                                                                  WriteLiteral(product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-type", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a77c47c0d6efe38097d304dfbd76528427d08a0317237", async() => {
                WriteLiteral("View detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
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
#line 52 "E:\Tailieu\Ki7\PRN221\group\PROJECT\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\ShoppingProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPage.Pages.ShoppingProductModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.ShoppingProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.ShoppingProductModel>)PageContext?.ViewData;
        public RazorPage.Pages.ShoppingProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
