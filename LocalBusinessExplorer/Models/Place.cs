using System.Collections.Generic;

namespace LocalBusinessExplorer.Models
{
    public class Place
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Geometry Geometry { get; set; }
        public double Rating { get; set; }
        public int UserRatingsTotal { get; set; }
        public List<string> Types { get; set; }
    }

    public class Geometry
    {
        public Location Location { get; set; }
    }

    public class Location
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class GooglePlaceResponse
    {
        public List<Place> Results { get; set; }
    }
}
