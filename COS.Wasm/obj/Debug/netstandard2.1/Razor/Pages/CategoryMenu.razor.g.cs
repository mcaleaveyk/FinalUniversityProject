#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb3c5ff207e759a0cf666050183937f423cc032"
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
#line 5 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categorymenu")]
    public partial class CategoryMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Category Management</h2>\r\n");
            __builder.AddMarkupContent(1, "<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item active\" aria-current=\"page\">Category Management</li>\r\n    </ol>\r\n</nav>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Roles", "Admin");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "button");
                __builder2.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
                      AddCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "class", "btn btn-primary btn-sm mr-2 mb-2 mt-2");
                __builder2.AddMarkupContent(9, " \r\n        <span class=\"oi oi-plus mr-2\" aria-hidden=\"true\"></span>Add Category\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table table-striped");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Name</th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 30 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
             foreach(var s in Categories)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
                         s.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 34 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
                         s.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
                                          (() => ViewCategory(s.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-info btn-sm");
            __builder.AddMarkupContent(33, "\r\n                        <span class=\"oi oi-magnifying-glass\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n                        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
                                          (() => UpdateCategory(s.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn btn-info btn-sm");
            __builder.AddMarkupContent(38, "\r\n                        <span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 43 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryMenu.razor"
      
    private IList<CategoryDto> Categories = new List<CategoryDto>();

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Getting items from api");
        Categories = await api.GetCategories();
    }

    private void ViewCategory(int id)
    {        
        NavigationManager.NavigateTo($"category/view/{id}");
    }

    private void AddCategory()
    {
        NavigationManager.NavigateTo("category/add");
    }

    private void UpdateCategory(int id)
    {
        NavigationManager.NavigateTo($"category/update/{id}");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CategoryService api { get; set; }
    }
}
#pragma warning restore 1591