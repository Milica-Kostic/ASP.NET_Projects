#pragma checksum "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040af3d4160eecc40afae4e3ebc7502c8f41cfb6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Orders/Create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Milica\Desktop\GIT\ASP.NET_Projects\RestaurantOrderingSystem\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\Create.razor"
 
    private OrderModel order = new OrderModel();
    private List<FoodModel> foodList = new List<FoodModel>();
    private string errorString;

    protected override async Task OnInitializedAsync()
    {
        var client = _clientFactory.CreateClient("API");

        try
        {
            foodList = await client.GetFromJsonAsync<List<FoodModel>>("api/food");

        }
        catch (Exception ex)
        {

            errorString = ex.Message;
        }

    }

    private void FoodItemChange(ChangeEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.Value.ToString()) == false)
        {
            order.FoodId = int.Parse(e.Value.ToString());
        }
        else
        {
            order.FoodId = 0;
        }
    }
    private async Task HandleValidSubmit()
    {
        try
        {
            var client = _clientFactory.CreateClient("API");

            var response = await client.PostAsJsonAsync("api/orders", order);
            var contents = await response.Content.ReadFromJsonAsync<CreateOrderViewModel>();
            navigationManager.NavigateTo($"orders/display/{contents.Id}");
        }
        catch (Exception ex)
        {
            errorString = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
