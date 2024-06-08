using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeknoTrendWebApp.Models
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string InvoiceNumber { get; set; }
        public List<OrderDetailViewModel> OrderDetails { get; set; }
    }
}