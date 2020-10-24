using Lesson1_Task1_MiddleWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.InfroStrucure.Services
{
    public interface IOrdersService
    {
        IEnumerable<Order> GetUserOrders(string userName);
        Order GetOrderById(int id);
        Order CreateOrder(OrderViewModel model, CartViewModel cart, string userName);
    }
}
