#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e825bf90836e0d5f5a6198efbbedd280952d409"
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
#line 5 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/order/view/{Id:int}")]
    public partial class OrderView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
 if (order == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>Loading ....</p>\r\n");
#nullable restore
#line 10 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-8");
            __builder.AddMarkupContent(8, "\r\n\r\n            ");
            __builder.OpenElement(9, "h3");
            __builder.AddAttribute(10, "class", "ml-4 mb-4");
            __builder.AddContent(11, "Order ");
            __builder.AddContent(12, 
#nullable restore
#line 16 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                                         order.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " Details");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "dl");
            __builder.AddAttribute(16, "class", "row ml-1");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.AddMarkupContent(18, "<dt class=\"col-sm-3\">User Id</dt>\r\n                ");
            __builder.OpenElement(19, "dd");
            __builder.AddAttribute(20, "class", "col-sm-9");
            __builder.AddContent(21, 
#nullable restore
#line 19 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                                      order.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", 
#nullable restore
#line 20 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                          $"user/view/{order.UserId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "class", "btn btn-primary btn-sm ml-5");
            __builder.AddContent(26, "View User");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            \r\n                ");
            __builder.AddMarkupContent(28, "<dt class=\"col-sm-3\">Order placed</dt>\r\n                ");
            __builder.OpenElement(29, "dd");
            __builder.AddAttribute(30, "class", "col-sm-9");
            __builder.AddContent(31, 
#nullable restore
#line 23 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                                      order.OrderTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                ");
            __builder.AddMarkupContent(33, "<dt class=\"col-sm-3\">Order Due</dt>\r\n                ");
            __builder.OpenElement(34, "dd");
            __builder.AddAttribute(35, "class", "col-sm-9");
            __builder.AddContent(36, 
#nullable restore
#line 26 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                                      order.DueFor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n                ");
            __builder.AddMarkupContent(38, "<dt class=\"col-sm-3\">Customer Message</dt>\r\n                ");
            __builder.OpenElement(39, "dd");
            __builder.AddAttribute(40, "class", "col-sm-9");
            __builder.AddContent(41, 
#nullable restore
#line 29 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                                      order.Comment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n                ");
            __builder.AddMarkupContent(43, "<dt class=\"col-sm-3\">Takeaway</dt>\r\n                ");
            __builder.OpenElement(44, "dd");
            __builder.AddAttribute(45, "class", "col-sm-9");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 33 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                     if(order.Takeaway)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                        ");
            __builder.AddMarkupContent(48, "<h7>Yes</h7>\r\n");
#nullable restore
#line 36 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                        ");
            __builder.AddMarkupContent(50, "<h7>No</h7>\r\n");
#nullable restore
#line 40 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n                ");
            __builder.AddMarkupContent(53, "<dt class=\"col-sm-3\">Total Price</dt>\r\n                ");
            __builder.OpenElement(54, "strong");
            __builder.OpenElement(55, "dd");
            __builder.AddAttribute(56, "class", "col-sm-9");
            __builder.AddMarkupContent(57, "£");
            __builder.AddContent(58, 
#nullable restore
#line 44 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                                               order.TotalPrice.ToString("F")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.AddContent(63, "    ");
            __builder.OpenElement(64, "table");
            __builder.AddAttribute(65, "class", "table table-striped");
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.AddMarkupContent(67, "<thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>Items</th>\r\n                <th>Quantity</th>\r\n                <th>Price</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(68, "tbody");
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 60 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
             foreach(var item in order.OrderItems)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 63 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 64 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                         item.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, " x");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "td");
            __builder.AddMarkupContent(81, "£");
            __builder.AddContent(82, 
#nullable restore
#line 65 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                          item.Price.ToString("F")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 67 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.OpenElement(88, "div");
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                          (() => GoToAllOrders())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "class", "btn btn-info btn-sm");
            __builder.AddContent(93, "Back to All Orders");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
                          (() => GoToRecentOrders())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "class", "btn btn-info btn-sm");
            __builder.AddContent(98, "Back to Active Orders");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 74 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "F:\COS grbckup\COS\COS.Wasm\Pages\OrderView.razor"
      

    [Parameter]public int Id { get; set; }

    private OrderDto order { get; set; }

    
    protected override async Task OnInitializedAsync()
    {           
        var result = await Service.GetOrder(Id);  
        result.Match(
            s => order = s,
            e => ToastService.ShowError(e.Message)
        );
                  
    } 

    public void GoToAllOrders()
    {
        NavigationManager.NavigateTo($"ordermenu/all");
    }

    public void GoToRecentOrders()
    {
        NavigationManager.NavigateTo($"ordermenu");
    }

    private void ViewUser(int id)
    {        
        NavigationManager.NavigateTo($"user/view/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
