#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e2b37ad66473fd6fa34b404417d9dd8fd6f5a5"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\n        ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "F:\COS grbckup\COS\COS.Wasm\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.AddMarkupContent(8, "<a class=\"navbar-header\" href>Little Eden Coffee Bar </a>\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "F:\COS grbckup\COS\COS.Wasm\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "F:\COS grbckup\COS\COS.Wasm\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\n\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenComponent<COS.Wasm.Shared.NavLogin>(20);
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n\n        ");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "nav-item px-3");
            __builder.AddMarkupContent(25, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "href", "");
            __builder.AddAttribute(29, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "F:\COS grbckup\COS\COS.Wasm\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(31, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(34);
            __builder.AddAttribute(35, "Roles", "Admin");
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.OpenElement(38, "li");
                __builder2.AddAttribute(39, "class", "nav-item px-3");
                __builder2.AddMarkupContent(40, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                __builder2.AddAttribute(42, "class", "nav-link");
                __builder2.AddAttribute(43, "href", "menutest");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Menu Management\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\n\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(49);
            __builder.AddAttribute(50, "Roles", "Admin");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(52, "\n            ");
                __builder2.OpenElement(53, "li");
                __builder2.AddAttribute(54, "class", "nav-item px-3");
                __builder2.AddMarkupContent(55, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
                __builder2.AddAttribute(57, "class", "nav-link");
                __builder2.AddAttribute(58, "href", "categorymenu");
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "\n                    <span class=\"oi oi-list\" aria-hidden=\"true\"></span> Category Management\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\n\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(64);
            __builder.AddAttribute(65, "Roles", "Admin");
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(67, "\n                ");
                __builder2.OpenElement(68, "li");
                __builder2.AddAttribute(69, "class", "nav-item px-3");
                __builder2.AddMarkupContent(70, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(71);
                __builder2.AddAttribute(72, "class", "nav-link");
                __builder2.AddAttribute(73, "href", "ordermenu");
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(75, "\n                    <span class=\"oi oi-british-pound\" aria-hidden=\"true\"></span> Order Management\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\n\n        ");
            __builder.OpenElement(79, "li");
            __builder.AddAttribute(80, "class", "nav-item px-3");
            __builder.AddMarkupContent(81, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(82);
            __builder.AddAttribute(83, "class", "nav-link");
            __builder.AddAttribute(84, "href", "menuitems");
            __builder.AddAttribute(85, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 46 "F:\COS grbckup\COS\COS.Wasm\Shared\NavMenu.razor"
                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(87, "\n                <span class=\"oi oi-cart\" aria-hidden=\"true\"></span> Create Order\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n\n        ");
            __builder.OpenElement(90, "li");
            __builder.AddAttribute(91, "class", "nav-item px-3");
            __builder.AddMarkupContent(92, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(93);
            __builder.AddAttribute(94, "class", "nav-link");
            __builder.AddAttribute(95, "href", "usersubmittedorders");
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(97, "\n                <span class=\"oi oi-file\" aria-hidden=\"true\"></span> Your Submitted Orders\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "F:\COS grbckup\COS\COS.Wasm\Shared\NavMenu.razor"
        private bool collapseNavMenu = true;

            private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

            private void ToggleNavMenu()
            {
                collapseNavMenu = !collapseNavMenu;
            } 
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
