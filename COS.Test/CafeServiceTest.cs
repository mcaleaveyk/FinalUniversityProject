using System;
using Xunit;
using COS.Data.Services;
using COS.Core.Models;
using System.Collections.Generic;

namespace COS.Test
{
    public class CafeServiceTest
    {
        private readonly ICafeService svc;

        public CafeServiceTest()
        {
            svc = new CafeService();

            //ensure database empty before each test
            svc.Initialise();
        }
        
        // --------------- CATEGORY RELATED TESTS -------------- \\
        [Fact]
        public void AddCategory_WhenNone_ShouldSetName()
        {
            //act 
            var c = svc.AddCategory("TestCategory");
            //retrieve saved category
            var d = svc.GetCategoryById(c.Id);

            //assert
            Assert.NotNull(d);
            Assert.Equal(c.Id, d.Id);
            Assert.Equal("TestCategory", d.Name);
        }

        [Fact]
        public void AddCategory_ThatAlreadyExists_ShouldReturnNull()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            
            //act
            var d = svc.AddCategory("TestCategory");

            //assert
            Assert.Null(d);
        }

        [Fact]
        public void GetAllCategories_When0_ShouldReturn0()
        {
            // act 
            var categories = svc.GetAllCategories();
            var count = categories.Count;

            // assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void GetAllCategories_With2Added_ShouldReturn2()
        {
            //Arrange
            var c = svc.AddCategory("TestCategory");
            var c2 = svc.AddCategory("TestCategory2");

            //act
            var categories = svc.GetAllCategories();
            var count = categories.Count;

            //assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void GetCategoryById_WhenNone_ShouldReturnNull()
        {
            //act
            var category = svc.GetCategoryById(2);  //user doesnt exist

            //assert
            Assert.Null(category);
        }

        [Fact]
        public void GetCategoryById_WhenExists_ShouldReturnCategory()
        {
            //act 
            var c = svc.AddCategory("TestCategory");
            var nc = svc.GetCategoryById(c.Id);

            //assert
            Assert.NotNull(nc);
            Assert.Equal(c.Id, nc.Id);
        }

        [Fact]
        public void ChangeItemCategory_WhenBothExist_ShouldChangeCategory()
        {
            //arrange 
            var c = svc.AddCategory("NoCategory");
            var c2 = svc.AddCategory("Category");
            var i = svc.AddItemToMenu("Item", 2.00m, "Sampletext", true, c2.Id);

            //act
            svc.ChangeItemCategory(i.Id, c.Id);

            //assert
            Assert.Equal(c.Id, i.CategoryId);
        }

        [Fact]
        public void DeleteCategory_ThatExists_ShouldReturnTrue()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");

            //act
            var deleted = svc.DeleteCategory(c.Id);
        
            //assert
            Assert.True(deleted);
        }

        [Fact]
        public void DeleteCategory_ThatDoesntExist_ShouldReturnFalse()
        {
            //act
            var deleted = svc.DeleteCategory(33);

            //assert
            Assert.False(deleted);
        }

        [Fact]
        public void ChangeCategoryName_ThatExists_ShouldChangeName()
        {
            // arrange - create test category
            var o = svc.AddCategory("TestCategory");
                       
            // act - update test category
            var s = new Category {
                Name = "UpdatedCategory"
            };
            s = svc.ChangeCategoryName(o.Id, s);

            // assert
            Assert.NotNull(s);

            // now assert that the properties were set properly           
            Assert.Equal("UpdatedCategory", o.Name);

        }

        // --------------- ITEM RELATED TESTS --------------- \\

        [Fact]
        public void GetAllItems_WhenNone_ShouldReturn0()
        {
            //act
            var items = svc.GetAllItems();
            var count = items.Count;

            //assert 
            Assert.Equal(0, count);
        }

        [Fact]
        public void GetAllItems_When2_ShouldReturn2()
        {
            //Arrange
            var c = svc.AddCategory("TestCategory");

            var i = svc.AddItemToMenu("Item", 2.00m, "Sampletext", true, c.Id);
            var i2 = svc.AddItemToMenu("Item2", 2.00m, "Sampletext2", true, c.Id);

            //Act
            var items = svc.GetAllItems();
            var count = items.Count;

            //Assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void GetItemById_WhenNone_ShouldReturnNull()
        {
            //act
            var item = svc.GetItemById(2);  //item doesnt exist

            //assert
            Assert.Null(item);
        }

        [Fact]
        public void GetItemById_WhenExists_ShouldReturnItem()
        {
            //arrange 
            var c = svc.AddCategory("TestCategory");
            var i = svc.AddItemToMenu("Item", 2.00m, "Sampletext", true, c.Id);

            //act 

            var ni = svc.GetItemById(i.Id);

            //assert
            Assert.NotNull(ni);
            Assert.Equal(i.Id, ni.Id);
        }

        [Fact]
        public void GetAllFillings_ShouldReturnFillingsInStock()
        {
            //Arrange
            //Create categories
            var c = svc.AddCategory("TestCategory");
            var c2 = svc.AddCategory("Filling");

            //create items
            var i = svc.AddItemToMenu("Item", 2.00m, "Sampletext", true, c2.Id);
            var i2 = svc.AddItemToMenu("Item2", 2.00m, "Sampletext", true, c.Id); 
            var i3 = svc.AddItemToMenu("Item3", 2.00m, "Sampletext", false, c2.Id);

            //create list with expected contents
            var fillings = svc.GetAllFillings();
            var expected = new List<Item>();
            expected.Add(i);

            //Assert
            Assert.Equal(expected, fillings);

        }

        [Fact]
        public void GetAllFillings_WhenNoneInStock_ShouldReturnNone()
        {
            //Arrange
            var c = svc.AddCategory("Filling");

            var i = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", false, c.Id); 
            var i2 = svc.AddItemToMenu("Item2", 2.00m, "Sampletext", false, c.Id);

            //Act
            var fillings = svc.GetAllFillings();
            var count = fillings.Count;

            //Assert
            Assert.Equal(0, count);

        }

        [Fact]
        public void AddItemToMenu_WhenNone_ShouldSetAllProperties()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");

            //act
            var i = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", false, c.Id);
            //retrieve saved item
            var ir = svc.GetItemById(i.Id);

            //Assert
            Assert.NotNull(ir);

            //Assert properties were set correctly
            Assert.Equal(i.Id, ir.Id);
            Assert.Equal("Item1", ir.Name);
            Assert.Equal(2.00m, ir.Price);
            Assert.Equal(i.Description, ir.Description);
            Assert.False(ir.InStock);
            Assert.Equal("TestCategory", ir.Category.Name);

        }

        [Fact]
        public void AddItemToMenu_ThatAlreadyExists_ShouldReturnNull()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            var i = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", false, c.Id);

            //act
            var i2 = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", false, c.Id);

            //Assert
            Assert.Null(i2);
        }

