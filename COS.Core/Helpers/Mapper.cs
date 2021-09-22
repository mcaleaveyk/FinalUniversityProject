using System;
using System.Linq;
using COS.Core.Models;

namespace COS.Core.DTOs
{
    public static class Mapper
    {
        //User to userDTO
        public static UserDto ToDto(this User u)
        {
            return new UserDto {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                // password is removed for security
                Role = (int)u.Role,
                Token = u.Token,
                FavItems = u.UserFavourites.Select(t => t.ToDto()).ToList(),
                Orders = u.Orders.Select(t => t.ToDto()).ToList()
            };
        }

        //UserDTO to user
        public static User ToUser(this UserDto dto)
        {
            return new User {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                // password is removed for security
                Role = (Role)dto.Role,
                Token = dto.Token
                
            };
        }

        //-----------------------------------------------

        //Category to CategoryDTO   
        public static CategoryDto ToDto(this Category c)
        {
            if (c == null) return null;
            return new CategoryDto {
                Id = c.Id,
                Name = c.Name,
                Items = c.Items.Select(t => t.ToDto()).ToList()
            };
        } 

        //Alternative for getItem (items caused loop)
        //called in Item to ItemDto
        public static CategoryDto ToDtoAlt(this Category c)
        {
            if (c == null) return null;
            return new CategoryDto {
                Id = c.Id,
                Name = c.Name,
            };
        } 

        //CategoryDTO to Category
        public static Category ToCategory(this CategoryDto c)
        {
            if (c == null) return null;
            return new Category {
                Id = c.Id,
                Name = c.Name,
            };
        } 

        //-----------------------------------------------------------------

        //ItemDTO to Item
        public static Item ToItem(this ItemDto dto)
        {
            if (dto == null) return null;
            return new Item {
                Id = dto.Id,
                CategoryId = dto.CategoryId,
                Name = dto.Name,
                Price = dto.Price,
                Description = dto.Description,
                InStock = dto.InStock,
                Size = (Size)dto.Size,
                Category = dto.Category.ToCategory()
                
            };
        }

        //Item to ItemDTO
        public static ItemDto ToDto(this Item i)
        {
            if (i == null) return null;
            return new ItemDto {
                Id = i.Id,
                CategoryId = i.CategoryId,
                Name = i.Name,
                Price = i.Price,
                Description = i.Description,
                InStock = i.InStock,
                Size = 3,
                Category = i.Category.ToDtoAlt()
            };
        }

        //-----------------------Userfavourite-----------------------------
        //userfavourite to userfavouriteDto
        public static UserFavouriteDto ToDto(this UserFavourite uf)
        {
            if (uf == null) return null;
            return new UserFavouriteDto {
                UserId = uf.UserId,
                ItemId = uf.ItemId,
                Name = uf.Name,
                Price = uf.Price,
                Description = uf.Description
            };
        }

        //----------------------- OrderItem -----------------------------
        public static OrderItemDto ToDto(this OrderItem oi)
        {
            if (oi == null) return null;
            return new OrderItemDto {
                OrderId = oi.OrderId,
                ItemId = oi.ItemId,
                Name = oi.Name,
                Price = oi.Price,
                Notes = oi.Notes,
                Quantity = oi.Quantity,
                Size = (int)oi.Size
            
            };
        }

        //OrderItemDTO to OrderItem
        public static OrderItem ToOrderItem(this OrderItemDto dto)
        {
            if (dto == null) return null;
            return new OrderItem {
                OrderId = dto.OrderId,
                ItemId = dto.ItemId,
                Name = dto.Name,
                Price = dto.Price,
                Notes = dto.Notes,
                Quantity = dto.Quantity,
                Size = (Size)dto.Size
            };
        }

        //----------------------- Order -----------------------------
        //Order to OrderDTO   
        public static OrderDto ToDto(this Order o)
        {
            if (o == null) return null;
            return new OrderDto {
                Id = o.Id,
                UserId = o.UserId,
                OrderTime = o.OrderTime,
                DueFor = o.DueFor,
                FoodReady = o.FoodReady,
                Takeaway = o.Takeaway,
                OrderFulfilled = o.OrderFulfilled,
                Submitted = o.Submitted,
                TotalPrice = o.TotalPrice,
                Comment = o.Comment,
                OrderItems = o.OrderItems.Select(t => t.ToDto()).ToList()
            };
        } 

        //ItemDTO to Item
        public static Order ToOrder(this OrderDto dto)
        {
            if (dto == null) return null;
            return new Order {
                Id = dto.Id,
                UserId = dto.UserId,
                OrderTime = dto.OrderTime,
                DueFor = dto.DueFor,
                FoodReady = dto.FoodReady,
                Takeaway = dto.Takeaway,
                OrderFulfilled = dto.OrderFulfilled,
                Submitted = dto.Submitted,
                TotalPrice = dto.TotalPrice,
                Comment = dto.Comment,
                OrderItems = dto.OrderItems.Select(t => t.ToOrderItem()).ToList()
                
            };
        }    

    }
}
