using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.InfroStrucure.Services;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1_Task1_MiddleWare.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IOrdersService _ordersService;
        public ProfileController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Orders()
        {
            var orders = _ordersService.GetUserOrders(User.Identity.Name);
            var userOrderModel = new List<UserOrderViewModel>(orders.Count());

            foreach(var order in orders)
            {
                userOrderModel.Add(new UserOrderViewModel() 
                {
                    Id = order.Id,
                    Address = order.Adress,
                    Name = order.Name,
                    Phone = order.Phone,
                    TotalSum = order.OrderItems.Sum(o => o.Price * o.Quantity)
                });
            }

            return View(userOrderModel);
        }
    }
}
