using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TeknoTrendWebApp.Models;
using TeknoTrendWebApp.Models.Base;

namespace TeknoTrendWebApp.Models
{
    public class Campaigns:Entity
    {
        [Display(Name = "Isim")]
        [StringLength(maximumLength: 75, ErrorMessage = "En fazla 75 karakter olmalıdır")]
        public string Name { get; set; }
        public int Brand_ID { get; set; }
        [ForeignKey("Brand_ID")]
        public virtual Brand Brand { get; set; }
        public int Category_ID { get; set; }
        [ForeignKey("Category_ID")]
        public virtual Category category { get; set; }

        [Display(Name = "Resim (150 X 150)")]
        [StringLength(maximumLength: 75)]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
    }
}