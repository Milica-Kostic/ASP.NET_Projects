#pragma checksum "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f928d432b8fb807c1ccdd53f011eaf722a623a8f"
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
#line 1 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.ViewModels.Restaurants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.ViewModels.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\_Imports.razor"
using BlazorServerOrderingSystemApp.ViewModels.Food;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Orders/List")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorServer\BlazorServerOrderingSystemApp\Pages\Orders\List.razor"
       
    private List<OrderModel> orders;
    private string errorString;


    protected override async Task OnInitializedAsync()
    {
        var client = _clientFactory.CreateClient("API");

        try
        {
            orders = await client.GetFromJsonAsync<List<OrderModel>>("api/orders");

        }
        catch (Exception ex)
        {
            errorString = ex.InnerException.Message;

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
