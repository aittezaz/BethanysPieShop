﻿using System.ComponentModel;

namespace BethanysPieShop.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        public string? Name { get; set;}
        public  string? ShortDescription { get; set;}
        public string? LongDescription { get; set; }
        public string? AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool Stock { get; set; }
        public int CategoryId { get; set;}
        public Category? category{ get; set; }
    }
}
