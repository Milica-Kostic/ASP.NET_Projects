#pragma checksum "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ee0c7dd35fabb21a7877dc07f83b578cecfe763"
// <auto-generated/>
#pragma warning disable 1591
namespace RestaurantOrderingSystem_BlazorClient.Pages.Food
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using RestaurantOrderingSystem_BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using RestaurantOrderingSystem_BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using RestaurantOrderingSystem_BlazorClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\_Imports.razor"
using RestaurantOrderingSystem_BlazorClient.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Food/Display/{Id:int}")]
    public partial class Display : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h4>System error</h4>\r\n    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, 
#nullable restore
#line 8 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
        errorString

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 9 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
}
else if (DisplayModel.Food is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<h4>Loading...</h4>\r\n");
#nullable restore
#line 13 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-lg-6 col-md-6 mx-auto");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "h3");
            __builder.AddAttribute(16, "class", "text-center");
            __builder.AddContent(17, 
#nullable restore
#line 18 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                     DisplayModel.Food.FoodName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "tbody");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.AddMarkupContent(26, "<td><strong>Price</strong></td>\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 23 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                             string.Format("{0:C}", DisplayModel.Food.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.AddMarkupContent(33, "<td><strong>Restaurant</strong></td>\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 27 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                             DisplayModel.ItemPurchased

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.AddMarkupContent(40, "<td><strong>Description</strong></td>\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 31 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                             DisplayModel.Food.FoodDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "colspan", "2");
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 35 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                             if (confirmDelete == false)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                                ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-danger");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                                                         (() => confirmDelete = true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\r\n                                    Delete Item\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 40 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                                ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "btn btn-outline-danger");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                                                                 HandleDeleteRecord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "\r\n                                    Confirm Delete\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                                                                    (() => confirmDelete = false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n                                    Cancel\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 50 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "h3 text-center");
            __builder.AddMarkupContent(74, "\r\n                Update information about ");
            __builder.AddContent(75, 
#nullable restore
#line 56 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                          DisplayModel.Food.FoodName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(78);
            __builder.AddAttribute(79, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 58 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                              updateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 58 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(83);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(85);
                __builder2.AddAttribute(86, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 60 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                           updateModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n\r\n                ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.AddMarkupContent(91, "<label for=\"name\" class=\"control-label\">Name</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(92);
                __builder2.AddAttribute(93, "id", "name");
                __builder2.AddAttribute(94, "class", "form-control");
                __builder2.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                            updateModel.FoodName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateModel.FoodName = __value, updateModel.FoodName))));
                __builder2.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateModel.FoodName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Food.Display.TypeInference.CreateValidationMessage_0(__builder2, 99, 100, 
#nullable restore
#line 65 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                              () => updateModel.FoodName

#line default
#line hidden
#nullable disable
                , 101, "text-danger");
                __builder2.AddMarkupContent(102, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group");
                __builder2.AddMarkupContent(106, "\r\n                    ");
                __builder2.AddMarkupContent(107, "<label for=\"price\" class=\"control-label\">Price</label>\r\n                    ");
                __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Food.Display.TypeInference.CreateInputNumber_1(__builder2, 108, 109, "price", 110, "form-control", 111, 
#nullable restore
#line 70 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                              updateModel.Price

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateModel.Price = __value, updateModel.Price)), 113, () => updateModel.Price);
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Food.Display.TypeInference.CreateValidationMessage_2(__builder2, 115, 116, 
#nullable restore
#line 71 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                              () => updateModel.Price

#line default
#line hidden
#nullable disable
                , 117, "text-danger");
                __builder2.AddMarkupContent(118, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n\r\n                ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group");
                __builder2.AddMarkupContent(122, "\r\n                    ");
                __builder2.AddMarkupContent(123, "<label for=\"desc\" class=\"control-label\">Description</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(124);
                __builder2.AddAttribute(125, "id", "desc");
                __builder2.AddAttribute(126, "class", "form-control");
                __builder2.AddAttribute(127, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                            updateModel.FoodDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateModel.FoodDescription = __value, updateModel.FoodDescription))));
                __builder2.AddAttribute(129, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateModel.FoodDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\r\n                    ");
                __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Food.Display.TypeInference.CreateValidationMessage_3(__builder2, 131, 132, 
#nullable restore
#line 77 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
                                              () => updateModel.FoodDescription

#line default
#line hidden
#nullable disable
                , 133, "text-danger");
                __builder2.AddMarkupContent(134, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n\r\n                ");
                __builder2.AddMarkupContent(136, "<div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Update Item\" class=\"btn btn-primary\">\r\n                </div>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
#nullable restore
#line 86 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Food\Display.razor"
 
    [Parameter]
    public int Id { get; set; }

    private DisplayFoodViewModel DisplayModel = new DisplayFoodViewModel();
    private UpdateFoodViewModel updateModel = new UpdateFoodViewModel();
    private string errorString;
    private bool confirmDelete = false;

    protected override async Task OnParametersSetAsync()
    {
        HttpResponseMessage response = await http.GetAsync($"api/food/{Id}");
        if (response.IsSuccessStatusCode)
        {
            DisplayModel = await response.Content.ReadFromJsonAsync<DisplayFoodViewModel>();
            updateModel.Id = DisplayModel.Food.Id;
            updateModel.FoodName = DisplayModel.Food.FoodName;
            updateModel.FoodDescription = DisplayModel.Food.FoodDescription;
            updateModel.Price = DisplayModel.Food.Price;

        }
        else
        {
            errorString = response.ReasonPhrase;
        }
    }


    private async Task HandleValidSubmit()
    {
        try
        {
            HttpResponseMessage response = await http.PutAsJsonAsync("api/food", updateModel);
            DisplayModel.Food.FoodName = updateModel.FoodName;
            DisplayModel.Food.FoodDescription = updateModel.FoodDescription;
            DisplayModel.Food.Price = updateModel.Price;
        }
        catch (Exception ex)
        {
            errorString = ex.Message;
        }

    }

    private async Task HandleDeleteRecord()
    {
        HttpResponseMessage response = await http.DeleteAsync($"api/food/{Id}");

        if (response.IsSuccessStatusCode)
        {
            navigationManager.NavigateTo("food/list");
        }
        else
        {
            errorString = response.ReasonPhrase;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Food.Display
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
