using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;
using ProductManager.Services;
 
namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
 
        public IActionResult Index()
        {
            Console.WriteLine("+++++===================");
            var products = _productService.GetProducts();
            return View(products);
        }
 
        public IActionResult Create()
        {
            Console.WriteLine("+++++===================");
            var categories = _productService.GetCategories();
            return View(categories);
        }
 
        public IActionResult Update(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null) return RedirectToAction("Create");
            var categories = _productService.GetCategories();
            ViewBag.Categories = categories;
            return View(product);
        }
 
        public IActionResult Save(Product product)
        {
            Console.WriteLine("++++++++=");
            _productService.CreateProduct(product);
            return RedirectToAction("Index");
        }
    }
}
