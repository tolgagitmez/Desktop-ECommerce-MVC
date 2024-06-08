using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeknoTrendWebApp.Models
{
    public class ManagerType
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Boş Bırakılamaz")]
        [StringLength(maximumLength: 50, ErrorMessage = "En Fazla 50 karakter olmalıdır")]
        public string Name { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}