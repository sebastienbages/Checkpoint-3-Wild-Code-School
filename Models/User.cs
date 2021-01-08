using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint3.Models
{
    public class User : IdentityUser
    {
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public ICollection<Ad> Ads { get; set; }
    }
}
