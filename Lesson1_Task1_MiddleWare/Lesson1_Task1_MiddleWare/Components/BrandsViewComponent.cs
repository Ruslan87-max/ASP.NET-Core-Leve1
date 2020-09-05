using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.Components
{
    [ViewComponent(Name = "Brds")]
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        public BrandsViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var _products = GetBrands();
            return View(_products);
        }

        public IEnumerable<BrandViewModel> GetBrands()
        {
            var brands = _productService.GetBrands();

            var brandViewModel = new List<BrandViewModel>();

            foreach (var item in brands)
            {
                brandViewModel.Add(new BrandViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Order = item.Order,
                    Count = _productService.GetAllProducts().Where(p => p.BrandId == item.Id).Count()
                }); 
            }
                        
            brandViewModel = brandViewModel.OrderBy(e => e.Order).ToList();
            return brandViewModel;
        }
    }
}
