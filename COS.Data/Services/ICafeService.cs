using System;
using System.Collections.Generic;

using COS.Core.Models;

namespace COS.Data.Services
{
    public interface ICafeService
    {
        void Initialise();
        
        //------------ Category management ------------\\
        Category GetCategoryById(int id); 
        IList<Category> GetAllCategories(); 
        IList<Category> GetAllCategoriesForUser();
        Category AddCategory(string name); 
        bool DeleteCategory(int id); 
        Item ChangeItemCategory(int itemid, int categoryid); 
        Category ChangeCategoryName(int id, Category updated); 

        //------------ Item management ------------\\
        IList <Item> GetAllItems(); 
        Item GetItemById(int id); 
        IList<Item> GetAllFillings(); 
        Item AddItemToMenu(string name, decimal price, string description, bool instock, int categoryId, Size? size=null);
        bool DeleteItemFromMenu(int id); 
        Item UpdateItem(int id, Item item);

        //------------ Favourite management ------------\\
        UserFavourite AddItemToFavourites(int userId, int itemId); 
        IList<UserFavourite> GetFavourites(int userid); 
        bool RemoveItemFromUserFavourites(int userid, int itemid); 
        //------------ Order management ------------\\
        IList<Order> GetAllOrders(); 
        IList<Order> GetAllActiveOrders(); 
        IList<Order> GetThreeMostRecentOrders(int userid); 
        IList<Order> GetUsersSubmittedOrders(int userid);
        Order GetUsersRecentUnsubmittedOrder(int id);
        Order GetOrder(int id); 
        Order CreateOrder(int userid);
        OrderItem GetOrderItem(int orderid, int itemid); 
        OrderItem AddItemToOrder(int orderid, int itemid); 
        bool RemoveItemFromOrder(int orderid, int itemid); 
        Order UpdateOrder(int orderid, Order updated); 
        Order MarkFoodAsReady(int id); 
        Order MarkOrderAsFulfilled(int id); 
        bool DeleteOrder(int id); 
        //------------ User management ------------\\
        User RegisterUser(string firstname, string lastname, string email, string password, Role role); 
        User Authenticate(string email, string password); 
        User GetUserByEmailAddress(string email, int? id=null); 
        IList<User> GetAllUsers(); 
        User GetUser(int id); 
        User UpdateUser(int id, User updated); 
        User ChangePassword(int id, User updated);
        bool DeleteUser(int id); 

    }
}