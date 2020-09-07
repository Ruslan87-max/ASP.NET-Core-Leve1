using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare.InfroStrucure.Services
{
    public class InMemoryProductService : IProductService
    {
        private readonly List<Category> _categories;
        private readonly List<Brand> _brands;
        private readonly List<Product> _products;

        public InMemoryProductService()
        {
            _categories = new List<Category>();

            #region Инициализация коллекции _categories
            _categories.Add(new Category()
            {
                Id = 1,
                Name = "Sportswear",
                Order = 0,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 2,
                Name = "Nike",
                Order = 0,
                ParentID = 1
            });

            _categories.Add(new Category()
            {
                Id = 3,
                Name = "Under Armour",
                Order = 1,
                ParentID = 1
            });

            _categories.Add(new Category()
            {
                Id = 4,
                Name = "Adidas",
                Order = 2,
                ParentID = 1
            });

            _categories.Add(new Category()
            {
                Id = 5,
                Name = "Puma",
                Order = 3,
                ParentID = 1
            });

            _categories.Add(new Category()
            {
                Id = 6,
                Name = "Asics",
                Order = 4,
                ParentID = 1
            });

            _categories.Add(new Category()
            {
                Id = 7,
                Name = "Mens",
                Order = 1,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 8,
                Name = "Fendi",
                Order = 0,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 9,
                Name = "Guess",
                Order = 1,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 10,
                Name = "Valentino",
                Order = 2,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 11,
                Name = "Dior",
                Order = 3,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 12,
                Name = "Versace",
                Order = 4,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 13,
                Name = "Armani",
                Order = 5,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 14,
                Name = "Prada",
                Order = 6,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 15,
                Name = "DolceE AndD Gabbana",
                Order = 7,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 16,
                Name = "Chanel",
                Order = 8,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 17,
                Name = "Gucci",
                Order = 9,
                ParentID = 7
            });

            _categories.Add(new Category()
            {
                Id = 18,
                Name = "Womens",
                Order = 2,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 19,
                Name = "Fendi",
                Order = 0,
                ParentID = 18
            });

            _categories.Add(new Category()
            {
                Id = 20,
                Name = "Guess",
                Order = 1,
                ParentID = 18
            });

            _categories.Add(new Category()
            {
                Id = 21,
                Name = "Valentino",
                Order = 2,
                ParentID = 18
            });

            _categories.Add(new Category()
            {
                Id = 22,
                Name = "Dior",
                Order = 3,
                ParentID = 18
            });

            _categories.Add(new Category()
            {
                Id = 23,
                Name = "Versace",
                Order = 4,
                ParentID = 18
            });

            _categories.Add(new Category()
            {
                Id = 24,
                Name = "Kids",
                Order = 3,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 25,
                Name = "Fashion",
                Order = 4,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 26,
                Name = "Households",
                Order = 5,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 27,
                Name = "Interiors",
                Order = 6,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 28,
                Name = "Clothing",
                Order = 7,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 29,
                Name = "Bags",
                Order = 8,
                ParentID = null
            });

            _categories.Add(new Category()
            {
                Id = 30,
                Name = "Shoes",
                Order = 9,
                ParentID = null
            });
            #endregion
            #region Инициализация коллекции _brands

            _brands = new List<Brand>();

            _brands.Add(new Brand()
            {
                Id = 1,
                Name = "Acne",
                Order = 0,
            });

            _brands.Add(new Brand()
            {
                Id = 2,
                Name = "Ggrüne Erde",
                Order = 1
            });

            _brands.Add(new Brand()
            {
                Id = 3,
                Name = "Albiro",
                Order = 2
            });

            _brands.Add(new Brand()
            {
                Id = 4,
                Name = "Ronhill",
                Order = 3
            });

            _brands.Add(new Brand()
            {
                Id = 5,
                Name = "OddMolly",
                Order = 4
            });

            _brands.Add(new Brand()
            {
                Id = 6,
                Name = "BoudEstijn",
                Order = 5
            });

            _brands.Add(new Brand()
            {
                Id = 7,
                Name = "Rösch Creative Culture",
                Order = 6
            });
            #endregion
            #region Инициализация коллекции _products

            _products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product1.jpg",
                    Order = 0,
                    CategoryId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product2.jpg",
                    Order = 1,
                    CategoryId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product3.jpg",
                    Order = 2,
                    CategoryId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product4.jpg",
                    Order = 3,
                    CategoryId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product5.jpg",
                    Order = 4,
                    CategoryId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 6,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product6.jpg",
                    Order = 5,
                    CategoryId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 7,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product7.jpg",
                    Order = 6,
                    CategoryId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 8,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product8.jpg",
                    Order = 7,
                    CategoryId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 9,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product9.jpg",
                    Order = 8,
                    CategoryId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 10,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product10.jpg",
                    Order = 9,
                    CategoryId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    Id = 11,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product11.jpg",
                    Order = 10,
                    CategoryId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    Id = 12,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product12.jpg",
                    Order = 11,
                    CategoryId = 25,
                    BrandId = 3
                },
            };
            #endregion
        }
        public IEnumerable<Brand> GetBrands()
        {
            return _brands;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var products = _products;

            if (filter.CategoryId.HasValue)
                products = products.Where(e => e.CategoryId.Equals(filter.CategoryId)).ToList();

            if (filter.BrandId.HasValue)
                products = products.Where(e => e.BrandId.HasValue && e.BrandId.Value == filter.BrandId.Value).ToList();

            return products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
