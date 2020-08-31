#pragma checksum "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\Store\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a8a4731ccd5839f60b1362afc5302a8d343b7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Checkout), @"mvc.1.0.view", @"/Views/Store/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a8a4731ccd5839f60b1362afc5302a8d343b7af", @"/Views/Store/Checkout.cshtml")]
    public class Views_Store_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cart/one.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cart/two.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cart/three.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\Store\Checkout.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""cart_items"">
    <div class=""container"">
        <div class=""breadcrumbs"">
            <ol class=""breadcrumb"">
                <li><a href=""#"">Home</a></li>
                <li class=""active"">Check out</li>
            </ol>
        </div><!--/breadcrums-->

        <div class=""step-one"">
            <h2 class=""heading"">Step1</h2>
        </div>
        <div class=""checkout-options"">
            <h3>New User</h3>
            <p>Checkout options</p>
            <ul class=""nav"">
                <li>
                    <label><input type=""checkbox""> Register Account</label>
                </li>
                <li>
                    <label><input type=""checkbox""> Guest Checkout</label>
                </li>
                <li>
                    <a");
            BeginWriteAttribute("href", " href=\"", 800, "\"", 807, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-times""></i>Cancel</a>
                </li>
            </ul>
        </div><!--/checkout-options-->

        <div class=""register-req"">
            <p>Please use Register And Checkout to easily get access to your order history, or use Checkout as Guest</p>
        </div><!--/register-req-->

        <div class=""shopper-informations"">
            <div class=""row"">
                <div class=""col-sm-3"">
                    <div class=""shopper-info"">
                        <p>Shopper Information</p>
                        <form>
                            <input type=""text"" placeholder=""Display Name"">
                            <input type=""text"" placeholder=""User Name"">
                            <input type=""password"" placeholder=""Password"">
                            <input type=""password"" placeholder=""Confirm password"">
                        </form>
                        <a class=""btn btn-primary""");
            BeginWriteAttribute("href", " href=\"", 1747, "\"", 1754, 0);
            EndWriteAttribute();
            WriteLiteral(">Get Quotes</a>\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1821, "\"", 1828, 0);
            EndWriteAttribute();
            WriteLiteral(@">Continue</a>
                    </div>
                </div>
                <div class=""col-sm-5 clearfix"">
                    <div class=""bill-to"">
                        <p>Bill To</p>
                        <div class=""form-one"">
                            <form>
                                <input type=""text"" placeholder=""Company Name"">
                                <input type=""text"" placeholder=""Email*"">
                                <input type=""text"" placeholder=""Title"">
                                <input type=""text"" placeholder=""First Name *"">
                                <input type=""text"" placeholder=""Middle Name"">
                                <input type=""text"" placeholder=""Last Name *"">
                                <input type=""text"" placeholder=""Address 1 *"">
                                <input type=""text"" placeholder=""Address 2"">
                            </form>
                        </div>
                        <div class=""form-two"">
                      ");
            WriteLiteral(@"      <form>
                                <input type=""text"" placeholder=""Zip / Postal Code *"">
                                <select>
                                    <option>-- Country --</option>
                                    <option>United States</option>
                                    <option>Bangladesh</option>
                                    <option>UK</option>
                                    <option>India</option>
                                    <option>Pakistan</option>
                                    <option>Ucrane</option>
                                    <option>Canada</option>
                                    <option>Dubai</option>
                                </select>
                                <select>
                                    <option>-- State / Province / Region --</option>
                                    <option>United States</option>
                                    <option>Bangladesh</option>
                               ");
            WriteLiteral(@"     <option>UK</option>
                                    <option>India</option>
                                    <option>Pakistan</option>
                                    <option>Ucrane</option>
                                    <option>Canada</option>
                                    <option>Dubai</option>
                                </select>
                                <input type=""password"" placeholder=""Confirm password"">
                                <input type=""text"" placeholder=""Phone *"">
                                <input type=""text"" placeholder=""Mobile Phone"">
                                <input type=""text"" placeholder=""Fax"">
                            </form>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-4"">
                    <div class=""order-message"">
                        <p>Shipping Order</p>
                        <textarea name=""message"" placeholder=""Notes about your order, Special Not");
            WriteLiteral(@"es for Delivery"" rows=""16""></textarea>
                        <label><input type=""checkbox""> Shipping to bill address</label>
                    </div>
                </div>
            </div>
        </div>
        <div class=""review-payment"">
            <h2>Review & Payment</h2>
        </div>

        <div class=""table-responsive cart_info"">
            <table class=""table table-condensed"">
                <thead>
                    <tr class=""cart_menu"">
                        <td class=""image"">Item</td>
                        <td class=""description""></td>
                        <td class=""price"">Price</td>
                        <td class=""quantity"">Quantity</td>
                        <td class=""total"">Total</td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td class=""cart_product"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 5854, "\"", 5861, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a8a4731ccd5839f60b1362afc5302a8d343b7af10934", async() => {
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
            WriteLiteral("</a>\n                        </td>\n                        <td class=\"cart_description\">\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 6026, "\"", 6033, 0);
            EndWriteAttribute();
            WriteLiteral(@">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up""");
            BeginWriteAttribute("href", " href=\"", 6432, "\"", 6439, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 6644, "\"", 6651, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 6976, "\"", 6983, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times\"></i></a>\n                        </td>\n                    </tr>\n\n                    <tr>\n                        <td class=\"cart_product\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 7179, "\"", 7186, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a8a4731ccd5839f60b1362afc5302a8d343b7af14039", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n                        </td>\n                        <td class=\"cart_description\">\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 7351, "\"", 7358, 0);
            EndWriteAttribute();
            WriteLiteral(@">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up""");
            BeginWriteAttribute("href", " href=\"", 7757, "\"", 7764, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 7969, "\"", 7976, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 8301, "\"", 8308, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times\"></i></a>\n                        </td>\n                    </tr>\n                    <tr>\n                        <td class=\"cart_product\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 8503, "\"", 8510, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a8a4731ccd5839f60b1362afc5302a8d343b7af17142", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n                        </td>\n                        <td class=\"cart_description\">\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 8677, "\"", 8684, 0);
            EndWriteAttribute();
            WriteLiteral(@">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up""");
            BeginWriteAttribute("href", " href=\"", 9083, "\"", 9090, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 9295, "\"", 9302, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 9627, "\"", 9634, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-times""></i></a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan=""4"">&nbsp;</td>
                        <td colspan=""2"">
                            <table class=""table table-condensed total-result"">
                                <tr>
                                    <td>Cart Sub Total</td>
                                    <td>$59</td>
                                </tr>
                                <tr>
                                    <td>Exo Tax</td>
                                    <td>$2</td>
                                </tr>
                                <tr class=""shipping-cost"">
                                    <td>Shipping Cost</td>
                                    <td>Free</td>
                                </tr>
                                <tr>
                                    <td>Total</td>
                                    <td><span>$61</span></td>
                      ");
            WriteLiteral(@"          </tr>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=""payment-options"">
            <span>
                <label><input type=""checkbox""> Direct Bank Transfer</label>
            </span>
            <span>
                <label><input type=""checkbox""> Check Payment</label>
            </span>
            <span>
                <label><input type=""checkbox""> Paypal</label>
            </span>
        </div>
    </div>
</section> <!--/#cart_items-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591