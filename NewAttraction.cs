using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NewAttraction
    {
        public string City;
        public string Attraction;
        public string Link;
        public string Description;

        public NewAttraction(string City, string Attraction, string Link, string Description)
        {
            this.City = City;
            this.Attraction = Attraction;
            this.Link = Link;
            this.Description = Description;
        }

        public String getCity() { return City; }
        public String getAttraction() { return Attraction; }
        public String getLink() { return Link; }
        public String getDescription() { return Description; }

    }
}
