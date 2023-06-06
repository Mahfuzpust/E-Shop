using E_Shop.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private readonly ApplicationDBContext dBContext;
        public ProductTypesController(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public IActionResult Index()
        {
            var data = dBContext.ProductTypes.ToList();
            return View(data);
        }
    }
}
