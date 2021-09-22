using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using COS.Core.Models;
using COS.Data.Repositories;
using COS.Data.Security;


namespace COS.Data.Services
{
    public class CafeService : ICafeService
    {
        private readonly DatabaseContext db;

        public CafeService()
        {
            db = new DatabaseContext();
        }

        public void Initialise()
        {
            db.Initialise();
        }

        // -------------------- Category Operations -----------------\\

        //method to get a category with associated items
        public Category GetCategoryById(int id)
        {
            return db.Categories.Include(c => c.Items)
                                .FirstOrDefault(c => c.Id == id);

        }

        //method to get all categories
        public IList<Category> GetAllCategories()
        {
            return db.Categories.Include(c => c.Items)
                                .ToList();

        }

        //Method to 
        public IList<Category> GetAllCategoriesForUser()
        {
            return db.Categories.Where(c => c.Name != "NoCategory")
                                .Include(c => c.Items)
                                .Where(c => c.Items.Any(i => i.InStock == true))
                                .ToList();

        }

        //method to add a category
        public Category AddCategory(string name)
        {
            //verify that a category with the same name doesn't exist
            var exists = db.Categories.FirstOrDefault(c => c.Name == name);
            if(exists != null)
            {
                return null;
            }
            
            var c = new Category { Name = name };

            db.Categories.Add(c);
            db.SaveChanges();

            return c; 

        }


        //Method to delete category 
        //will not be used as deleting category not required by stakeholder
        //rename function available instead
        public bool DeleteCategory(int id)
        {
            var c = GetCategoryById(id);

            if(c == null)
            {
                return false;
            }
            db.Categories.Remove(c);
            db.SaveChanges();
            return true;

        }

        //Legacy code, not needed.
        //Change category simply takes place with update item method
        public Item ChangeItemCategory(int itemid, int categoryid)
        {
            var c = GetCategoryById(categoryid);
            var i = GetItemById(itemid);

            //check category and item exist
            if(c == null || i == null)
            {
                return null;
            }  

            i.Category = c;

            db.SaveChanges();
            return i;          
        }

        //method to change categoryName 
        public Category ChangeCategoryName(int id, Category updated)
        {
            var c = GetCategoryById(id);

            //check category exists
            if(c == null)
            {
                return null;
            }

            c.Name = updated.Name;

            db.SaveChanges();
            return c;
            
        }

        // -------------------- Item Operations -----------------\\

        //Method to get all items
        //Used in MenuManagement
        public IList<Item> GetAllItems()
        {
            return db.Items.Include(i => i.Category)
                            .OrderBy(i => i.Category.Name)
                            .ThenBy(i => i.Name)
                            .ToList();

        }

        //Method to get an item by id
        public Item GetItemById(int id)
        {
            return db.Items.Include(i => i.Category)
                            .FirstOrDefault(i => i.Id == id);
                            
        }

        //Method to get only ingredients/fillings for list
        public IList<Item> GetAllFillings()
        {
            return db.Items.Where(i => i.Category.Name == "Filling" && i.InStock)
                            .Include(i => i.Category)
                            .ToList();

        }

        //Method to add an item to the menu
        public Item AddItemToMenu(string name, decimal price, string description, bool instock, int categoryId, Size? size = null)
        {
            //check item with same name doesnt already exist
            var exists = db.Items.FirstOrDefault(i => i.Name == name && i.Size == size);
            if(exists != null)
            {
                return null;
            }

            var i = new Item{
                Name = name,
                CategoryId = categoryId,
                Price = price,
                Description = description,
                InStock = instock,
                Category = GetCategoryById(categoryId),
                Size = size
            };
            
            db.Items.Add(i);
            db.SaveChanges();
            return i;

        }

        //Method to delete item from menu
        public bool DeleteItemFromMenu(int id)
        {
            var i = GetItemById(id);

            if(i == null)
            {
                return false;
            }

            db.Items.Remove(i);
            db.SaveChanges();
            return true;

        }

        //method to update an item on the menu
        public Item UpdateItem(int id, Item updated)
        {
            var item = GetItemById(id);

            if(item == null)
            {
                return null;
            }
            item.Name = updated.Name;
            item.CategoryId = updated.CategoryId;
            item.Price = updated.Price;
            item.Description = updated.Description;
            item.InStock = updated.InStock;
            item.Size = updated.Size;

            db.SaveChanges();
            return item;

        }

        // -------------------- Favourites Operations -----------------\\

