using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookstoreAPI.Models
{
    public class BookReview
    {
        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerText { get; set; }
        public int Rating { get; set; }
        public DateTime PublishDate { get; set; }
    }
}