        [Fact]
        public void DeleteItemFromMenu_ThatExists_ShouldReturnTrue()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            var i = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", false, c.Id);

            //act
            var deleted = svc.DeleteItemFromMenu(i.Id);

            //assert
            Assert.True(deleted);
        }

        [Fact]
        public void DeleteItemFromMenu_ThatDoesntExist_ShouldReturnNull()
        {
            //act
            var deleted = svc.DeleteItemFromMenu(1);

            //assert
            Assert.False(deleted);
        }

        [Fact]
        public void UpdateItem_ThatExists_ShouldSetProperties()
        {
            // arrange - create test item
            var c = svc.AddCategory("Test1");
            var c2 = svc.AddCategory("Test2");
            var i = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", false, c.Id);
                       
            // act - update test student
            var i2 = new Item {
                Name = "Item2",
                Price = 40.00m,           
                Description = "ThisIsUpdated",
                InStock = true,
                CategoryId = c2.Id

            };
            i2 = svc.UpdateItem(i.Id, i2);

            // assert
            Assert.NotNull(i2);

            // now assert that the properties were set properly           
            Assert.Equal("Item2", i2.Name);
            Assert.Equal(40.00m, i2.Price);
            Assert.Equal("ThisIsUpdated", i2.Description);
            Assert.True(i2.InStock);
            Assert.Equal("Test2", i2.Category.Name);  
        }

        // --------------- FAVOURITE RELATED TESTS --------------- \\

        [Fact]
        public void AddItemToFavourites_AlreadyThere_ShouldReturnNull()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var i = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", false, c.Id);

            //act
            var uf = svc.AddItemToFavourites(u.Id, i.Id);
            var uf2 = svc.AddItemToFavourites(u.Id, i.Id);

            //Assert
            Assert.Null(uf2);

        }

        [Fact]
        public void RemoveItemFromUserFavourites_ThatExists_ShouldReturnTrue()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var i = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", false, c.Id);
            var uf = svc.AddItemToFavourites(u.Id, i.Id);

            //act
            var removed = svc.RemoveItemFromUserFavourites(u.Id, i.Id);

            //Assert
            Assert.True(removed);
        }

        [Fact]
        public void RemoveItemFromUserFavourites_ThatDoesntExist_ShouldReturnFalse()
        {
            //act
            var removed = svc.RemoveItemFromUserFavourites(1, 1);

            //Assert
            Assert.False(removed);
        }

        // --------------- ORDER RELATED TESTS --------------- \\

        [Fact]
        public void GetAllOrders_WhenNone_ShouldReturn0()
        {
            // act 
            var orders = svc.GetAllOrders();
            var count = orders.Count;

            // assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void GetAllOrders_When2_ShouldReturn2()
        {
            //Arrange
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var o1 = svc.CreateOrder(u1.Id);
            var o2 = svc.CreateOrder(u1.Id);

            //Orders must be updated as submitted must be true
            svc.UpdateOrder(o1.Id, new Order {              
            
                DueFor = new DateTime (2020,07,08,14,30,00),
                Comment = "This has been updated and due for set" 
                
            });
            svc.UpdateOrder(o2.Id, new Order {              
            
                DueFor = new DateTime (2020,07,08,14,30,00),
                Comment = "This has been updated and due for set" 
                
            });

            //Act
            var orders = svc.GetAllOrders();
            var count = orders.Count;

            //Assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void GetAllActiveOrders_ShouldReturn_1Order()
        {
            //Arrange
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var o1 = svc.CreateOrder(u1.Id);
            var o2 = svc.CreateOrder(u1.Id);
            svc.UpdateOrder(o1.Id, new Order {              
            
                DueFor = new DateTime (2020,07,08,14,30,00),
                Comment = "This has been updated and due for set" 
                
            });

            //Act
            var activeorders = svc.GetAllActiveOrders();
            var count = activeorders.Count;

            //Assert
            Assert.Equal(1, count);

        }

        [Fact]
        public void GetOrderById_WhenNone_ShouldReturnNull()
        {
            //act
            var order = svc.GetOrder(2);  //order doesnt exist

            //assert
            Assert.Null(order);
        }

        [Fact]
        public void GetOrder_WhenExists_ShouldReturnOrder()
        {
            //act 
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var o1 = svc.CreateOrder(u1.Id);

            var go1 = svc.GetOrder(o1.Id);

            //assert
            Assert.NotNull(go1);
            Assert.Equal(o1.Id, go1.Id);
        }

        [Fact]
        public void CreateOrder_UserExists_ShouldSetProperties()
        {
            //arrange
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);

            //act
            var o1 = svc.CreateOrder(u1.Id);
            //retrieve saved order
            var or = svc.GetOrder(o1.Id);

            //Assert item not null
            Assert.NotNull(or);

            //Assert properties were set correctly
            Assert.Equal(o1.Id, or.Id);
            Assert.Equal(u1.Id, or.UserId);
            Assert.False(or.FoodReady);
            Assert.False(or.OrderFulfilled);
            Assert.Equal(00.00m, or.TotalPrice);
            Assert.Equal("", or.Comment);
            Assert.Empty(or.OrderItems);

        }

        [Fact]
        public void CreateOrder_UserDoesntExist_ShouldReturnNull()
        {
            //act
            var o1 = svc.CreateOrder(3);
            //retrieve saved order
            //Assert
            Assert.Null(o1);

        }

        [Fact]
        public void GetOrderItem_ThatExists_ShouldReturnOrderItem()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var o1 = svc.CreateOrder(u1.Id);
            var i1 = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", true, c.Id);            
            svc.AddItemToOrder(o1.Id, i1.Id);

            //act
            var orderitem = svc.GetOrderItem(o1.Id, i1.Id);

            //Assert
            Assert.Equal("Item1", orderitem.Item.Name);
            Assert.Equal(2.00m, orderitem.Item.Price);
            Assert.Equal("Joe", orderitem.Order.User.FirstName);
        }

        [Fact]
        public void GetOrderItem_OrderDoesntExist_ShouldReturnNull()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");

            //act
            var i1 = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", true, c.Id);
            var orderitem = svc.GetOrderItem(1, i1.Id);

            //Assert
            Assert.Null(orderitem);
        }

        [Fact]
        public void GetOrderItem_ItemDoesntExist_ShouldReturnNull()
        {
            //arrange
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var o1 = svc.CreateOrder(u1.Id);

            var orderitem = svc.GetOrderItem(o1.Id, 1);

            //Assert
            Assert.Null(orderitem);
        }

        [Fact]
        public void AddItemToOrder_ShouldAddItemToOrder()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var o1 = svc.CreateOrder(u1.Id);
            var i1 = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", true, c.Id); 

            //act
            svc.AddItemToOrder(o1.Id, i1.Id);
            var count = o1.OrderItems.Count;

            //Assert
            Assert.Equal(1, count);

        }

        [Fact]
        public void AddItemToOrder_AlreadyThere_ShouldIncreaseQuantity()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var o1 = svc.CreateOrder(u1.Id);
            var i1 = svc.AddItemToMenu("Item1", 2.00m, "Sampletext", true, c.Id); 

            //act
            svc.AddItemToOrder(o1.Id, i1.Id);
            svc.AddItemToOrder(o1.Id, i1.Id);
            var orderitem = svc.GetOrderItem(o1.Id, i1.Id);

            //Assert
            Assert.Equal(2, orderitem.Quantity);

        }

        [Fact]
        public void AddItemToOrder_ItemDoesntExist_ShouldntWork()
        {
            //arrange 
            var u1 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var o1 = svc.CreateOrder(u1.Id);

            //act
            svc.AddItemToOrder(o1.Id, 1);

            //Assert
            Assert.Empty(o1.OrderItems);
        }
        


        // --------------- USER RELATED TESTS --------------- \\

        [Fact]
        public void RegisterUser_WhenNone_ShouldSetAllProperties()
        {
            //act
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            //retrieve user saved
            var v = svc.GetUser(u.Id);

            //assert - that user is not null
            Assert.NotNull(v);

            //now assert that the properties were set properly
            Assert.Equal(v.Id, u.Id);
            Assert.Equal("Joe", v.FirstName);
            Assert.Equal("Bloggs", v.LastName);
            Assert.Equal(u.Email, v.Email);
            Assert.Equal(u.Password, v.Password);
            Assert.Equal(Role.Guest, v.Role);
        }

        [Fact]
        public void RegisterUser_WhenEmailAlreadyExists_ShouldReturnNull()
        {
            //act
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var u2 = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);

            //assert
            Assert.Null(u2);
        }

        [Fact]
        public void GetAllUsers_WhenNone_ShouldReturn0()
        {
            // act 
            var users = svc.GetAllUsers();
            var count = users.Count;

            // assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void GetAllUsers_With2Added_ShouldReturn2()
        {
            //Arrange
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var u2 = svc.RegisterUser("Tom","Bloggs", "tbloggs@cos.com", "password", Role.Guest);

            //act
            var users = svc.GetAllUsers();
            var count = users.Count;

            //assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void GetUserById_WhenNone_ShouldReturnNull()
        {
            //act
            var user = svc.GetUser(2);  //user doesnt exist

            //assert
            Assert.Null(user);
        }

        [Fact]
        public void GetUserById_WhenExists_ShouldReturnUser()
        {
            //act 
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var nu = svc.GetUser(u.Id);

            //assert
            Assert.NotNull(nu);
            Assert.Equal(u.Id, nu.Id);
        }

        [Fact]
        public void GetUser_ShouldReturnFavourites()
        {
            //arrange
            var c = svc.AddCategory("TestCategory");
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);
            var i = svc.AddItemToMenu("FavItem", 2.00m, "FavSampletext", true, c.Id);

            //act
            var uf = svc.AddItemToFavourites(u.Id, i.Id);

            var sr = svc.GetUser(u.Id);
            var count = u.UserFavourites.Count;

            //Assert
            Assert.NotNull(sr.UserFavourites);
            Assert.Equal(1, count);

        }

        [Fact]
        public void GetUserByEmail_WhenNone_ShouldReturnNull()
        {
            //arrange
            var user = svc.GetUserByEmailAddress("bloggs@cos.com");

            //assert
            Assert.Null(user);
        }

        [Fact]
        public void GetUserByEmail_WhenExists_ShouldReturnUser()
        {
            //arrange
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);

            //act
            var nu = svc.GetUserByEmailAddress("bloggs@cos.com");

            //assert
            Assert.NotNull(nu);
            Assert.Equal(u.Id, nu.Id);
        }

        [Fact]
        public void DeleteUser_ThatExists_ShouldReturnTrue()
        {
            //arrange
            var u = svc.RegisterUser("Joe","Bloggs", "bloggs@cos.com", "password", Role.Guest);

            //act
            var deleted = svc.DeleteUser(u.Id);
        
            //assert
            Assert.True(deleted);
        }

        [Fact]
        public void DeleteUser_ThatDoesntExist_ShouldReturnFalse()
        {
            //act
            var deleted = svc.DeleteUser(1);

            //assert
            Assert.False(deleted);
        }

        [Fact]
        public void UpdateUser_ThatExists_ShouldSetProperties()
        {
            // arrange - create test user
            var o = svc.RegisterUser("ZZZ","BloggsZ", "zzz@email.com", "password", Role.Guest);
                       
            // act - update test user
            var s = new User {
                FirstName = "XXX",
                LastName = "BloggsX",           
                Email = "xxx@cos.com",
            };
            s = svc.UpdateUser(o.Id, s);

            // assert
            Assert.NotNull(s);

            // now assert that the properties were set properly           
            Assert.Equal("XXX", s.FirstName);
            Assert.Equal("BloggsX", s.LastName);
            Assert.Equal("xxx@cos.com", s.Email);
        }

    }
}
