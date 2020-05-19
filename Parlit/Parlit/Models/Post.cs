using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlit.Models
{
    public class Post
    {
        [Key]
        public int postID { get; set; }
        public DateTime postDate { get; set; }
        public string content { get; set; }
        [ForeignKey("User")]
        public int userID { get; set; }
        public string URL { get; set; }
        public string category { get; set; }
        public bool hypostasis { get; set; }

    }
}
