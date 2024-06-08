﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeknoTrendWebApp.Models
{
    public class ProductImage
    {
        public int ID { get; set; }

        public int Product_ID { get; set; }
        [ForeignKey("Product_ID")]
        public virtual Product Product { get; set; }

        [Display(Name = "Resim (150 X 150)")]
        [StringLength(maximumLength: 75)]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        public bool isListImage { get; set; }
    }
}