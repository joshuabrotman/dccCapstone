using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlit.Models
{
    public class VoteTally
    {
        [Key]
        public int voteTallyID { get; set; }
        [ForeignKey("Submission")]
        public int submissionID { get; set; }
        public int voteCount { get; set; }
    }
}