        //Method to add an item to user's favourites
        public UserFavourite AddItemToFavourites(int userId, int itemId)
        {
            //check if favourite already exists
            var uf = db.UserFavourites.FirstOrDefault(f => f.UserId == userId && f.ItemId == itemId);
            if(uf != null)
            {
                return null;
            }

            //locate the user and the item
            var u = GetUser(userId);
            var i = GetItemById(itemId);

            //if either doesnt exist return null
            if(u == null || i == null)
            {
                return null;
            }

            //create the uf and add to the database
            var nuf = new UserFavourite 
            { 
                UserId = u.Id, 
                ItemId = i.Id, 
                Name = i.Name,
                Price = i.Price,
                Description = i.Description

            };

            db.UserFavourites.Add(nuf);
            db.SaveChanges();
            return nuf;
        }

        //method to get favourites for a user
        public IList<UserFavourite> GetFavourites(int userid)
        {
            var user = GetUser(userid);

            //Check if exists
            if(user == null)
            {
                return null;
            }

            var favourites = db.UserFavourites.Where(uf => uf.UserId == user.Id)
                                                .OrderBy(uf => uf.Item.Name)
                                                .ToList();

            return favourites;
        }

        //Method to remove item from users favourites
        public bool RemoveItemFromUserFavourites(int userid, int itemid)
        {
            var uf = db.UserFavourites.FirstOrDefault(f => f.ItemId == itemid && f.UserId == userid);
            if (uf == null)
            {
                return false;
            }
            db.UserFavourites.Remove(uf);
            db.SaveChanges();
            return true;

        }

        // -------------------- Order Operations -----------------\\

        //method to get all orders
        //used by admin to see all orders
        public IList<Order> GetAllOrders()
        {
            return db.Orders.Where(x=>x.Submitted == true)//.Where(t => t.DueFor.CompareTo(DateTime.Today) >= 0)
                            .OrderBy(x => x.DueFor)
                            .Take(100)
                            .ToList();
        }

        //Method to get active orders
        //used by admin to only see orders which are currently active
        public IList<Order> GetAllActiveOrders()
        {
            return db.Orders.Include(x => x.OrderItems)
                            .Include(x => x.User)
                            .Where(x => x.Submitted == true && x.OrderFulfilled == false)
                            .OrderBy(x => x.DueFor)
                            .ToList();
        }

        //method to get users x most recent orders (includes incomplete orders)
        public IList<Order> GetThreeMostRecentOrders(int userid)
        {
            return db.Orders.Include(x => x.OrderItems)
                            .Include(x => x.User)
                            .Where(x => x.UserId == userid && x.Submitted == false && x.OrderItems.Count != 0)
                            .OrderByDescending(x => x.Id)
                            .Take(5)
                            .ToList();
        }

        //method so users can see their recently submitted orders
        public IList<Order> GetUsersSubmittedOrders(int userid)
        {
            return db.Orders.Include(x => x.OrderItems)
                            .Include(x => x.User)
                            .Where(x => x.UserId == userid && x.Submitted == true)
                            .OrderByDescending(x => x.Id)
                            .Take(10)
                            .ToList();
        }

        //method to get an order by id
        public Order GetOrder(int id)
        {
            return db.Orders.Include(u => u.OrderItems)
                            .Include(u => u.User)
                            .FirstOrDefault(u => u.Id == id);
        }

        //method to get a users most recent unsubmitted order
        public Order GetUsersRecentUnsubmittedOrder(int id)
        {
            return db.Orders.Include(u => u.OrderItems)
                            .Include(u => u.User)
                            .OrderByDescending(u => u.OrderTime)
                            .FirstOrDefault(u => u.UserId == id && u.Submitted == false);
        }

        //Method which will create an order
        public Order CreateOrder(int userid)
        {
            //verify user 
            var u = GetUser(userid);

            //check if exists
            if(u == null)
            {
                return null;
            }

            var o = new Order{
                UserId = userid,
                OrderTime = DateTime.Now,
                FoodReady = false,
                OrderFulfilled = false,
                TotalPrice = 00.00m,
                Comment = ""
            };

            db.Orders.Add(o);
            db.SaveChanges();
            return o;
        }

        //method to get an orderitem
        public OrderItem GetOrderItem(int orderid, int itemid)
        {
            return db.OrderItems.FirstOrDefault(m => m.OrderId == orderid && m.ItemId == itemid);
        }

        //Method to add an item to an order
        public OrderItem AddItemToOrder(int orderid, int itemid)
        {

            //locate order and item
            var o = GetOrder(orderid);
            var i = GetItemById(itemid);

            //check if exist and that is instock
            if(o == null || i == null || i.InStock == false)
            {
                return null;
            }

            //check if order item exists
            var oi = GetOrderItem(o.Id, i.Id);

            //check if orderitem exists
            if(oi == null)
            {
                //create new orderitem if it doesnt exist
                oi = new OrderItem
                {
                    ItemId = i.Id,
                    OrderId = o.Id,
                    Name = i.Name,
                    Price = i.Price,
                    Quantity = 1,
                    Size = i.Size
                };
                db.OrderItems.Add(oi);
            }
            else
            {
                //if the orderitem exists then add quantity
                oi.Quantity = oi.Quantity + 1;
            }
            
            //adjust price
            o.TotalPrice += oi.Price;

            db.SaveChanges();
            return oi;
        }

