using Lab3.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Framework_Lab2.Controllers
{
    public class TaskController : Controller
    {
        private readonly TodoAppContext context;
        public TaskController(TodoAppContext context)
        {
            this.context = context;
        }
        
        public IActionResult Index()
        {
            var tasklist = context.tasks.Include(t => t.category).Include(t => t.tags).ToList();
            return View(tasklist);
        }

        public IActionResult Create()
        {
            ViewBag.categories = context.categories.ToList();
            ViewBag.tags = context.tags.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Store(Lab3.Models.Task task, int[] tagIds)
        {
            task.created_at = DateTime.Now;
            task.updated_at = DateTime.Now;
            task.category = context.categories.Where(c => c.id == task.category.id).FirstOrDefault();
            if (tagIds != null && tagIds.Length > 0)
            {
                task.tags = context.tags.Where(t => tagIds.Contains(t.id)).ToList();
            }
            context.tasks.Add(task);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.categories = context.categories.ToList();
            ViewBag.tags = context.tags.ToList();
            var task = context.tasks.Where(t=>t.id == id).Include(t => t.category).Include(t => t.tags).FirstOrDefault();
            if(task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost]
        public IActionResult Update(Lab3.Models.Task task, int[] tagIds)
        {
            var dbTask = context.tasks.Include(t => t.tags).FirstOrDefault(t=>t.id == task.id);
            if (dbTask == null)
            {
                return NotFound();
            }
            dbTask.title = task.title;
            dbTask.description = task.description;
            dbTask.updated_at = DateTime.Now;
            dbTask.category = context.categories.Where(c => c.id == task.category.id).FirstOrDefault();
            if (tagIds != null && tagIds.Length > 0)
            {
                dbTask.tags = context.tags.Where(t => tagIds.Contains(t.id)).ToList();
            }
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        
        public IActionResult Destroy(int id)
        {
            var task = context.tasks.FirstOrDefault(t => t.id == id);

            if (task == null)
            {
                return NotFound();
            }
            context.tasks.Remove(task);

            context.SaveChanges();
            return RedirectToAction("Index", "Task");
        }
        
        public IActionResult IdValidate(int? id)
        {
            if(id != 0)return Content($"ID-ul = {id}");
            else return Content($"Nu exista id");
        }
    }
}
