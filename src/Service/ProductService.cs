using AutoMapper;
using SimpleCommerce.Data;
using SimpleCommerce.Repository;
using SimpleCommerce.Repository.Repositories.Interfaces;
using SimpleCommerce.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SimpleCommerce.Model;

namespace SimpleCommerce.Service
{
    public class ProductService : IProductService
    {
        private SimpleCommerceContext _ctx;

        private ICategoryRepository _categoryRepository;

        private IProductRepository _productRepository;

        public ProductService()
        {
            _ctx = new SimpleCommerceContext() ;
            _categoryRepository = new CategoryRepository(_ctx);
            _productRepository = new ProductRepository(_ctx);

        }

        public void SaveData()
        {
            _ctx.SaveChanges();
        }

        public List<CategoryViewModel> GetCategories()
        {
            var data = _categoryRepository.Get();

            var dataMapped = Mapper.Map<List<CategoryViewModel>>(data);

            return dataMapped;
        }



        public ListProductViewModel GetProducts()
        {
            var data = _productRepository.Get();

            var dataMapped = Mapper.Map<ICollection<ProductViewModel>>(data);

            return new ListProductViewModel() { Products = dataMapped };
        }

        public ProductEditViewModel GetProduct(long id)
        {
            var dataProduct = _productRepository.Find(id);

            var dataProductMapped = Mapper.Map<ProductViewModel>(dataProduct);

            return new ProductEditViewModel()
            {
                Product = dataProductMapped,
                Categories = GetCategories()
            };
        }

        public void UpdateProduct(ProductViewModel viewmodel)
        {
            _productRepository.Update(new Product()
            {
                Id = viewmodel.Id,
                CategoryId = viewmodel.CategoryId,
                Category = new Category() { Id = viewmodel.CategoryId },
                Number = viewmodel.Number,
                Price = viewmodel.Price,
                Title = viewmodel.Title
            });
            SaveData();
        }


        public void AddProduct(ProductViewModel viewmodel)
        {
            _productRepository.Create(new Product()
            {
                CategoryId = viewmodel.CategoryId,
                Number = viewmodel.Number,
                Price = viewmodel.Price,
                Title = viewmodel.Title
            });

            SaveData();
        }

        public void DeleteProduct(long id)
        {
            var record = _productRepository.Find(id);
            record.Deleted = true;
            _productRepository.Update(record);

            SaveData();
        }
    }
}
