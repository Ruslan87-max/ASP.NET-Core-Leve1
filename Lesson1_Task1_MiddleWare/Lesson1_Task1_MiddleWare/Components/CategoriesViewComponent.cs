using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using Lesson1_Task1_MiddleWare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_Task1_MiddleWare.Components
{
    [ViewComponent(Name = "Cats")] //Custom'ное имя, не зависящее от имени класса
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public CategoriesViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Categories = GetCategories();
            return View(Categories);
        }

        private List<CategoryViewModel> GetCategories()
        {
            var categgories = _productService.GetCategories();  //Подучаем весь список категорий.

            //Делаем выборку родительских категорий: 
            var parentSections = categgories.Where(e => !e.ParentID.HasValue).ToArray();
            var parentCategories = new List<CategoryViewModel>();

            foreach (var parentCategory in parentSections)
            {
                //Получим и заполним родительские категории:
                parentCategories.Add(new CategoryViewModel() /*Пустые списки ChildCategories дочерних категорий проинициализированы в конструкторе 
                                                              * new CategoryViewModel() ... */
                {
                    Id = parentCategory.Id,
                    Name = parentCategory.Name,
                    Order = parentCategory.Order,
                    ParentCategory = null
                });
            }

            //Получим и заполним дочерние категории:
            foreach (var CategoryViewModel in parentCategories)
            {
                var childCategories = categgories.Where(e => e.ParentID == CategoryViewModel.Id);

                foreach (var childCatrgory in childCategories)
                {
                    CategoryViewModel.ChildCategories.Add(new CategoryViewModel()
                    {
                        Id = childCatrgory.Id,
                        Name = childCatrgory.Name,
                        Order = childCatrgory.Order,
                        ParentCategory = CategoryViewModel
                    });
                }
                CategoryViewModel.ChildCategories = CategoryViewModel.ChildCategories.OrderBy(c => c.Order).ToList();
            }
            parentCategories = parentCategories.OrderBy(c => c.Order).ToList();
            return parentCategories;
        }
    }
}
