using BussinessObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPage.Pages
{
    public class ShoppingProductModel : PageModel
    {
        IProductRepository productRepository = new ProductRepository();
        public List<Product> Products;
        public IActionResult OnGet()
        {
            Products = productRepository.GetAll();
            return Page();
        }
    }
}
