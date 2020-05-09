using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLab1.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public double Price { get; set; }
    }
}
