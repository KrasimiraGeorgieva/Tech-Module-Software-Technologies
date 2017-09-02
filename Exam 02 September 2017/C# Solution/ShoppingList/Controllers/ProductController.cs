using System.Linq;
using System.Web.Mvc;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    [ValidateInput(false)]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var database = new ShoppingListDbContext())
            {
                var films = database.Products.ToList();

                return View(films);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                using (var database = new ShoppingListDbContext())
                {
                    database.Products.Add(product);
                    database.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            using (var database = new ShoppingListDbContext())
            {
                Product film = database.Products.Find(id);

                if (film == null)
                {
                    return RedirectToAction("Index");
                }

                return View(film);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Product productModel)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                using (var database = new ShoppingListDbContext())
                {
                    Product filmFromDb = database.Products.Find(id);

                    if (filmFromDb == null)
                    {
                        return RedirectToAction("Index");
                    }

                    filmFromDb.Priority = productModel.Priority;
                    filmFromDb.Name = productModel.Name;
                    filmFromDb.Quantity = productModel.Quantity;
                    filmFromDb.Status = productModel.Status;

                    database.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}