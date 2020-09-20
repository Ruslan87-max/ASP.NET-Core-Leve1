using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.Controllers
{    
    public class StoreController : Controller
    {
        private readonly IProductService _productService;
        public StoreController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int? categoryId, int? brandId)
        {
            //Получаем список отфильтрованных продуктов
            var products = _productService.GetProducts(
                new ProductFilter
                {
                    BrandId = brandId,
                    CategoryId = categoryId
                });

            //Конвертируем в CtatlogViewModel
            var model = new CatalogViewModel()
            {
                BrandId = brandId,
                CategorydId = categoryId,
                Products = products.Select(p => new ProductViewModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price
                }).OrderBy(p => p.Order).ToList()

            };

            return View(model);
        }
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogSingle()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();

        }
        public IActionResult Login()
        {
            return View();

        }
        public IActionResult NotFound404()
        {
            return View();

        }
        public IActionResult ProductDetails()
        {
            return View();

        }
        public IActionResult Shop()
        {
            return View();

        }
    }
}
