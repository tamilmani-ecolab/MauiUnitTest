using System;
namespace SamplePrismApp.Models
{
    public class Items
    {
        public int id { get; set; }
        public string productCategory { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public int basePrice { get; set; }
        public bool inStock { get; set; }
        public int stock { get; set; }
        public string featuredImage { get; set; }
        public string thumbnailImage { get; set; }
        public List<string> storageOptions { get; set; }
        public List<string> colorOptions { get; set; }
        public string display { get; set; }
        public string CPU { get; set; }
        public Camera camera { get; set; }
        public string GPU { get; set; }
    }

    public class Camera
    {
        public string rearCamera { get; set; }
        public string frontCamera { get; set; }
    }
}

