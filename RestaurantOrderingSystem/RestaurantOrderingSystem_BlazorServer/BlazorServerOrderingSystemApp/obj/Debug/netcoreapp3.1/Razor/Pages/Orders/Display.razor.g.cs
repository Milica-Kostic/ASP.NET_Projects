#pragma checksum "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bee708b0efb281be3e6eea1b13fac332484c98f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerOrderingSystemApp.Pages.Orders
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.ViewModels.Restaurants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.ViewModels.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.ViewModels.Food;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Orders/Display/{Id:int}")]
    public partial class Display : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h3>System error</h3>\r\n    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
        errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 9 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
}
else if (DisplayModel.Order is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<h4>Loading...</h4>\r\n");
#nullable restore
#line 13 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-6 col-md-6 mx-auto");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "h3");
            __builder.AddAttribute(15, "class", "text-center");
            __builder.AddContent(16, 
#nullable restore
#line 18 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                     DisplayModel.Order.OrderName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<td><strong>Date</strong></td>\r\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 23 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                             DisplayModel.Order.OrderDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.AddMarkupContent(32, "<td><strong>Food</strong></td>\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 27 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                             DisplayModel.ItemPurchased

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.AddMarkupContent(39, "<td><strong>Total</strong></td>\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 31 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                             string.Format("{0:C}", DisplayModel.Order.Total)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "colspan", "2");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 35 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                             if (confirmDelete == false)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                                ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-danger");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                                                         (() => confirmDelete = true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "\r\n                                    Delete Order\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 40 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                                ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-outline-danger");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                                                                 HandleDeleteRecord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "\r\n                                    Confirm Delete\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                                                                    (() => confirmDelete = false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                                    Cancel\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 50 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "h3 text-center");
            __builder.AddMarkupContent(73, "\r\n                Update information about ");
            __builder.AddContent(74, 
#nullable restore
#line 56 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                          DisplayModel.Order.OrderName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(77);
            __builder.AddAttribute(78, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 58 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                              UpdateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 58 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(81, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(82);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(84);
                __builder2.AddAttribute(85, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 60 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                           UpdateModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group");
                __builder2.AddMarkupContent(89, "\r\n                    ");
                __builder2.AddMarkupContent(90, "<label class=\"control-label\">Name</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(91);
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                            UpdateModel.OrderName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UpdateModel.OrderName = __value, UpdateModel.OrderName))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UpdateModel.OrderName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n                    ");
                __Blazor.BlazorServerOrderingSystemApp.Pages.Orders.Display.TypeInference.CreateValidationMessage_0(__builder2, 97, 98, 
#nullable restore
#line 64 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                              () => UpdateModel.OrderName

#line default
#line hidden
#nullable disable
                , 99, "text-danger");
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group");
                __builder2.AddMarkupContent(104, "\r\n                    ");
                __builder2.AddMarkupContent(105, "<label class=\"control-label\">Quantity</label>\r\n                    ");
                __Blazor.BlazorServerOrderingSystemApp.Pages.Orders.Display.TypeInference.CreateInputNumber_1(__builder2, 106, 107, "form-control", 108, 
#nullable restore
#line 68 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                              UpdateModel.Quantity

#line default
#line hidden
#nullable disable
                , 109, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UpdateModel.Quantity = __value, UpdateModel.Quantity)), 110, () => UpdateModel.Quantity);
                __builder2.AddMarkupContent(111, "\r\n                    ");
                __Blazor.BlazorServerOrderingSystemApp.Pages.Orders.Display.TypeInference.CreateValidationMessage_2(__builder2, 112, 113, 
#nullable restore
#line 69 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
                                              () => UpdateModel.Quantity

#line default
#line hidden
#nullable disable
                , 114, "text-danger");
                __builder2.AddMarkupContent(115, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\r\n                ");
                __builder2.AddMarkupContent(117, "<div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Update Order\" class=\"btn btn-primary\">\r\n                </div>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 78 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Display.razor"
 
    [Parameter]
    public int Id { get; set; }

    private DisplayOrderViewModel DisplayModel = new DisplayOrderViewModel();
    private UpdateOrderViewModel UpdateModel = new UpdateOrderViewModel();
    private string errorString;
    private bool confirmDelete = false;

    protected override async Task OnInitializedAsync()
    {
        var client = _clientFactory.CreateClient("API");

        var order = await client.GetAsync($"api/orders/{Id}");

        try
        {
            DisplayModel = await order.Content.ReadFromJsonAsync<DisplayOrderViewModel>();
            
            UpdateModel.Id = DisplayModel.Order.Id;
            UpdateModel.OrderName = DisplayModel.Order.OrderName;
            UpdateModel.FoodId = DisplayModel.Order.FoodId;
            UpdateModel.Quantity = DisplayModel.Order.Quantity;
            UpdateModel.Total = DisplayModel.Order.Total;
        }
        catch (Exception ex)
        {

            errorString = ex.Message;
        }
    }
    
    private async Task HandleValidSubmit()
    {
        try
        {
            var client = _clientFactory.CreateClient("API");

            await client.PutAsJsonAsync("api/orders", UpdateModel);
            var food = await client.GetFromJsonAsync<List<FoodModel>>("api/food");

            DisplayModel.Order.OrderName = UpdateModel.OrderName;
            DisplayModel.Order.FoodId = UpdateModel.FoodId;
            DisplayModel.Order.Quantity = UpdateModel.Quantity;
            DisplayModel.Order.Total = UpdateModel.Quantity * food.Where(f => f.Id == DisplayModel.Order.FoodId).First().Price;
        }
        catch (Exception ex)
        {

            errorString = ex.Message;
        }
    }
    
    private async Task HandleDeleteRecord()
    {

        var client = _clientFactory.CreateClient("API");

        var restaurant = await client.DeleteAsync($"api/orders/{Id}");

        if (restaurant.IsSuccessStatusCode)
        {
            navigationManager.NavigateTo("orders/list");
        }
        else
        {
            errorString = restaurant.ReasonPhrase;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
namespace __Blazor.BlazorServerOrderingSystemApp.Pages.Orders.Display
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
