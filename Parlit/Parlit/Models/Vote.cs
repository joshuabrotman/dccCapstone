using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlit.Models
{
    public class Vote
    {

        [Key]
        public int voteID { get; set; }
        public DateTime voteDate { get; set; }
        public bool voteValue { get; set; }
        [ForeignKey("User")]
        public int userID { get; set; }
        [ForeignKey("Post")]
        public int postID { get; set; }

    }
}
