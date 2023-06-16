using E_Shop.Data;
using E_Shop.Models;
using E_Shop.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace E_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewProductController : Controller
    {
        private readonly ApplicationDBContext dBContext;
        private readonly IHostingEnvironment environment;
        public NewProductController(ApplicationDBContext dBContext, IHostingEnvironment environment)
        {
            this.dBContext = dBContext;
            this.environment = environment;
        }

        public IActionResult Index()
        {
            var data = dBContext.NewProduct.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ImageCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var path = environment.WebRootPath;
                var filePath = "Content/Image/" + model.ImagePath.FileName;
                var fullPath = Path.Combine(path, filePath);
                UploadFile(model.ImagePath, fullPath);
                var data = new NewProduct()
                {
                    Name = model.Name,
                    ImagePath = filePath,
                };
                dBContext.Add(data);
                dBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public void UploadFile(IFormFile file, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);
        }
    }
}
