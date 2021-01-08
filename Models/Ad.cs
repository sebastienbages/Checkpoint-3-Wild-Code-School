using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint3.Models
{
    public class Ad
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}
