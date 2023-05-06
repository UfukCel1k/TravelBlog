using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> value1 { get; set; }
        public IEnumerable<Comments> value2 { get; set; }
        public IEnumerable<Blog> value3 { get; set; }
    }
}