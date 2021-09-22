using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using COS.Core.DTOs;
using COS.Core.Models;
using COS.Core.Helpers;

namespace COS.Wasm.Services
{
    public class UserService 
    {
        private HttpClient client;
        private IConfiguration config;
        private string url;

        public UserService(HttpClient client,  IConfiguration config)
        {
            this.client = client;
            this.config = config;
            this.url =  config.GetSection("Services")["ApiURL"];
        }
        public async Task<Union<UserDto,ErrorResponse> > GetUser(int id)
        {
            var response = await client.GetAsync($"{url}/api/user/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<UserDto>();
            }
            else 
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            } 
        }

    }
}