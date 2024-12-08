using DesingPattern.Composite.CompositePattern;
using DesingPattern.Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesingPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;
        public DefaultController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.Include(x => x.Products).ToList();
            var values = Rekursive(categories,new Category { CategoryName ="First Category",CategoryId=0},new ProductComposite ( 0,"FirstComposite"));
            ViewBag.v = values;
            return View();
        }
        public ProductComposite Rekursive(List<Category> categories,Category firstCategory,ProductComposite firstComposite,ProductComposite leaf=null)
        {
            categories.Where(x => x.UpperCategoryId == firstCategory.CategoryId).ToList().ForEach
                (y =>
                {
                    var productComposite = new ProductComposite(y.CategoryId, y.CategoryName);
                    y.Products.ToList().ForEach(z =>
                    {
                        productComposite.Add(new ProductComponent(z.ProductId,z.ProductName));
                    });

                    if(leaf != null)
                    {
                        leaf.Add(productComposite);
                    }
                    else
                    {
                        firstComposite.Add(productComposite);
                    }
                    Rekursive(categories, y, firstComposite, productComposite);
                });
            return firstComposite;
        }
    }
}
