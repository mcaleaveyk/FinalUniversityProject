using System;
using COS.Core.Models;

namespace COS.Data.Services
{
    public static class CafeServiceSeeder
    {
        public static void Seed(ICafeService svc)
        {
            svc.Initialise();

            //Create some categories
            var c1 = svc.AddCategory("Coffee");
            var c7 = svc.AddCategory("Tea");
            var c2 = svc.AddCategory("Bakery");
            var c3 = svc.AddCategory("Salad");
            var c8 = svc.AddCategory("Sandwich");
            var c4 = svc.AddCategory("Filling");
            var c5 = svc.AddCategory("NoCategory");
            var c6 = svc.AddCategory("Cold Drinks");

            //create some users
            var u1 = svc.RegisterUser("Joe", "Bloggs", "admin@cos.com","admin", Role.Admin);
            var u2 = svc.RegisterUser("John", "Smith", "guest@cos.com", "guest", Role.Guest);
            var u3 = svc.RegisterUser("Mary", "Example", "mary@cos.com", "mary", Role.Guest);
            var u4 = svc.RegisterUser("Man", "Ager", "manager@cos.com", "manager", Role.Manager);

            //Add some items to the menu
            var i1 = svc.AddItemToMenu("Lettuce", 0.50m, "Green and leafy", true, c4.Id, Size.NoSize);
            var i2 = svc.AddItemToMenu("Americano", 2.10m, "Espresso and hot water", true, c1.Id, Size.Small );
            var i3 = svc.AddItemToMenu("Cortado", 2.30m, "Fancy words for coffe", true, c1.Id, Size.NoSize); 
            var i4 = svc.AddItemToMenu("Choc. Muffin", 2.00m, "Chocolatey Muffin", true, c2.Id, Size.NoSize);
            var i5 = svc.AddItemToMenu("Oat Cookie", 1.50m, "Cookie made with oats", true, c2.Id, Size.NoSize);
            var i6 = svc.AddItemToMenu("Caesar Salad", 7.00m, "Hail Caesar", true, c3.Id, Size.NoSize);
            var i8 = svc.AddItemToMenu("Cappuccino", 2.50m, "This is a cappuccino", true, c1.Id, Size.NoSize);
            var i9 = svc.AddItemToMenu("Latte",2.60m, "This is a Latte", true, c1.Id, Size.NoSize);
            var i10  = svc.AddItemToMenu("Espresso", 1.90m, "This is an espresso", true, c1.Id, Size.NoSize);
            var i11 = svc.AddItemToMenu("Tomato", 0.50m, "Sliced tomato", true, c4.Id, Size.NoSize);
            var i12 = svc.AddItemToMenu("Spinach Salad", 5.00m, "This is a salad", true, c3.Id, Size.NoSize);
            var i7 = svc.AddItemToMenu("Water", 1.20m, "Cold H2O", true, c6.Id,Size.NoSize);
            var i13 = svc.AddItemToMenu("Coke", 1.20m, "Coca-Cola", true, c6.Id, Size.NoSize);
            var i14 = svc.AddItemToMenu("Fanta Orange", 1.20m, "Fanta Orange", true, c6.Id, Size.NoSize);
            var i15 = svc.AddItemToMenu("Diet Coke", 1.20m, "Diet Coca-Cola", true, c6.Id, Size.NoSize);
            var i16 = svc.AddItemToMenu("Fifteen", 2.20m, "Homemade Fifteen", true, c2.Id, Size.NoSize);
            var i17 = svc.AddItemToMenu("Choc. Brownie", 2.20m, "Homemade Chocolate Brownie", true, c2.Id, Size.NoSize);
            var i18 = svc.AddItemToMenu("Cheesecake", 2.20m, "Changes daily", true, c2.Id, Size.NoSize);
            var i19 = svc.AddItemToMenu("Flat White", 2.25m, "Milky", true, c1.Id, Size.NoSize);
            var i20 = svc.AddItemToMenu("Filter", 2.25m, "Updated daily with new roasts", true, c1.Id, Size.NoSize);
            var i21 = svc.AddItemToMenu("Breakfast Tea", 2.25m, "It's Tea", true, c7.Id, Size.NoSize);
            var i22 = svc.AddItemToMenu("Green Tea", 2.25m, "Tea but green", true, c7.Id, Size.NoSize);
            var i23 = svc.AddItemToMenu("BLT", 3.50m, "Bacon Lettuce Tomato", true, c8.Id, Size.NoSize);
            var i24 = svc.AddItemToMenu("Ham", 3.50m, "In bread", true, c8.Id, Size.NoSize);
            var i25 = svc.AddItemToMenu("Chicken", 3.50m, "In bread", true, c8.Id, Size.NoSize);
            var i26 = svc.AddItemToMenu("Breakfast", 3.50m, "Sausage, Bacon and egg", true, c8.Id, Size.NoSize);

            // //update an item
            // svc.UpdateItem(i5.Id, new Item { 

            //     Name = "UpdatedItem",
            //     Price = 400.00m,
            //     Description = "updated",
            //     InStock = false,
            //     Category = c1

            // });

            //add items to users favourites
            svc.AddItemToFavourites(u2.Id, i2.Id);
            svc.AddItemToFavourites(u2.Id, i1.Id);
            svc.AddItemToFavourites(u2.Id, i5.Id);
            svc.AddItemToFavourites(u1.Id, i5.Id);

            //try order stuff
            var o1 = svc.CreateOrder(u1.Id);
            svc.AddItemToOrder(o1.Id, i3.Id);
            svc.AddItemToOrder(o1.Id, i2.Id);
            svc.AddItemToOrder(o1.Id, i3.Id);

            var o2 = svc.CreateOrder(u1.Id);
            svc.AddItemToOrder(o2.Id, i1.Id);
            svc.AddItemToOrder(o2.Id, i2.Id);
            svc.AddItemToOrder(o2.Id, i3.Id);   

            var o3 = svc.CreateOrder(u2.Id);
            svc.AddItemToOrder(o3.Id, i3.Id);
            svc.AddItemToOrder(o3.Id, i2.Id);
            svc.AddItemToOrder(o3.Id, i3.Id);                     

            var o4 = svc.CreateOrder(u1.Id);
            svc.AddItemToOrder(o4.Id, i3.Id);
            svc.AddItemToOrder(o4.Id, i2.Id);
            svc.AddItemToOrder(o4.Id, i3.Id);
            
            var o5 = svc.CreateOrder(u1.Id);
            svc.AddItemToOrder(o5.Id, i3.Id);
            svc.AddItemToOrder(o5.Id, i2.Id);
            svc.AddItemToOrder(o5.Id, i3.Id);

            var o6 = svc.CreateOrder(u1.Id);
            svc.AddItemToOrder(o6.Id, i3.Id);
            svc.AddItemToOrder(o6.Id, i2.Id);
            svc.AddItemToOrder(o6.Id, i3.Id);

            var o7 = svc.CreateOrder(u2.Id);
            svc.AddItemToOrder(o7.Id, i3.Id);
            svc.AddItemToOrder(o7.Id, i2.Id);
            svc.AddItemToOrder(o7.Id, i3.Id);

            // svc.UpdateOrder(o1.Id,new Order {

            //     DueFor = new DateTime (2020,07,08,14,30,00),
            //     Comment = "This has been updated, and due for set"
            // });
            
            // svc.RemoveItemFromOrder(o3.Id, i3.Id );

            svc.UpdateOrder(o3.Id,new Order {

                DueFor = new DateTime (2020,08,11,14,00,00),
                Comment = "This has been updated, and due for set"
            });

            svc.UpdateOrder(o2.Id,new Order {

                DueFor = new DateTime (2020,08,08,14,30,00),
                Comment = "This has been updated, and due for set"
            });

            svc.MarkFoodAsReady(o2.Id);
            svc.MarkFoodAsReady(o2.Id);

            // svc.MarkOrderAsFulfilled(1);
            // svc.MarkOrderAsFulfilled(2);
            // svc.MarkOrderAsFulfilled(4);
            // svc.MarkOrderAsFulfilled(5);



            //svc.DeleteCategory(c1.Id);
            

            // ------------------------------------------- CONSOLE TESTS ---------------------------------------------------------------

            //Check items correctly added to orders
            // var order = svc.GetOrder(2);
            // foreach (var item in order.OrderItems)
            // {
            //     Console.WriteLine($"Item Name {item.Item.Name} Size {item.Size} price {item.Item.Price} Quantity {item.Quantity}  User {item.Order.User.FirstName}");
            // }

            //Remove an item from u2 favourites
            //svc.RemoveItemFromUserFavourites(u2.Id, i2.Id);

            // var activeorders = svc.GetAllActiveOrders();
            // foreach(var order in activeorders)
            // {
            //         Console.WriteLine($"OrderDue: {order.DueFor} OrderedBy: {order.User.FirstName} Items: {order.OrderItems.ToString()}");
            //         foreach(var item in order.OrderItems)
            //         {
            //             Console.WriteLine($"Items: {item.Item.Name} {item.Item.Size} {item.Quantity}");
            //         }
            // }

            //Check items correctly added to user1 favs
            // foreach (var item in u2.UserFavourites)
            // {
            //     Console.WriteLine($"Item Name {item.Item.Name}");
            // }
            
            //Check getFavourites working correctly
            // var faves = svc.GetFavourites(u2.Id);
            // foreach (var item in faves)
            // {
            //     Console.WriteLine($"Item Name {item.Item.Name}");
            // }

            // var category = svc.GetCategoryById(c2.Id);
            // foreach(var item in category.Items)
            // {
            //     Console.WriteLine($"Itemname {item.Name}");
            // }
        }
    }
}