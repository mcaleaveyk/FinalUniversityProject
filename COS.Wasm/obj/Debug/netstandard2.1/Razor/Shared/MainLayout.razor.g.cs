#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8898476bb4025a16c5f0c2dab89f1d5ad39798a"
// <auto-generated/>
#pragma warning disable 1591
namespace COS.Wasm.Shared
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
#line 2 "F:\COS grbckup\COS\COS.Wasm\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.AddAttribute(1, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 4 "F:\COS grbckup\COS\COS.Wasm\Shared\MainLayout.razor"
                          ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "F:\COS grbckup\COS\COS.Wasm\Shared\MainLayout.razor"
                         3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 6 "F:\COS grbckup\COS\COS.Wasm\Shared\MainLayout.razor"
                          IconType.FontAwesome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(5, "SuccessIcon", "oi oi-thumbs-up");
            __builder.AddAttribute(6, "ErrorIcon", "oi oi-bug");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "sidebar");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenComponent<COS.Wasm.Shared.NavMenu>(11);
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "main");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "content px-4");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddContent(20, 
#nullable restore
#line 17 "F:\COS grbckup\COS\COS.Wasm\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
