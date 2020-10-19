using System;
using System.ComponentModel.DataAnnotations;

namespace CardTech.ResearchSite.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Published { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdated { get; set; }

        public string Description { get; set; }
        public string FeaturedImage { get; set; }
        public bool Featured { get; set; }
    }