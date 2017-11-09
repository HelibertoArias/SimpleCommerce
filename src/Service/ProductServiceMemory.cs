using AutoMapper;
using SimpleCommerce.Service.ViewModel;
using System.Collections.Generic;
using SimpleCommerce.Model;

namespace SimpleCommerce.Service
{
    public class ProductServiceMemory : IProductService
    {
        public static List<Category> _categories = new List<Category>() { new Category() { Id = 1, Deleted = false, Name = "Cat 01" } };
        public static List<Product> _products = new List<Product>();

        public ProductServiceMemory()
        {
            

        }


        public List<CategoryViewModel> GetCategories()
        {
            var data = _categories;

            var dataMapped = Mapper.Map<List<CategoryViewModel>>(data);

            return dataMapped;
        }



        public ListProductViewModel GetProducts()
        {
            var data = _products;

            var dataMapped = Mapper.Map<ICollection<ProductViewModel>>(data);

            return new ListProductViewModel() { Products = dataMapped };
        }

        public ProductEditViewModel GetProduct(long id)
        {
            var dataProduct = _products.Find(x => x.Id == id);

            var dataProductMapped = Mapper.Map<ProductViewModel>(dataProduct);

            return new ProductEditViewModel()
            {
                Product = dataProductMapped,
                Categories = GetCategories()
            };
        }

        public void UpdateProduct(ProductViewModel viewmodel)
        {
            var dataProduct = _products.Find(x => x.Id == viewmodel.Id);

            dataProduct.CategoryId = viewmodel.CategoryId;
            dataProduct.Number = viewmodel.Number;
            dataProduct.Price = viewmodel.Price;
            dataProduct.Title = viewmodel.Title;
        }


        public void AddProduct(ProductViewModel viewmodel)
        {
            _products.Add(new Product()
            {
                CategoryId = viewmodel.CategoryId,
                Number = viewmodel.Number,
                Price = viewmodel.Price,
                Title = viewmodel.Title
            });
        }

        public void DeleteProduct(long id)
        {
            var record = _products.Find(x=>x.Id == id);
            _products.Remove(record);
        }
    }
}
