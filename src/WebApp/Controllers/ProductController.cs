using SimpleCommerce.Service;
using SimpleCommerce.Service.ViewModel;
using System;
using System.Web.Mvc;

namespace SimpleCommerce.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            var items = _service.GetProducts();
            return View(items);
        }


        public ActionResult Create()
        {
            return View(new ProductEditViewModel()
            {
                Product = new ProductViewModel(),
                Categories = _service.GetCategories()

            });
        }


        [HttpPost]
        public ActionResult Create(ProductEditViewModel viewModel)
        {
            try
            {
                var model = new ProductViewModel()
                {
                    CategoryId = viewModel.Product.CategoryId,
                    Number = viewModel.Product.Number,
                    Price = viewModel.Product.Price,
                    Title = viewModel.Product.Title
                };

                _service.AddProduct(model);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                viewModel.Categories = _service.GetCategories();

                return View(viewModel);
            }
        }


        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_service.GetProduct(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductEditViewModel viewModel)
        {
            try
            {
                _service.UpdateProduct(viewModel.Product);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                viewModel.Categories = _service.GetCategories();
                return View(viewModel);
            }

        }
    }
}