#pragma checksum "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb25ff36fd53162555575db572470d7fe7be202"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerOrderingSystemApp.Pages.Restaurants
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Restaurants/Display/{Id:int}")]
    public partial class Display : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
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
#line 8 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
        errorString

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 9 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
}
else if (DisplayModel.Restaurant is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<h4>Loading...</h4>\r\n");
#nullable restore
#line 13 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
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
#line 18 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                     DisplayModel.Restaurant.RestName

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
            __builder.AddMarkupContent(26, "<td><strong>Category of restaurant</strong></td>\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 23 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                             DisplayModel.ItemPurchased

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
            __builder.AddMarkupContent(33, "<td><strong>City</strong></td>\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 27 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                             DisplayModel.Restaurant.City

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
#line 31 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                             DisplayModel.Restaurant.RestDescription

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
#line 35 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
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
#line 37 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                                                         (() => confirmDelete = true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\r\n                                    Delete Restaurant\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 40 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"

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
#line 44 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
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
#line 47 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                                                                    (() => confirmDelete = false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n                                    Cancel\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 50 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
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
#line 56 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                          DisplayModel.Restaurant.RestName

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
#line 58 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                              UpdateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 58 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
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
#line 60 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                           UpdateModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.AddMarkupContent(91, "<label class=\"control-label\">Name</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(92);
                __builder2.AddAttribute(93, "class", "form-control");
                __builder2.AddAttribute(94, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                            UpdateModel.RestName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UpdateModel.RestName = __value, UpdateModel.RestName))));
                __builder2.AddAttribute(96, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UpdateModel.RestName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __Blazor.BlazorServerOrderingSystemApp.Pages.Restaurants.Display.TypeInference.CreateValidationMessage_0(__builder2, 98, 99, 
#nullable restore
#line 64 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                              () => UpdateModel.RestName

#line default
#line hidden
#nullable disable
                , 100, "text-danger");
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group");
                __builder2.AddMarkupContent(105, "\r\n                    ");
                __builder2.AddMarkupContent(106, "<label class=\"control-label\">Description</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(107);
                __builder2.AddAttribute(108, "class", "form-control");
                __builder2.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                            UpdateModel.RestDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UpdateModel.RestDescription = __value, UpdateModel.RestDescription))));
                __builder2.AddAttribute(111, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UpdateModel.RestDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\r\n                    ");
                __Blazor.BlazorServerOrderingSystemApp.Pages.Restaurants.Display.TypeInference.CreateValidationMessage_1(__builder2, 113, 114, 
#nullable restore
#line 69 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                              () => UpdateModel.RestDescription

#line default
#line hidden
#nullable disable
                , 115, "text-danger");
                __builder2.AddMarkupContent(116, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "form-group");
                __builder2.AddMarkupContent(120, "\r\n                    ");
                __builder2.AddMarkupContent(121, "<label class=\"control-label\">City</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(122);
                __builder2.AddAttribute(123, "class", "form-control");
                __builder2.AddAttribute(124, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                            UpdateModel.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UpdateModel.City = __value, UpdateModel.City))));
                __builder2.AddAttribute(126, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UpdateModel.City));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(127, "\r\n                    ");
                __Blazor.BlazorServerOrderingSystemApp.Pages.Restaurants.Display.TypeInference.CreateValidationMessage_2(__builder2, 128, 129, 
#nullable restore
#line 74 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
                                              () => UpdateModel.City

#line default
#line hidden
#nullable disable
                , 130, "text-danger");
                __builder2.AddMarkupContent(131, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                ");
                __builder2.AddMarkupContent(133, "<div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Update Restaurant\" class=\"btn btn-primary\">\r\n                </div>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
#nullable restore
#line 82 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Restaurants\Display.razor"
 
    [Parameter]
    public int Id { get; set; }

    private DisplayRestaurantViewModel DisplayModel = new DisplayRestaurantViewModel();
    private UpdateRestaurantViewModel UpdateModel = new UpdateRestaurantViewModel();
    private string errorString;
    private bool confirmDelete = false;

    protected override async Task OnInitializedAsync()
    {
        var client = _clientFactory.CreateClient("API");

        var restaurant = await client.GetAsync($"api/restaurants/{Id}");

        try
        {
            DisplayModel = await restaurant.Content.ReadFromJsonAsync<DisplayRestaurantViewModel>();
            UpdateModel.Id = DisplayModel.Restaurant.Id;
            UpdateModel.RestName = DisplayModel.Restaurant.RestName;
            UpdateModel.RestDescription = DisplayModel.Restaurant.RestDescription;
            UpdateModel.City = DisplayModel.Restaurant.City;
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

            var restaurant = await client.PutAsJsonAsync("api/restaurants", UpdateModel);

            DisplayModel.Restaurant.RestName = UpdateModel.RestName;
            DisplayModel.Restaurant.RestDescription = UpdateModel.RestDescription;
            DisplayModel.Restaurant.City = UpdateModel.City;

        }
        catch (Exception ex)
        {

            errorString = ex.Message;
        }
    }
    private async Task HandleDeleteRecord()
    {

        var client = _clientFactory.CreateClient("API");

        var restaurant = await client.DeleteAsync($"api/restaurants/{Id}");

        if (restaurant.IsSuccessStatusCode)
        {
            navigationManager.NavigateTo("restaurants/list");
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
namespace __Blazor.BlazorServerOrderingSystemApp.Pages.Restaurants.Display
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
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
