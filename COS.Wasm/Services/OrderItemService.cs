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
    public class OrderItemService 
    {
        private HttpClient client;
        private IConfiguration config;
        private string url;

        public OrderItemService(HttpClient client,  IConfiguration config)
        {
            this.client = client;
            this.config = config;
            this.url =  config.GetSection("Services")["ApiURL"];
        }

        public async Task<Union<OrderItemDto,ErrorResponse>> AddItemToOrder(AddItemToOrderDto dto)
        {
            var response = await client.PostAsync($"{url}/api/orderitem", JsonContent.Create(dto));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<OrderItemDto>();
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }           
        }

        public async Task< Union<bool,ErrorResponse> > DeleteItemFromOrder(int orderId, int itemId)
        {
            var response = await client.DeleteAsync($"{url}/api/orderitem/{orderId}/{itemId}");
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