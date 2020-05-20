using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlit.Models
{
    public class Submission
    {
        [Key]
        public int submissionID { get; set; }
        [ForeignKey("Parlitor")]
        public int parlitorID { get; set; }
        public DateTime timeSubmitted { get; set; }
        public string content { get; set; }
        public string URL { get; set; }
        public string category { get; set; }
        public bool hypostasis { get; set; }
    }
}
