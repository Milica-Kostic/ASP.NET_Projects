#pragma checksum "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ded689b33cfb27b28053e93dfffde4f18f1f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Delete), @"mvc.1.0.view", @"/Views/Food/Delete.cshtml")]
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
#line 1 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\_ViewImports.cshtml"
using MVCOrderingSystemApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\_ViewImports.cshtml"
using MVCOrderingSystemApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ded689b33cfb27b28053e93dfffde4f18f1f0b", @"/Views/Food/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a904f75f4285a0d07cfd9fcb1ff65968bac422", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantDataLibrary.Models.FoodModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml"
 if (Model is null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>The requested record was not found.</h3>\r\n");
#nullable restore
#line 9 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"h4\">\r\n        Are you sure you want to delete ");
#nullable restore
#line 13 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml"
                                   Write(Model.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("?\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ded689b33cfb27b28053e93dfffde4f18f1f0b5096", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16ded689b33cfb27b28053e93dfffde4f18f1f0b5362", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 16 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml"
                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 488, "\"", 518, 2);
                WriteAttributeValue("", 495, "/Food/Display/", 495, 14, true);
#nullable restore
#line 19 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml"
WriteAttributeValue("", 509, Model.Id, 509, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger\">Cancel</a>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "D:\Projects\RestaurantAPP\MVCOrderingSystemApp\MVCOrderingSystemApp\Views\Food\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantDataLibrary.Models.FoodModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
