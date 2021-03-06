#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4afe63648cb671c20ce30a89c57fd1bad4f45221"
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
#line 5 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/item/view/{Id:int}")]
    public partial class ItemView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
 if (item == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>Loading ....</p>\r\n");
#nullable restore
#line 10 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, @"<nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""menutest"">Menu Management</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">View Item</li>
        </ol>
    </nav>
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-8");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h3 class=\"ml-4 mb-4\">Item Details</h3>\r\n            ");
            __builder.OpenElement(11, "dl");
            __builder.AddAttribute(12, "class", "row ml-1");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<dt class=\"col-sm-4\">Name</dt>\r\n                ");
            __builder.OpenElement(15, "dd");
            __builder.AddAttribute(16, "class", "col-sm-8");
            __builder.AddContent(17, 
#nullable restore
#line 24 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
                                      item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            \r\n                ");
            __builder.AddMarkupContent(19, "<dt class=\"col-sm-4\">Price</dt>\r\n                ");
            __builder.OpenElement(20, "dd");
            __builder.AddAttribute(21, "class", "col-sm-8");
            __builder.AddContent(22, 
#nullable restore
#line 27 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
                                      item.Price.ToString("F")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n                ");
            __builder.AddMarkupContent(24, "<dt class=\"col-sm-4\">Category</dt>\r\n                ");
            __builder.OpenElement(25, "dd");
            __builder.AddAttribute(26, "class", "col-sm-8");
            __builder.AddContent(27, 
#nullable restore
#line 30 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
                                      item.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                ");
            __builder.AddMarkupContent(29, "<dt class=\"col-sm-4\">Description</dt>\r\n                ");
            __builder.OpenElement(30, "dd");
            __builder.AddAttribute(31, "class", "col-sm-8");
            __builder.AddContent(32, 
#nullable restore
#line 33 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
                                      item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(37);
            __builder.AddAttribute(38, "Roles", "Admin");
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "button");
                __builder2.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
                      (() => UpdateItem(item.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "class", "btn btn-info btn-sm");
                __builder2.AddContent(44, "Update Item");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 41 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "F:\COS grbckup\COS\COS.Wasm\Pages\ItemView.razor"
      
    [Parameter] public int Id { get; set; }

    private ItemDto item; 

    protected override async Task OnInitializedAsync()
    {           
        var result = await Service.GetItem(Id);  
        result.Match(
            s => item = s,
            e => ToastService.ShowError(e.Message)
        );
                  
    } 

    private void UpdateItem(int id)
    {
        NavigationManager.NavigateTo($"item/update/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ItemService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
