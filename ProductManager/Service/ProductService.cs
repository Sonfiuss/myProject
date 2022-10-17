using ProductManager.Models;
 
namespace ProductManager.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
 
        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            Console.WriteLine("===================");
            Console.WriteLine(product.ID);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.CategoryId);
            Console.WriteLine("================");
            _context.SaveChanges();
        }
 
        public void DeleteProduct(int id)
        {
            var existedProduct = GetProductById(id);
            if (existedProduct == null) return;
            _context.Products.Remove(existedProduct);
            _context.SaveChanges();
        }
 
        public Product? GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ID == id);
        }
 
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
 
        public void UpdateProduct(Product product)
        {
            var existedProduct = GetProductById(product.ID);
            if (existedProduct == null) return;
            existedProduct.Name = product.Name;
            existedProduct.Slug = product.Slug;
            existedProduct.Price = product.Price;
            existedProduct.Quantity = product.Quantity;
            existedProduct.CategoryId = product.CategoryId;
            
            _context.Update(existedProduct);
            _context.SaveChanges();
        }
 
        public List<Category> GetCategories()
        {
            return _context.Category.ToList();
        }
    }
}
