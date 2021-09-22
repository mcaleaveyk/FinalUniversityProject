using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using COS.Wasm.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using FluentValidation;
using COS.Wasm;

using Blazored.Toast;


namespace COS.Wasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            // http client (used in Services (auth/student))
            builder.Services.AddSingleton(
                sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // 3rd party library providing access to localstorage and used to store jwt token
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();

            //configure authorization
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

            builder.Services.AddValidatorsFromAssemblyContaining<Program>();

            // add auth service
            builder.Services.AddScoped<AuthService>();
            //add item service
            builder.Services.AddScoped<ItemService>();
            //add user service
            builder.Services.AddScoped<UserService>();
            //add category service
            builder.Services.AddScoped<CategoryService>();
            //add order service 
            builder.Services.AddScoped<OrderService>();
            //add orderitem service 
            builder.Services.AddScoped<OrderItemService>();
                //add orderitem service 
            builder.Services.AddScoped<UserFavouriteService>();

            //builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
            
        }
    }
}
