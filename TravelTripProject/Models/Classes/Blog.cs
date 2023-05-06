using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Heading { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogImange { get; set; }
        public ICollection<Comments> Commentss { get; set;}
    }
}