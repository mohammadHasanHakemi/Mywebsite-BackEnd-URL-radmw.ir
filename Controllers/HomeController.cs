using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMvcProject.Models;

namespace MyMvcProject.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // صفحه اصلی برای نمایش لیست آلبوم‌ها
 // مطمئن شوید namespace درست است

    public IActionResult Index()
    {
        var model = new AlbumMusicViewModel
        {
            Albums = _context.Albums.ToList(),
            Musics = _context.Music.ToList()
        };

        return View(model);
    }

    }

}
