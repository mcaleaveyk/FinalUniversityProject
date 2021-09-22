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
    public class ItemService 
    {
        private HttpClient client;
        private IConfiguration config;
        private string url;

        public ItemService(HttpClient client,  IConfiguration config)
        {
            this.client = client;
            this.config = config;
            this.url =  config.GetSection("Services")["ApiURL"];
        }

        public async Task <IList<Item>> GetItems()
        {                  
            return await client.GetJsonAsync<IList<Item>>($"{url}/api/item");
        }

        public async Task <IList<Item>> GetFillings()
        {                  
            return await client.GetJsonAsync<IList<Item>>($"{url}/api/item/fillings");
        }

        public async Task<Union<ItemDto,ErrorResponse> > GetItem(int id)
        {
            var response = await client.GetAsync($"{url}/api/item/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ItemDto>();
            }
            else 
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            } 
        }

        public async Task< Union<bool,ErrorResponse> > DeleteItem(int id)
        {
            var response = await client.DeleteAsync($"{url}/api/item/{id}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            } 
        }

        public async Task< Union<ItemDto,ErrorResponse> > UpdateItem(ItemDto dto)
        {
            var response = await client.PutAsync($"{url}/api/item/{dto.Id}", JsonContent.Create(dto));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ItemDto>();
            }
            else 
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }                
        }

        public async Task<Union<ItemDto,ErrorResponse>> AddItem(ItemDto dto)
        {
            var response = await client.PostAsync($"{url}/api/item", JsonContent.Create(dto));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ItemDto>();
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }           
        }



    }
}

