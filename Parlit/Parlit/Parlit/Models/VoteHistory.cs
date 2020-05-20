using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlit.Models
{
    public class VoteHistory
    {
        [Key]
        public int voteHistoryID { get; set; }
        public DateTime voteHistoryDate { get; set; }
        public bool voteHistoryValue { get; set; }
        [ForeignKey("Parlitor")]
        public int parlitorID { get; set; }
        [ForeignKey("Submission")]
        public int submissionID { get; set; }
    }
}