        //Method to remove item from order
        public bool RemoveItemFromOrder(int orderid, int itemid)
        {
            //locate order and item
            var o = GetOrder(orderid);
            var i = GetItemById(itemid);

            //check if order and item exist
            if(o == null || i == null)
            {
                return false;
            }

            var oi = GetOrderItem(o.Id, i.Id);

             //check if order item exists
            if(oi == null)
            {
                return false;
            }
            else if(oi.Quantity > 1)
            {
                oi.Quantity = oi.Quantity - 1;
            }
            else
            {
                db.OrderItems.Remove(oi);
            }

            o.TotalPrice -= oi.Price;
            db.SaveChanges();
            return true;

        }

        //Method used to update order details
        public Order UpdateOrder(int orderid, Order updated)
        {
            var order = GetOrder(orderid);

            //check if order exists
            if(order == null)
            {
                return null;
            }

            order.DueFor = updated.DueFor;
            order.Comment = updated.Comment;
            order.OrderTime = DateTime.Now;
            order.Takeaway = updated.Takeaway;
            order.Submitted = true;

            db.SaveChanges();
            return order;

        }

        //method to mark food as ready in order
        public Order MarkFoodAsReady(int id)
        {
            //check order exists
            var order = GetOrder(id);
            if(order == null)
            {
                return null;
            }

            //set order foodready to true
            order.FoodReady = !order.FoodReady;
            db.SaveChanges();
            return order;
        }

        //method to set orderfulfilled to true
        public Order MarkOrderAsFulfilled(int id)
        {
            var order = GetOrder(id);
            
            //check order exists
            if(order == null)
            {
                return null;
            }

            //set orderfulfilled to true
            order.OrderFulfilled = !order.OrderFulfilled;

            db.SaveChanges();
            return order;

        }

        //method to delete order
        public bool DeleteOrder(int id)
        {
            //check if exists
            var o = GetOrder(id);
            if(o == null)
            {
                return false;
            }

            db.Orders.Remove(o);
            db.SaveChanges();
            return true;

        }


        // -------------------- User Operations -----------------\\

        //Method to get all users
        public IList<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        //Method to get User by Id
        public User GetUser(int id)
        {
            return db.Users.Include(u => u.Orders)
                            .ThenInclude(o => o.OrderItems)
                            .Include(u => u.UserFavourites)
                            .ThenInclude(uf => uf.Item)
                            .FirstOrDefault(u => u.Id == id);
                            
        }

        //Method to find a user by email address (should be unique)
        public User GetUserByEmailAddress(string email, int? id=null)
        {
            return db.Users.FirstOrDefault(u => u.Email == email && ( id == null || u.Id != id));
        }

        public User Authenticate(string email, string password)
        {
            //retrieve the user based on EmailAddress(email must be unique)
            var user = GetUserByEmailAddress(email);

            //verify the user exists and hashed user password matches the password provided
            return (user != null && Hasher.ValidateHash(user.Password,password)) ? user : null;
        }

        //Method to register user
        public User RegisterUser(string firstname, string lastname, string email, string password, Role role)
        {
            //check user doesn't already exist
            var exists = GetUserByEmailAddress(email);
            if(exists != null)
            {
                return null;
            }

            //custom hasher used to encrypt the password before storing in db
            var user = new User
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Password = Hasher.CalculateHash(password),
                Role = role
            };

            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

        //method for admin only to delete user
        public bool DeleteUser(int id)
        {
            var u = GetUser(id);

            if(u == null)
            {
                return false;
            }

            db.Users.Remove(u);
            db.SaveChanges();
            return true;
        }

        //method so user can update their personal userinfo (password + favourites mgmt seperately)
        public User UpdateUser(int id, User updated)
        {
            var user = GetUser(id);

            if(user == null)
            {
                return null;
            }

            user.FirstName = updated.FirstName;
            user.LastName = updated.LastName;
            user.Email = updated.Email;

            db.SaveChanges();
            return user;

        }

        public User ChangePassword(int id, User updated)
        {
            var user = GetUser(id);

            if(user == null)
            {
                return null;
            }

            user.Password = Hasher.CalculateHash(updated.Password);
            
            db.SaveChanges();
            return user;
        }

    }
}
