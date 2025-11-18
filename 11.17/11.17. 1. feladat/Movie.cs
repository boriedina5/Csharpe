using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._17._1._feladat
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int  ReleaseYear { get; set; }

        public Movie(string t, string g, int ry) {
            Title = t;
            Genre = g;
            ReleaseYear = ry;
        }

        public override string ToString() {
            return $"{Title} - {Genre}, {ReleaseYear}";
        }
    }
}
