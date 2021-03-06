#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3504ee08975fdbe716a1c7f1f59e662262e8ea49"
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
#line 5 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/update/{Id:int}")]
    public partial class CategoryUpdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
 if(Category == null)
{   

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "     ");
            __builder.AddMarkupContent(1, "<p>Loading category...</p>\r\n");
#nullable restore
#line 11 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, @"<nav aria-label=""breadcrumb"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""categorymenu"">Caegory Management</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Update Category</li>
    </ol>
</nav>
    ");
            __builder.OpenElement(4, "h3");
            __builder.AddAttribute(5, "class", "mt-4 mb-4");
            __builder.AddContent(6, "Update Category: ");
            __builder.AddContent(7, 
#nullable restore
#line 20 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
                                            Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<COS.Wasm.Shared.CategoryForm>(9);
            __builder.AddAttribute(10, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<COS.Core.DTOs.CategoryDto>(
#nullable restore
#line 21 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
                            Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnSave", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<COS.Core.DTOs.CategoryDto>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<COS.Core.DTOs.CategoryDto>(this, 
#nullable restore
#line 21 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
                                              Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 21 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
                                                              Cancel

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 22 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "F:\COS grbckup\COS\COS.Wasm\Pages\CategoryUpdate.razor"
      

    [Parameter]
    public int Id { get; set; }

    public CategoryDto Category { get; set; }

    protected override async Task OnInitializedAsync()
    {      
        var result = await Service.GetCategory(Id);  
        result.Match(
            i => Category = i,
            e => ToastService.ShowError(e.Message)
        );       
    }

    private async Task Save()
    {
        var result = await Service.UpdateCategory(Category); 
        result.Match(
            i => { 
                NavigationManager.NavigateTo("categorymenu");
                ToastService.ShowSuccess("Category updated successfully");
            },
            e => ToastService.ShowError(e.Message)
        );
    }

    private void Cancel()
    {        
        NavigationManager.NavigateTo("categorymenu");
        ToastService.ShowInfo("Category update cancelled");
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
