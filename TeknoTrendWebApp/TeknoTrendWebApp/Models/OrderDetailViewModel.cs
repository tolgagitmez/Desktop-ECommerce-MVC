﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeknoTrendWebApp.Models
{
    public class OrderDetailViewModel
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}