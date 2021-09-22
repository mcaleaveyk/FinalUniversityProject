#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d4c46c562eeddba41b2a525f34c668838aa92e4"
// <auto-generated/>
#pragma warning disable 1591
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
#line 5 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/order/delete/{Id:int}")]
    public partial class OrderDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"mt-4 mb-4\">Delete Order</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4 class=\"mb-1\">Are you sure you want to delete this Order?</h4>\r\n");
            __builder.AddMarkupContent(2, "<h5 class=\"mb-4\">This will permanently delete the order from the database.</h5>\r\n\r\n");
#nullable restore
#line 12 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
 if (Order == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p>Loading order...</p>\r\n");
#nullable restore
#line 15 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
}
else 
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "dl");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<dt class=\"col-sm-3\">Order Id:</dt>\r\n        ");
            __builder.OpenElement(10, "dd");
            __builder.AddAttribute(11, "class", "col-sm-9");
            __builder.AddContent(12, 
#nullable restore
#line 20 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
                              Order.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        ");
            __builder.AddMarkupContent(14, "<dt class=\"col-sm-3\">User Id:</dt>\r\n        ");
            __builder.OpenElement(15, "dd");
            __builder.AddAttribute(16, "class", "col-sm-9");
            __builder.AddContent(17, 
#nullable restore
#line 23 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
                              Order.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.AddMarkupContent(19, "<dt class=\"col-sm-3\">Price:</dt>\r\n        ");
            __builder.OpenElement(20, "dd");
            __builder.AddAttribute(21, "class", "col-sm-9");
            __builder.AddMarkupContent(22, "£");
            __builder.AddContent(23, 
#nullable restore
#line 26 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
                               Order.TotalPrice.ToString("F")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n        ");
            __builder.AddMarkupContent(25, "<dt class=\"col-sm-3\">OrderDate</dt>\r\n        ");
            __builder.OpenElement(26, "dd");
            __builder.AddAttribute(27, "class", "col-sm-9");
            __builder.AddContent(28, 
#nullable restore
#line 29 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
                              Order.OrderTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n        ");
            __builder.AddMarkupContent(30, "<dt class=\"col-sm-3\">DueFor</dt>\r\n        ");
            __builder.OpenElement(31, "dd");
            __builder.AddAttribute(32, "class", "col-sm-9");
            __builder.AddContent(33, 
#nullable restore
#line 32 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
                              Order.DueFor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        \r\n  \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
                          () => Delete(Order.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "btn btn-danger mr-3");
            __builder.AddContent(42, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
                          Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "class", "btn btn-secondary");
            __builder.AddContent(47, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 40 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderDelete.razor"
      
    
    [Parameter]
    public int Id { get; set; }

    public OrderDto Order { get; set; }

    protected override async Task OnInitializedAsync()
    {           
        var result = await api.GetOrder(Id);  
        result.Match(
            s => Order = s,
            e => toastService.ShowError(e.Message)
        );     
    }

    private async Task Delete(int orderId)
    {
        Console.WriteLine("Deleting Order");
        var result = await api.DeleteOrder(orderId); 
        result.Match(
            s => {
                NavigationManager.NavigateTo($"ordermenu/all");
                toastService.ShowSuccess("Order deleted successfully");
            },
                e => toastService.ShowError(e.Message)
        );
    }

    private void Cancel()
    {        
         NavigationManager.NavigateTo("ordermenu/all");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService api { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
