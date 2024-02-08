using EasyBlog.Data;
using EasyBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace EasyBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _context = db;
        }

       
        public IActionResult Index(int? cid) 
        {
            IQueryable<Post> postsQuery = _context.Posts; 

            if (cid.HasValue)
            {
                var category = _context.Categories.FirstOrDefault(c => c.Id == cid.Value);
                TempData["CategoryExist"] = category.Name.ToString();
                postsQuery = postsQuery.Where(p => p.Category.Id == cid);
            }

            var posts = postsQuery.OrderByDescending(e => e.Id).ToList();

            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Post/{Id:int}")]
        public async Task<IActionResult> Show(int Id)
        {
            var selectedPost =await _context.Posts.Include(x=>x.Category).FirstOrDefaultAsync(x=>x.Id == Id);

            if (selectedPost == null)
            {
               return NotFound();
            }
            
            return View(selectedPost);
        }
    }
}
