//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknolojiMarketim
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public partial class Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            this.Alimlars = new HashSet<Alimlar>();
            this.SatisDetaylars = new HashSet<SatisDetaylar>();
        }

        [XmlElement]
        public int ID { get; set; }
        [XmlElement]
        public Nullable<int> Kategori_ID { get; set; }
        [XmlElement]
        public Nullable<int> Marka_ID { get; set; }
        [XmlElement]
        public Nullable<int> Tedarikci_ID { get; set; }
        [XmlElement]
        public string UrunAdi { get; set; }
        [XmlElement]
        public Nullable<decimal> BirimFiyat { get; set; }
        [XmlElement]
        public Nullable<int> StokMiktari { get; set; }
        [XmlElement]
        public Nullable<int> GuvenlikStogu { get; set; }
        [XmlElement]
        public Nullable<bool> IsActive { get; set; }
        [XmlElement]
        public Nullable<bool> IsDeleted { get; set; }
        [XmlElement]
        public string BarkodNo { get; set; }
        [XmlElement]
        public string Resim { get; set; }

        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alimlar> Alimlars { get; set; }
        [XmlIgnore]
        public virtual Kategoriler Kategoriler { get; set; }
        [XmlIgnore]
        public virtual Markalar Markalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore]
        public virtual ICollection<SatisDetaylar> SatisDetaylars { get; set; }
        [XmlIgnore]
        public virtual Tedarikciler Tedarikciler { get; set; }
    }
}
