using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parlit.Models
{
    public class Parlitor
    {
        [Key]
        public int parlitorID { get; set; }
        public int parlitorName { get; set; }
        public int rank { get; set; }
        public int upvotes { get; set; }

        [ForeignKey("IdentityUser")] public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
