#pragma checksum "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\Shared\Components\Brds\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b4c27e9c86a3509f6f9a98c14aee8f6b78d2c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Brds_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Brds/Default.cshtml")]
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
#line 1 "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\_ViewImports.cshtml"
using Lesson1_Task1_MiddleWare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b4c27e9c86a3509f6f9a98c14aee8f6b78d2c6", @"/Views/Shared/Components/Brds/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5b9d6cb4fa88c8ce934f4267b363cbb6f247f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Brds_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lesson1_Task1_MiddleWare.Models.BrandViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"brands_products\">\n    <!--brands_products-->\n    <h2>Брэнды</h2>\n    <div class=\"brands-name\">\n        <ul class=\"nav nav-pills nav-stacked\">\n");
#nullable restore
#line 8 "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\Shared\Components\Brds\Default.cshtml"
             foreach (var brand in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b4c27e9c86a3509f6f9a98c14aee8f6b78d2c64317", async() => {
                WriteLiteral(" <span class=\"pull-right\">(");
#nullable restore
#line 10 "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\Shared\Components\Brds\Default.cshtml"
                                                                                                                      Write(brand.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</span>");
#nullable restore
#line 10 "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\Shared\Components\Brds\Default.cshtml"
                                                                                                                                          Write(brand.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-BrandId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\Shared\Components\Brds\Default.cshtml"
                                                                         WriteLiteral(brand.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BrandId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-BrandId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BrandId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 11 "F:\Образование\GeekBrains\C# ASP.NET Core. Уровень 1\Repositories\HomeWorks\Lesson1_Task1_MiddleWare\Lesson1_Task1_MiddleWare\Views\Shared\Components\Brds\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n</div><!--/brands_products-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lesson1_Task1_MiddleWare.Models.BrandViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591