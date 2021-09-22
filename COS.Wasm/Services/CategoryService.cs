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
    public class CategoryService 
    {
        private HttpClient client;
        private IConfiguration config;
        private string url;

        public CategoryService(HttpClient client,  IConfiguration config)
        {
            this.client = client;
            this.config = config;
            this.url =  config.GetSection("Services")["ApiURL"];
        }

        public async Task <IList<CategoryDto>> GetCategories()
        {                  
            return await client.GetJsonAsync<IList<CategoryDto>>($"{url}/api/category");
        }

        public async Task <IList<CategoryDto>> GetCategoriesForUser()
        {                  
            return await client.GetJsonAsync<IList<CategoryDto>>($"{url}/api/category/foruser");
        }

        public async Task<Union<CategoryDto,ErrorResponse> > GetCategory(int id)
        {
            var response = await client.GetAsync($"{url}/api/category/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CategoryDto>();
            }
            else 
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            } 
        }

        public async Task< Union<CategoryDto,ErrorResponse> > UpdateCategory(CategoryDto dto)
        {
            var response = await client.PutAsync($"{url}/api/category/{dto.Id}", JsonContent.Create(dto));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CategoryDto>();
            }
            else 
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }                
        }

        public async Task<Union<CategoryDto,ErrorResponse>> CreateCategory(CategoryDto dto)
        {
            var response = await client.PostAsync($"{url}/api/category", JsonContent.Create(dto));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CategoryDto>();
            }
            else
            {
                return await response.Content.ReadFromJsonAsync<ErrorResponse>();
            }           
        }


    }
}