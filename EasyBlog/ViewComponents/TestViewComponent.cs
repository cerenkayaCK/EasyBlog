using EasyBlog.Data;
using Microsoft.AspNetCore.Mvc;

namespace EasyBlog.Component
{
    public class TestViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public TestViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            return View(_db.Categories.ToList());
        }

    }
}
