using Blogging_Razor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Blogging_Razor.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly BlogContext _context;
        public Article Command { get; set; }
        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
        public void OnPost(Article Command)
        {
            Command.CreationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Articles.Add(Command);
                _context.SaveChanges();
                
                ViewData["Success"] = "عملیات با موفقیت شد.";
            }
            else
            {
                ViewData["Error"] = "عملیات با شکست مواجه شد.";
            }
        }
    }
}
