using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeknoTrendWebApp.Models;

namespace TeknoTrendWebApp.Areas.AdminPanel
{
    public class ConfirmXmlViewModel
    {
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}