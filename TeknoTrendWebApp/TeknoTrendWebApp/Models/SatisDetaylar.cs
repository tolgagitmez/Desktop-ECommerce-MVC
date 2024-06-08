using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeknoTrendWebApp.Models
{
    public class SatisDetaylar
    {
        public int ID { get; set; }
        public int Satis_ID { get; set; }
        [ForeignKey("Satis_ID")]
        public virtual Satislar satislar { get; set; }
        public int Urun_ID { get; set; }
        [ForeignKey("Urun_ID")]
        public virtual Product product { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}