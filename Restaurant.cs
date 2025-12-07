using System;

namespace Namespace
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string ImageFile { get; set; }
        public string Cuisine { get; set; }
        public string Description { get; set; }
        public string MapLink { get; set; }

        public Restaurant() { }

        public Restaurant(string name, string imageFile, string cuisine, string description, string mapLink)
        {
            Name = name;
            ImageFile = imageFile;
            Cuisine = cuisine;
            Description = description;
            MapLink = mapLink;
        }

        public override string ToString()
        {
            return $"{Name}\t{ImageFile}\t{Cuisine}\t{Description}\t{MapLink}";
        }

        public static Restaurant FromLine(string line)
        {
            var parts = line.Split('\t');
            if (parts.Length < 5)
                return null;

            return new Restaurant(parts[0], parts[1], parts[2], parts[3], parts[4]);
        }
    }
}
