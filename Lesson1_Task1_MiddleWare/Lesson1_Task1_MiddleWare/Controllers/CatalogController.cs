﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;
        public CatalogController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Shop(int? categoryId, int? brandId)
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

            //ViewBag.ProductsCount = model.Products.Count();

            return View(model);
        }
        public IActionResult ProductDetails()
        {
            return View();
        }
    }
}