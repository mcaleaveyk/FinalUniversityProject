#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe4da21e118189dba78bf723046950d3b6458af"
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
#line 5 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/view/{Id:int}")]
    public partial class CategoryView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
 if (category == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>Loading ....</p>\r\n");
#nullable restore
#line 10 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, "Category: ");
            __builder.AddContent(5, 
#nullable restore
#line 13 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
                   category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddContent(7, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(8);
            __builder.AddAttribute(9, "Roles", "Admin");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenElement(12, "button");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
                      AddItem

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "class", "btn btn-primary btn-sm mr-2 mb-2 mt-2");
                __builder2.AddMarkupContent(15, " \r\n        <span class=\"oi oi-plus mr-2\" aria-hidden=\"true\"></span>Add Item\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.AddContent(18, "    ");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table table-striped");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Name</th>\r\n                <th>Price</th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(25, "tbody");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 33 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
             foreach(var s in category.Items)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 36 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
                         s.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 37 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
                         s.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 38 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
                          $"£{s.Price.ToString("F")}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, " ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
                                           (() => UpdateItem(s.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "btn btn-info btn-sm");
            __builder.AddMarkupContent(44, "\r\n                        <span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 43 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 47 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryView.razor"
      

    [Parameter] public int Id { get; set; }

    private CategoryDto category; 

    protected override async Task OnInitializedAsync()
    {           
        var result = await Service.GetCategory(Id);  
        result.Match(
            s => category = s,
            e => ToastService.ShowError(e.Message)
        );
                  
    } 

    private void AddItem()
    {
        NavigationManager.NavigateTo("item/add");
    }

    private void UpdateItem(int id)
    {
        NavigationManager.NavigateTo($"item/update/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CategoryService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
