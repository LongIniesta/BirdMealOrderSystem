#pragma checksum "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3223832f6db8fdb3db3ff7fd0c7f71111569c6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPage.Pages.Admin.Orders.Pages_Admin_Orders_Details), @"mvc.1.0.razor-page", @"/Pages/Admin/Orders/Details.cshtml")]
namespace RazorPage.Pages.Admin.Orders
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
#line 1 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\_ViewImports.cshtml"
using RazorPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3223832f6db8fdb3db3ff7fd0c7f71111569c6f", @"/Pages/Admin/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2471cb8afb3db95b1096a614cb23e71f131abd5a", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Orders_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/back-icon-3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight: 500; color: #5A5A5A; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"d-flex justify-content-between\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3223832f6db8fdb3db3ff7fd0c7f71111569c6f5266", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3223832f6db8fdb3db3ff7fd0c7f71111569c6f5527", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <div>\n    </div>\n    <div>\n    </div>\n</div>\n<div class=\"d-flex justify-content-center\">\n    <span class=\"mx-2 span-custom\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3223832f6db8fdb3db3ff7fd0c7f71111569c6f7734", async() => {
                WriteLiteral("Orders");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span>
    <span> / </span>
    <span class=""mx-2"" style=""font-weight: 500; color: #000;"">Details</span>
</div>
<h1 class=""text-center mt-5 mb-5"">DETAILS</h1>


<div class=""card shadow p-3 mb-5 bg-white rounded"" style=""margin: 0 200px 0 200px;"">
    <h4>Order</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 31 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 34 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 37 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 40 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 43 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.OrdeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 46 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.OrdeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 49 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 52 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 55 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 58 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 61 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Paymentmethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 64 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.Paymentmethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 67 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.PaymentStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 70 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.PaymentStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 73 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 76 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.User.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3223832f6db8fdb3db3ff7fd0c7f71111569c6f14947", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
                           WriteLiteral(Model.Order.OrderId);

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
            WriteLiteral(" \n</div>\n\n");
#nullable restore
#line 82 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
 if(Model.orderComboDetails != null && Model.orderComboDetails.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n");
#nullable restore
#line 84 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
         foreach (var item in Model.orderComboDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dl class=\"row\">\n                <dt class=\"col-sm-2\">\n                    Combo ");
#nullable restore
#line 88 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
                     Write(item.Combo.ComboName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    Quantity: ");
#nullable restore
#line 91 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
                         Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dd class=\"col-sm-10\">\n                    Unit price after discounted: ");
#nullable restore
#line 94 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
                                             Write( ((double) item.UnitPrice)-  ((double)item.UnitPrice*item.Discount/100));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n            </dl>\n");
#nullable restore
#line 97 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 99 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
 if (Model.orderProductDetails != null && Model.orderProductDetails.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n");
#nullable restore
#line 103 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
         foreach (var item in Model.orderProductDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dl class=\"row\">\n                <dt class=\"col-sm-2\">\n                    Combo ");
#nullable restore
#line 107 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
                     Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    Quantity: ");
#nullable restore
#line 110 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
                         Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dd class=\"col-sm-10\">\n                    Unit price after discounted: ");
#nullable restore
#line 113 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
                                             Write(((double)item.UnitPrice) - ((double)item.UnitPrice * item.Discount / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n            </dl>\n");
#nullable restore
#line 116 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 118 "E:\Tailieu\Ki7\PRN221\group\BirdMealOrderSystem\BirdMealOrderSystem\RazorPage\Pages\Admin\Orders\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPage.Pages.Admin.Orders.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.Admin.Orders.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.Admin.Orders.DetailsModel>)PageContext?.ViewData;
        public RazorPage.Pages.Admin.Orders.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
