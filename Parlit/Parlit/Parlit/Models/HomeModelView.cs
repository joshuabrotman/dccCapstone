using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parlit.Models
{
    public class HomeModelView
    {
        public IEnumerable<Submission> submissions { get; set; }
        public IEnumerable<VoteTally> votetally { get; set; }
    }
}
