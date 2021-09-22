#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Pages\MenuItems.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e85d44a31054041932873fc61262415d6a356259"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace COS.Wasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using COS.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using COS.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using COS.Wasm.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using COS.Wasm.Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using COS.Core.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using COS.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\COS grbckup\COS\COS.Wasm\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\COS grbckup\COS\COS.Wasm\Pages\MenuItems.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/menuitems")]
    public partial class MenuItems : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "F:\COS grbckup\COS\COS.Wasm\Pages\MenuItems.razor"
       
    //Added as double clicking buttons caused error
    public bool IsTaskRunning = false;

    private IList<CategoryDto> categories = new List<CategoryDto>();
    private IList<ItemDto> UserFavourites = new List<ItemDto>();

    private AddItemToOrderDto addItemDto { get; set; } = new AddItemToOrderDto();

    private int UserId { get; set; }

    private UserDto User { get; set; }

    public CreateOrderDto dto { get; set; } = new CreateOrderDto();

    public OrderDto Order { get; set; }

    protected override async Task OnInitializedAsync()
    {
        //get categories
        categories = await api.GetCategoriesForUser();

        //get current userId onInitialise
        var authstate = await auth.GetAuthenticationStateAsync();
        var user = authstate.User;
        
        //user related
        int x = 0;
        Int32.TryParse(user.Identity.Name, out x);
        UserId = x;

        //createOrderDto property set
        dto.UserId = UserId;

        //make the users most recent unsubmitted order the current order
        var result = await service.GetUserMostRecentUnsubmittedOrder(UserId);
        result.Match(
            s => Order = s,
            e => ToastService.ShowInfo($"You dont have an order yet. Press 'Create order' to get started")
        );

        //load user's favourites
        UserFavourites = await ufService.GetFavouriteItems(UserId);

    }

    private void GoToOrders()
    {
        NavigationManager.NavigateTo($"userorders");
    }

    protected async Task AddItemToOrder(int itemId)
    {
        IsTaskRunning = true;

        addItemDto.OrderId = Order.Id;
        addItemDto.ItemId = itemId;

        var result = await oiService.AddItemToOrder(addItemDto);
        result.Match(
                s => {
                    ToastService.ShowSuccess($"Item added to order successfully");
                },
                e => ToastService.ShowError(e.Message)
        );

        IsTaskRunning = false;
    }

    protected async Task RemoveItemFromFavourites(int userId, int itemId)
    {
        IsTaskRunning = true;

        var result = await ufService.DeleteItemFromFavourites(userId, itemId);
        result.Match(
            s => {
                ToastService.ShowSuccess("Favourite deleted successfully");
            },
            e => ToastService.ShowError(e.Message)
        );
        UserFavourites = await ufService.GetFavouriteItems(UserId);

        IsTaskRunning = false;
    }

    protected async Task UserFavouriteAdded()
    {
        IsTaskRunning = true;
        UserFavourites = await ufService.GetFavouriteItems(UserId);
        IsTaskRunning = false;
    }

    protected async Task CreateOrder(CreateOrderDto coDto)
    {
        IsTaskRunning = true;
        
        var result = await service.CreateOrder(coDto);
        result.Match(
            i => Order = i,
            e => ToastService.ShowError(e.Message)
        );

        IsTaskRunning = false;
        ToastService.ShowSuccess($"Order created successfully");
    }

    bool isAbsolute = true;


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderItemService oiService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserFavouriteService ufService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService svc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CategoryService api { get; set; }
    }
}
#pragma warning restore 1591