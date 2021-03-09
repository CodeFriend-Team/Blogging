using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogging_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Blogging_Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlogContext _context;
        public List<Article> Articles { get; set; }
        public IndexModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            
            Articles = _context.Articles.Where(x=>x.IsDeleted == false).Select(x=> new Article() {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
            }).ToList();
        }
        public IActionResult OnGetDelete(int id)
        {
            var remove = _context.Articles.FirstOrDefault(x=>x.Id == id);
            remove.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToPage("./index");

        }
    }
}
