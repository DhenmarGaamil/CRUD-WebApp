using Microsoft.AspNetCore.Mvc;
using Group1Pro.Data;
using Group1Pro.Models;
namespace Group1Pro.Controllers
{
    public class SubjectController : Controller
    {
        private ApplicationDbContext dbContext;

        public SubjectController(ApplicationDbContext dbContext) { 
         this.dbContext= dbContext;
        
        }

        public IActionResult Index()
        {
            var subject = dbContext.Subjects.ToList();
            return View(subject);
        }


        public IActionResult Add()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Add(Subject obj)
        {
            if (ModelState.IsValid)
{
                dbContext.Subjects.Add(obj);
                dbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();

        }


        public IActionResult Update(int Id) {
            Subject subject = dbContext.Subjects.Find(Id);
            return View(subject);
        }

        [HttpPost]
        public IActionResult Update(Subject obj)
        {
            if (ModelState.IsValid) {
                dbContext.Subjects.Update(obj);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            
            
            }

            return View(obj);

        }

        public IActionResult Delete(int Id)
        {
            Subject subject = dbContext.Subjects.Find(Id);
            if (subject == null)
            {
                return NotFound();
            }
            dbContext.Subjects.Remove(subject);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
