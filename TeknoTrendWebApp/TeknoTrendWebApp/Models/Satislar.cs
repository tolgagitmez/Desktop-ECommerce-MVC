using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeknoTrendWebApp.Models
{
    public class Satislar
    {
        public int ID { get; set; }

        public int User_ID { get; set; }
        [ForeignKey("User_ID")]
        public virtual User user { get; set; }

        public DateTime Tarih { get; set; }

        public string FaturaNo { get; set; }
    }
}