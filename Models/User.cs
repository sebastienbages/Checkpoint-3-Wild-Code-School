using System.Collections.Generic;

namespace checkpoint3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Ad> Ads { get; set; }
    }
}