#pragma checksum "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fa7fe38c18b1985de64c658864105e2ed47d85f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\_ViewImports.cshtml"
using AdminLayout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\_ViewImports.cshtml"
using AdminLayout.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\_ViewImports.cshtml"
using AdminLayout.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fa7fe38c18b1985de64c658864105e2ed47d85f", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e8c963ec16c208c6ecf6231264e63cda66b092", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("  <!-- Start Cart  -->\r\n");
            WriteLiteral(@"<div class=""cart-box-main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""table-main table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>Images</th>
                                <th>Product Name</th>
                                <th>Price</th>
                                <th>Quantity</th>
                                <th>Total</th>
                                <th>Manipulation</th>
                                <th>Manipulation</th>
                            </tr>
                        </thead>
");
#nullable restore
#line 20 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                           decimal grandtotal = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                               int stt = 0;
                                if (ViewBag.carts != null)
                                {
                                    foreach (var item in ViewBag.carts)
                                    {
                                        string txt_class = "quantity_" + item.Product.ProductID;
                                        stt++;
                                        decimal total = item.Product.Price * item.Quantity;
                                        grandtotal += total;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"thumbnail-img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa7fe38c18b1985de64c658864105e2ed47d85f7514", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6fa7fe38c18b1985de64c658864105e2ed47d85f7817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1687, "~/pro/", 1687, 6, true);
#nullable restore
#line 33 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1693, item.Product.Img, 1693, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                                                                            WriteLiteral(item.Product.ProductID);

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
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"name-pr\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa7fe38c18b1985de64c658864105e2ed47d85f11880", async() => {
                WriteLiteral("\r\n                                                ");
#nullable restore
#line 38 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                                                                            WriteLiteral(item.Product.ProductID);

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
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"price-pr\">\r\n                                            <p>");
#nullable restore
#line 42 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                          Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td class=\"quantity-box\"><input type=\"number\"");
            BeginWriteAttribute("class", " class=\"", 2445, "\"", 2463, 1);
#nullable restore
#line 44 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2453, txt_class, 2453, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" size=\"4\"");
            BeginWriteAttribute("value", " value=\"", 2473, "\"", 2495, 1);
#nullable restore
#line 44 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2481, item.Quantity, 2481, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"0\" step=\"1\" class=\"c-input-text qty text\"></td>\r\n                                        <td class=\"total-pr\">\r\n                                            <p>");
#nullable restore
#line 46 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                          Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2766, "\"", 2773, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 48 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                                           Write(item.Product.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"updateCart\">Update</a></td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa7fe38c18b1985de64c658864105e2ed47d85f16935", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                                                                               WriteLiteral(item.Product.ProductID);

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
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                    }
                                }//if
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <h2 style=\"text-align: center;\" class=\"alert alert-danger\">Giỏ hàng trống</h2>      \r\n                                </tr>                                     \r\n");
#nullable restore
#line 58 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                         </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""row my-5"">
            <div class=""col-lg-8 col-sm-12""></div>
            <div class=""col-lg-4 col-sm-12"">
                <div class=""order-box"">
                    <h3>Order summary</h3>
                    <div class=""d-flex"">
                        <h4>Sub Total</h4>
                        <div class=""ml-auto font-weight-bold"">");
#nullable restore
#line 72 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                                           Write(grandtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </div>
                    </div>
                    <hr class=""my-1"">
                    <div class=""d-flex"">
                        <h4>Shipping Cost</h4>
                        <div class=""ml-auto font-weight-bold""> Free </div>
                    </div>
                    <hr>
                    <div class=""d-flex gr-total"">
                        <h5>Grand Total</h5>
                        <div class=""ml-auto h5"">");
#nullable restore
#line 82 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                             Write(grandtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                    </div>\r\n                    <hr>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 87 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
               if (grandtotal == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 d-flex shopping-box\"><a onclick=\"showCheckoutFail(\'Không thể thanh toán\')\" style=\"cursor: pointer; color:white\" class=\"ml-auto btn hvr-hover\">Checkout</a>\r\n                    </div>\r\n");
#nullable restore
#line 91 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 d-flex shopping-box\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 4987, "\"", 5096, 4);
            WriteAttributeValue("", 4997, "showInPopUp(\'", 4997, 13, true);
#nullable restore
#line 94 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5010, Url.Action("CheckoutCart", "Cart", null, Context.Request.Scheme), 5010, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5075, "\',\'Checkout", 5075, 11, true);
            WriteAttributeValue(" ", 5086, "Confirm\')", 5087, 10, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;color: white\" class=\"ml-auto btn hvr-hover\">Checkout</a>\r\n                    </div>\r\n");
#nullable restore
#line 96 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- End Cart -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 104 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
    $(document).ready(function () {
        $("".updateCart"").click(function (event) {
            event.preventDefault();
            var quantity = $("".quantity_"" + $(this).attr(""data-id"")).val();
            console.log(quantity);
            $.ajax({
                type: ""POST"",
                url:""");
#nullable restore
#line 113 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                Write(Url.Action("updateCart","Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                data: {\r\n                    id: $(this).attr(\"data-id\"),\r\n                    quantity:quantity\r\n                },\r\n                success: function (result) {\r\n                    window.location.href = \'");
#nullable restore
#line 119 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Views\Cart\Index.cshtml"
                                       Write(Url.Action("Index","Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                }\r\n            });\r\n        });\r\n    });\r\n\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
