using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using Lesson1_Task1_MiddleWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.InfroStrucure.Services
{
    public class TotalProductService : ITotalProductService
    {
        private readonly ICartService _cartService;

        public TotalProductService(ICartService cartService)
        {
            _cartService = cartService;
        }

        public TotalInCarViewModel GetCartItemsSum()
        {
            var totalInCart = new TotalInCarViewModel();
            var r = _cartService.TransformCart();

            foreach (var item in r.Items)
            {
                totalInCart.TotalSum += item.Value * item.Key.Price;
                totalInCart.TotalQuantity += item.Value;
            }

            return totalInCart;
        }
    }
}
