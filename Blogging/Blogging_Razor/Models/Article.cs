using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogging_Razor.Models
{
    public class Article
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان مقاله")]
        [Required(ErrorMessage = "لطفا{0} مقاله را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "عکس")]
        [Required(ErrorMessage = "لطفا{0} مقاله را وارد کنید")]
        public string Picture { get; set; }
        [Display(Name = "alt عکس")]
        public string PictureAlt { get; set; }
        [Display(Name = "عنوان عکس")]
        public string PictureTitle { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Display(Name = "توضیحات کوتاه")]
        [Required(ErrorMessage = "لطفا{0} مقاله را وارد کنید")]
        public string ShortDescription { get; set; }
        [Display(Name = "متن مقاله")]
        public string Body { get; set; }
        public bool IsDeleted { get; set; }

        public Article()
        {
            IsDeleted = false;
        }
    }
}
