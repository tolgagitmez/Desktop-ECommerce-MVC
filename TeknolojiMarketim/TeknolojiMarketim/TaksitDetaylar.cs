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
    
    public partial class TaksitDetaylar
    {
        public int TaksitID { get; set; }
        public Nullable<int> SatisID { get; set; }
        public Nullable<int> SatislarID { get; set; }
        public Nullable<System.DateTime> TaksitTarihi { get; set; }
        public Nullable<decimal> TaksitMiktari { get; set; }
        public Nullable<bool> OdendiMi { get; set; }
    
        public virtual Satislar Satislar { get; set; }
        public virtual TaksitliSatislar TaksitliSatislar { get; set; }
    }
}
