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

        //Get Method Product Types Edit
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProductType = dBContext.ProductTypes.FirstOrDefault(e => e.Id == id);
            if (ProductType == null)
            {
                return NotFound();
            }
            return View(ProductType);
        }
        //Post Method Edit 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes model)
        {
            if (ModelState.IsValid)
            {
                dBContext.ProductTypes.Update(model);
                await dBContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        //Get Method Product Types Details
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProductType = dBContext.ProductTypes.FirstOrDefault(e => e.Id == id);
            if (ProductType == null)
            {
                return NotFound();
            }
            return View(ProductType);
        }
        //Post Method Details 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductTypes model)
        {
            return RedirectToAction(nameof(Index));
        }

        //Delete Product Types
        public IActionResult Delete(int? id, ProductTypes model)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            if (id != model.Id)
            {

            }
            var ProductType = dBContext.ProductTypes.FirstOrDefault(e => e.Id == id);
            if (ProductType == null)
            {
                return NotFound();
            }
            return View(ProductType);
        }

        //Post Method Delete 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ProductTypes model)
        {
            if (ModelState.IsValid)
            {
                dBContext.ProductTypes.Remove(model);
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
