using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetoPortfolio.Models
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Image { get; set; }
        public string About { get; set; }

        public List<string> Skills { get; set; }
        public List<WorkPhoto> WorkPhotos { get; set; }
    }
}
