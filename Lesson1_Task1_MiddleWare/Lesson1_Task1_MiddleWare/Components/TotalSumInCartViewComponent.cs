using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Components
{
    public class TotalSumInCartViewComponent : ViewComponent
    {
        private readonly ITotalProductService _productService;
        public TotalSumInCartViewComponent(ITotalProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var _products = _productService.GetCartItemsSum();
            return View(_products);
        }
    }
}
