#pragma checksum "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "192f945b936b266085bdd63453bfd9c27a5d9df8"
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
#line 2 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
using COS.Wasm.Pages;

#line default
#line hidden
#nullable disable
    public partial class ItemForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                  Item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                       Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.FluentValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    \r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label for=\"Name\">Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "Name");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                          Item.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.Name = __value, Item.Name))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Item.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __Blazor.COS.Wasm.Shared.ItemForm.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 10 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                  () => Item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    \r\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.AddMarkupContent(25, "<label for=\"Price\">Price</label>\r\n        ");
                __Blazor.COS.Wasm.Shared.ItemForm.TypeInference.CreateInputNumber_1(__builder2, 26, 27, "Course", 28, "form-control", 29, 
#nullable restore
#line 15 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                              Item.Price

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.Price = __value, Item.Price)), 31, () => Item.Price);
                __builder2.AddMarkupContent(32, "\r\n        ");
                __Blazor.COS.Wasm.Shared.ItemForm.TypeInference.CreateValidationMessage_2(__builder2, 33, 34, 
#nullable restore
#line 16 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                  () => Item.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group col-6");
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.AddMarkupContent(43, "<label for=\"Description\">Description</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(44);
                __builder2.AddAttribute(45, "id", "Description");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                                         Item.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.Description = __value, Item.Description))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Item.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __Blazor.COS.Wasm.Shared.ItemForm.TypeInference.CreateValidationMessage_3(__builder2, 51, 52, 
#nullable restore
#line 23 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                      () => Item.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group col-6");
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.AddMarkupContent(58, "<label for=\"Age\">Instock</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(59);
                __builder2.AddAttribute(60, "id", "Instock");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                                     Item.InStock

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.InStock = __value, Item.InStock))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Item.InStock));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __Blazor.COS.Wasm.Shared.ItemForm.TypeInference.CreateValidationMessage_4(__builder2, 66, 67, 
#nullable restore
#line 29 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                      () => Item.InStock

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col-12 row");
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.AddMarkupContent(74, "<label for=\"category\" class=\"col-sm-2 col-form-label\">\r\n            Category\r\n        </label>\r\n        ");
                __Blazor.COS.Wasm.Shared.ItemForm.TypeInference.CreateCustomInputSelect_5(__builder2, 75, 76, "category", 77, "form-control", 78, 
#nullable restore
#line 37 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                                       Item.CategoryId

#line default
#line hidden
#nullable disable
                , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.CategoryId = __value, Item.CategoryId)), 80, () => Item.CategoryId, 81, (__builder3) => {
                    __builder3.AddMarkupContent(82, "\r\n            ");
                    __builder3.AddMarkupContent(83, "<option value=\"0\">Select a category</option>\r\n");
#nullable restore
#line 39 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
             foreach (var cat in Categories)
             {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(84, "                ");
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", 
#nullable restore
#line 41 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                cat.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(87, 
#nullable restore
#line 41 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                         cat.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\r\n");
#nullable restore
#line 42 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
             }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(89, "        ");
                }
                );
                __builder2.AddMarkupContent(90, "\r\n        ");
                __Blazor.COS.Wasm.Shared.ItemForm.TypeInference.CreateValidationMessage_6(__builder2, 91, 92, 
#nullable restore
#line 44 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                  ()=> Item.CategoryId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(93, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group mb-4 mt-4");
                __builder2.AddMarkupContent(97, "\r\n        ");
                __builder2.AddMarkupContent(98, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n        ");
                __builder2.OpenElement(99, "button");
                __builder2.AddAttribute(100, "class", "btn btn-secondary");
                __builder2.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
                                                    Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(102, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n    \r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "F:\COS grbckup\COS\COS.Wasm\Shared\ItemForm.razor"
      

    private IList<CategoryDto> Categories = new List<CategoryDto>();

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Getting categories from api");
        Categories = await api.GetCategories();
        ItemSize = Item.Size.ToString();
    }

    [Parameter]
    public ItemDto Item { get; set; }

    [Parameter] 
    public EventCallback<ItemDto> OnSave { get; set; }

    [Parameter] 
    public EventCallback OnCancel { get; set; }

    //Needed as selectlist doesnt support ints
    public string ItemSize { get; set; }
    
    private void Cancel()
    {
        OnCancel.InvokeAsync(null);
    }

    private void Save() 
    {       
        OnSave.InvokeAsync(Item);       
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CategoryService api { get; set; }
    }
}
namespace __Blazor.COS.Wasm.Shared.ItemForm
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
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
        public static void CreateCustomInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::COS.Wasm.Pages.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
