using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogging_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogging_Razor.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public Article Article { get; set; }
        private readonly BlogContext _context;
        public ArticleDetailsModel(BlogContext Context)
        {
            _context = Context;
        }
        public void OnGet(int id)
        {
            Article = _context.Articles.Select(x=>new Article() { 
                Id = id,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Body = x.Body
            }).FirstOrDefault(x => x.Id == id);
        }
        
    }
}
