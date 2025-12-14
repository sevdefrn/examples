using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;
using System.CodeDom;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _products = new List<Product>
        {
            new Product{Id=1, Name="Çikolatalı Pasta"},
            new Product{Id=2, Name="Böğürtlenli Pasta"},
            new Product{Id=3, Name="Frambuazlı Pasta"},
            new Product{Id=4, Name="Çilekli Pasta"},
            new Product{Id=5, Name="Yaban Mersinli Pasta"},
            new Product{Id=6, Name="Profiterol"},
            new Product{Id=7, Name="Limonlu Cheesecake"},
            new Product{Id=8, Name="Frambuazlı Cheesecake"},
            new Product{Id=9, Name="Yaban Mersinli Rolls"},
            new Product{Id=10, Name="Ekler"},
            new Product{Id=11, Name="Sufle"},
            new Product{Id=12, Name="Americano"},
            new Product{Id=13, Name="Flat White"},
            new Product{Id=14, Name="Türk Kahvesi"},
            new Product{Id=15, Name="White Mocha"},
        };
        private static int _idCounter = 16;

        //Listeleme
        public IActionResult Index()
        {
            return View(_products);
        }

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            model.Id = _idCounter;
            _idCounter++;
            _products.Add(model);
            return RedirectToAction("Index");
        }
        #endregion

        #region UpDate
        public IActionResult Update(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            var product = _products.FirstOrDefault(x => x.Id == model.Id);
            if (product != null)
            {
                product.Name = model.Name;
            }
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product model)
        {
            var product = _products.FirstOrDefault(x => x.Id == model.Id);
            if (product != null)
            {
                _products.Remove(product);
            }
            return RedirectToAction("Index");
        }
        #endregion
    }
}
