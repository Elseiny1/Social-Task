using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConsoleMVC_Task.DAL.Entities
{
    public class Post
    {
        //qolums
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(10,ErrorMessage ="minimum lenth is 10")]
        public string body { get; set; }
        public bool IsDleted { get; set; }
        public DateTime PublishDate { get; set; }

        //Relations

        List<Comment> Comments { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
       

    }
}
