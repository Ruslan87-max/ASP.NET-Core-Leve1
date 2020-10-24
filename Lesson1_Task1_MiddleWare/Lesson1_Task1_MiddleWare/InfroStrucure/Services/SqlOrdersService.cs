using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.InfroStrucure.Services
{
    public class SqlOrdersService : IOrdersService
    {
        private readonly WebStoreContext _context;
        private readonly UserManager<User> _userManager;

        public SqlOrdersService(WebStoreContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public Order CreateOrder(OrderViewModel model, CartViewModel cart, string userName)
        {
            var user = _userManager.FindByNameAsync(userName).Result;
            using (var transaction = _context.Database.BeginTransaction())
            {
                var order = new Order()
                {
                    Adress = model.Adress,
                    Date = DateTime.Now,
                    Name = model.Name,
                    Phone = model.Phone,
                    User = user
                };

                _context.Orders.Add(order);

                foreach(var item in cart.Items)
                {
                    var productVm = item.Key;
                    var product = _context.Products.FirstOrDefault(o => o.Id.Equals(productVm.Id));

                    if (product == null)
                        throw new InvalidOperationException("Продукт не найден в базе");

                    var orderItem = new OrderItem()
                    {
                        Order = order,
                        Price = product.Price,
                        Product = product,
                        Quantity = item.Value
                    };
                    _context.OrderItems.Add(orderItem);
                }
                _context.SaveChanges();
                transaction.Commit();
                return order;
            }
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders
                .Include("OrderItems")
                .FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Order> GetUserOrders(string userName)
        {
            return _context.Orders
                .Include("User")
                .Include("OrderItems")
                .Where(o => o.User.UserName.Equals(userName)).ToList();
        }
    }
}
