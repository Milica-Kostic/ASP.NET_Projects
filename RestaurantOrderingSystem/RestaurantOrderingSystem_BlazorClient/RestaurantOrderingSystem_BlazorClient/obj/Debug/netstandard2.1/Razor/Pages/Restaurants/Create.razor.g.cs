#pragma checksum "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043be5a94a4e98da2353038638d43a8d7037ee41"
// <auto-generated/>
#pragma warning disable 1591
namespace RestaurantOrderingSystem_BlazorClient.Pages.Restaurants
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Restaurants/Create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h4>System Error</h4>\r\n    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, 
#nullable restore
#line 8 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
        errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 9 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
}
else if (categoryItems is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<h4>Loading...</h4>\r\n");
#nullable restore
#line 13 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
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
            __builder.AddMarkupContent(14, "<h3 class=\"text-center\">Add Restaurant</h3>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                              restaurant

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(22);
                __builder2.AddAttribute(23, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                           restaurant

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n\r\n                ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.AddMarkupContent(28, "<label for=\"name\" class=\"control-label\">Name</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "name");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                            restaurant.RestName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => restaurant.RestName = __value, restaurant.RestName))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => restaurant.RestName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Restaurants.Create.TypeInference.CreateValidationMessage_0(__builder2, 36, 37, 
#nullable restore
#line 26 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                              () => restaurant.RestName

#line default
#line hidden
#nullable disable
                , 38, "text-danger");
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.AddMarkupContent(44, "<label for=\"cty\" class=\"control-label\">Category</label>\r\n                    ");
                __builder2.OpenElement(45, "select");
                __builder2.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                       CategoryItemChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "id", "cty");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "required", true);
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.OpenElement(51, "option");
                __builder2.AddAttribute(52, "value", true);
                __builder2.AddAttribute(53, "disabled", "disabled");
                __builder2.AddContent(54, "Select category");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n");
#nullable restore
#line 33 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                         foreach (var f in categoryItems)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(56, "                            ");
                __builder2.OpenElement(57, "option");
                __builder2.AddAttribute(58, "value", 
#nullable restore
#line 35 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                            f.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(59, 
#nullable restore
#line 35 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                                   f.CategoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n");
#nullable restore
#line 36 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(61, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n                ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.AddMarkupContent(67, "<label for=\"city\" class=\"control-label\">City</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "id", "city");
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                            restaurant.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => restaurant.City = __value, restaurant.City))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => restaurant.City));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Restaurants.Create.TypeInference.CreateValidationMessage_1(__builder2, 75, 76, 
#nullable restore
#line 43 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                              () => restaurant.City

#line default
#line hidden
#nullable disable
                , 77, "text-danger");
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n\r\n                ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __builder2.AddMarkupContent(83, "<label for=\"desc\" class=\"control-label\">Description</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(84);
                __builder2.AddAttribute(85, "id", "desc");
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                                restaurant.RestDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => restaurant.RestDescription = __value, restaurant.RestDescription))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => restaurant.RestDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Restaurants.Create.TypeInference.CreateValidationMessage_2(__builder2, 91, 92, 
#nullable restore
#line 49 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
                                              () => restaurant.RestDescription

#line default
#line hidden
#nullable disable
                , 93, "text-danger");
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n                ");
                __builder2.AddMarkupContent(96, "<div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Add restaurant\" class=\"btn btn-success\">\r\n                    <a href=\"/Restaurants/List\" class=\"btn btn-outline-success\">Cancel</a>\r\n                </div>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 59 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\Projects\RestaurantAPP\RestaurantOrderingSystem_BlazorClient\RestaurantOrderingSystem_BlazorClient\Pages\Restaurants\Create.razor"
 
    private RestaurantModel restaurant = new RestaurantModel();
    private List<CategoryModel> categoryItems = new List<CategoryModel>();
    private string errorString;

    protected override async Task OnParametersSetAsync()
    {
        HttpResponseMessage response = await http.GetAsync("api/categories");

        if (response.IsSuccessStatusCode)
        {
            categoryItems = await response.Content.ReadFromJsonAsync<List<CategoryModel>>();
        }
        else
        {
            errorString = response.ReasonPhrase;
        }
    }

    private void CategoryItemChange(ChangeEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.Value.ToString()) == false)
        {
            restaurant.CategoryId = int.Parse(e.Value.ToString());
        }
    }

    private async Task HandleValidSubmit()
    {
        try
        {
            var response = await http.PostAsJsonAsync("api/restaurants", restaurant);
            var contents = await response.Content.ReadFromJsonAsync<CreateRestaurantViewModel>();

            navigationManager.NavigateTo($"Restaurants/Display/{contents.Id}");
            //restaurant = new RestaurantModel();
        }
        catch (Exception es)
        {
            errorString = es.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.RestaurantOrderingSystem_BlazorClient.Pages.Restaurants.Create
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
