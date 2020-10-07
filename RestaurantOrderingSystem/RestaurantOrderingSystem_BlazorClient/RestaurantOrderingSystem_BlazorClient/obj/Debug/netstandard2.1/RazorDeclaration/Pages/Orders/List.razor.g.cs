#pragma checksum "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Orders\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bc3fe9684caefc315ef3f1104cf446a1668a879"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RestaurantOrderingSystem_BlazorClient.Pages.Orders
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Orders/List")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Orders\List.razor"
 
    private List<OrderModel> ordersList;
    private string errorString;
    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response = await Http.GetAsync("api/orders");

        if (response.IsSuccessStatusCode)
        {
            ordersList = await response.Content.ReadFromJsonAsync<List<OrderModel>>();
        }
        else
        {
            errorString = response.ReasonPhrase;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591