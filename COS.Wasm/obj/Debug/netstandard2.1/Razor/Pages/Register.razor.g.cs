#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d6a038d5fdfa70dab8ccc89845f8f187db0afea"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"mb-4\">Register</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<h5 class=\"card-title\">Please enter your details</h5>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                         RegisterModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                                       HandleRegistration

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.FluentValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.AddMarkupContent(18, "<label for=\"firstname\">First Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "Id", "FirstName");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                                                            RegisterModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterModel.FirstName = __value, RegisterModel.FirstName))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegisterModel.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __Blazor.COS.Wasm.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 17 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                          () => RegisterModel.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.AddMarkupContent(33, "<label for=\"lastname\">Last Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "Id", "LastName");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                                                           RegisterModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterModel.LastName = __value, RegisterModel.LastName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegisterModel.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __Blazor.COS.Wasm.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 22 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                          () => RegisterModel.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.AddMarkupContent(48, "<label for=\"email\">Email address</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "Id", "email");
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                                                        RegisterModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterModel.Email = __value, RegisterModel.Email))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegisterModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __Blazor.COS.Wasm.Pages.Register.TypeInference.CreateValidationMessage_2(__builder2, 56, 57, 
#nullable restore
#line 27 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                          () => RegisterModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.AddMarkupContent(63, "<label for=\"password\">Password</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "Id", "password");
                __builder2.AddAttribute(66, "type", "password");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                                                                           RegisterModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterModel.Password = __value, RegisterModel.Password))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegisterModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __Blazor.COS.Wasm.Pages.Register.TypeInference.CreateValidationMessage_3(__builder2, 72, 73, 
#nullable restore
#line 32 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                          () => RegisterModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group");
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.AddMarkupContent(79, "<label for=\"confirmpassword\">Confirm Password</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(80);
                __builder2.AddAttribute(81, "Id", "confirmpassword");
                __builder2.AddAttribute(82, "type", "password");
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                                                                                  RegisterModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterModel.ConfirmPassword = __value, RegisterModel.ConfirmPassword))));
                __builder2.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegisterModel.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                ");
                __Blazor.COS.Wasm.Pages.Register.TypeInference.CreateValidationMessage_4(__builder2, 88, 89, 
#nullable restore
#line 37 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
                                          () => RegisterModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(90, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.AddMarkupContent(92, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "F:\COS grbckup\COS\COS.Wasm\Pages\Register.razor"
       

    private RegisterDto RegisterModel = new RegisterDto();

    private async Task HandleRegistration()
    {
        var result = await AuthService.RegisterAsync(RegisterModel);

        result.Match(
            u => { 
                NavigationManager.NavigateTo("/login"); 
                toastService.ShowSuccess("Registered Successfully"); 
            },
            e => { 
                toastService.ShowError(e.Message);
            }
        );
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthService AuthService { get; set; }
    }
}
namespace __Blazor.COS.Wasm.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591