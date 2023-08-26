using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConsoleMVC.BL.ModelVM
{
    public class PostVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "minimum lenth is 10")]
        public string body { get; set; }
        public bool IsDleted { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
