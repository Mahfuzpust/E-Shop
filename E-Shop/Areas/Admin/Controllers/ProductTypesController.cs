using E_Shop.Data;
using E_Shop.Models;
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

        //Get Method Product Types Create
        public IActionResult Create()
        {
            return View();
        }

        //Post Method Product Types
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTypes model)
        {
            if (ModelState.IsValid)
            {
                dBContext.ProductTypes.Add(model);
                await dBContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }
    }
}
