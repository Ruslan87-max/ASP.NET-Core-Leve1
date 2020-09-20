using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1_Task1_MiddleWare.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Details()
        {
            return View("Details", _cartService.TransformCart());
        }

        public IActionResult DecrementFromCart(int id)
        {
            _cartService.DecrementFromCart(id);
            return RedirectToAction("Details");
        }

        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id);
            return RedirectToAction("Details");
        }

        public IActionResult RemoveAll()
        {
            _cartService.RemoveAll();
            return RedirectToAction("Details");
        }

        public IActionResult AddToCart(int id, string returnUrl)
        {
            _cartService.AddToCart(id);
            return Redirect(returnUrl);
        }
    }
}
