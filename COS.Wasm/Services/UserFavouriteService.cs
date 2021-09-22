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
    public class UserFavouriteService 
    {
        private HttpClient client;
        private IConfiguration config;
        private string url;

        public UserFavouriteService(HttpClient client,  IConfiguration config)
        {
            this.client = client;
            this.config = config;
            this.url =  config.GetSection("Services")["ApiURL"];
        }

        public async Task<Union<UserFavouriteDto,ErrorResponse>> AddItemToFavourites(UserFavouriteDto dto)
        {
            var response = await client.PostAsync($"{url}/api/userfavourite", JsonContent.Create(dto));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<UserFavouriteDto>();
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }           
        }

        public async Task <IList<ItemDto>> GetFavouriteItems(int userId)
        {                  
            return await client.GetJsonAsync<IList<ItemDto>>($"{url}/api/userfavourite/user/{userId}");
        }

        public async Task< Union<bool,ErrorResponse> > DeleteItemFromFavourites(int userId, int itemId)
        {
            var response = await client.DeleteAsync($"{url}/api/userfavourite/{userId}/{itemId}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            } 
        }  
        
    }
}

