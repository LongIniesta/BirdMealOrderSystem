#pragma checksum "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06cbf4030494d6579ae1d6e24a5a8ce2df2a4bd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPage.Pages.Staff.Combos.Pages_Staff_Combos_Details), @"mvc.1.0.razor-page", @"/Pages/Staff/Combos/Details.cshtml")]
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
#line 1 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\_ViewImports.cshtml"
using RazorPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
using BussinessObject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06cbf4030494d6579ae1d6e24a5a8ce2df2a4bd8", @"/Pages/Staff/Combos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ab4f57d421e7a740b1d5664c5e40e4f30e7bfe", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Staff_Combos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 5 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "LayoutStaff";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Combo</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.ComboName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.ComboName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.Ratingavg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.Ratingavg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.ComboDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.ComboDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combo.ComboStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combo.ComboStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n\r\n    <h3>Combo details:</h3>\r\n    <div>\r\n");
#nullable restore
#line 56 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
         foreach (var item in Model.ComboDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "06cbf4030494d6579ae1d6e24a5a8ce2df2a4bd89550", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1787, "~/uploads/", 1787, 10, true);
#nullable restore
#line 60 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
AddHtmlAttributeValue("", 1797, item.Product.ImageLink, 1797, 23, false);

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
#line 63 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
               Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 66 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n");
#nullable restore
#line 69 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06cbf4030494d6579ae1d6e24a5a8ce2df2a4bd812207", async() => {
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
#line 73 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06cbf4030494d6579ae1d6e24a5a8ce2df2a4bd814373", async() => {
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
#line 77 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
     foreach (OrderComboDetail d in Model.orderComboDetails)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>\r\n            ");
#nullable restore
#line 80 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(d.Order.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h4>\r\n        <h5>\r\n            ");
#nullable restore
#line 83 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(d.Feedback);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h5>\r\n        <h6>\r\n            ");
#nullable restore
#line 86 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
       Write(d.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sao\r\n        </h6>\r\n        <br />\r\n");
#nullable restore
#line 89 "D:\PRN221\PRN221_GroupProject\BirdMealOrderSystem\RazorPage\Pages\Staff\Combos\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPage.Pages.Staff.Combos.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.Staff.Combos.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPage.Pages.Staff.Combos.DetailsModel>)PageContext?.ViewData;
        public RazorPage.Pages.Staff.Combos.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
