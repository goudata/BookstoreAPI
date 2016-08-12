using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookstoreAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HeadshotImageURL { get; set; }
    }
}