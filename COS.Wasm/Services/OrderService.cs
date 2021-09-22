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
    public class OrderService 
    {
        private HttpClient client;
        private IConfiguration config;
        private string url;

        public OrderService(HttpClient client,  IConfiguration config)
        {
            this.client = client;
            this.config = config;
            this.url =  config.GetSection("Services")["ApiURL"];
        }

        public async Task <IList<Order>> GetActiveOrders()
        {                  
            return await client.GetJsonAsync<IList<Order>>($"{url}/api/order/active");
        }

        public async Task <IList<Order>> GetAllOrders()
        {                  
            return await client.GetJsonAsync<IList<Order>>($"{url}/api/order");
        }

        public async Task <IList<OrderDto>> GetMostRecentOrders(int userid)
        {                  
            return await client.GetJsonAsync<IList<OrderDto>>($"{url}/api/order/recent/{userid}");
        }

        public async Task <IList<OrderDto>> GetUsersSubmittedOrders(int userid)
        {                  
            return await client.GetJsonAsync<IList<OrderDto>>($"{url}/api/order/submitted/{userid}");
        }
        public async Task<Union<OrderDto, ErrorResponse>> GetUserMostRecentUnsubmittedOrder(int id)
        {
            var response = await client.GetAsync($"{url}/api/order/recentunsubmitted/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<OrderDto>();
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }
        }

        public async Task<Union<OrderDto,ErrorResponse> > GetOrder(int id)
        {
            var response = await client.GetAsync($"{url}/api/order/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<OrderDto>();
            }
            else 
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            } 
        }

        public async Task<Union<OrderDto,ErrorResponse>> CreateOrder(CreateOrderDto dto)
        {
            var response = await client.PostAsync($"{url}/api/order", JsonContent.Create(dto));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<OrderDto>();
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }           
        }

        public async Task<Union<OrderDto,ErrorResponse>> MarkFoodReady(Order order)
        {
            var response = await client.PatchAsync($"{url}/api/order/{order.Id}/foodready", JsonContent.Create(order));
             if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<OrderDto>();
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }
        }

        public async Task<Union<OrderDto,ErrorResponse>> MarkOrderFulfilled(Order order)
        {
             var response = await client.PatchAsync($"{url}/api/order/{order.Id}/orderfulfilled", JsonContent.Create(order));
             if(response.IsSuccessStatusCode)
             {
                 return await response.Content.ReadFromJsonAsync<OrderDto>();
             }
             else
             {
                 return await response.Content.ReadFromJsonAsync<ErrorResponse>();
             }
        }

        public async Task< Union<bool,ErrorResponse> > DeleteOrder(int orderId)
        {
            var response = await client.DeleteAsync($"{url}/api/order/{orderId}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            } 
        } 
        public async Task< Union<OrderDto,ErrorResponse> > UpdateOrder(OrderDto dto)
        {
            var response = await client.PutAsync($"{url}/api/order/{dto.Id}", JsonContent.Create(dto));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<OrderDto>();
            }
            else 
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }                
        }

    }
}