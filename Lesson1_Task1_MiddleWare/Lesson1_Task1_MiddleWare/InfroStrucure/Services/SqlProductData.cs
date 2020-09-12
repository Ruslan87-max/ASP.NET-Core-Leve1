using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.InfroStrucure.Services
{
    public class SqlProductData : IProductService
    {
        private readonly WebStoreContext _context;

        public SqlProductData(WebStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products.AsQueryable();

            if (filter.BrandId.HasValue)
                query = query.Where(p => p.BrandId.HasValue && p.BrandId.Value.Equals(filter.BrandId.Value));

            if (filter.CategoryId.HasValue)
                query = query.Where(p => p.Categories.Equals(filter.CategoryId.Value));

            return query.ToList();

        }
    }
}
