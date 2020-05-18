using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parlit.Models
{
    public class User
    {

        [Key]
        public int userID {get; set;}
        public int userName { get; set; }

    }
}
