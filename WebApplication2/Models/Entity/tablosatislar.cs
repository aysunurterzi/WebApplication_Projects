//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tablosatislar
    {
        public int satisid { get; set; }
        public Nullable<int> ürün { get; set; }
        public Nullable<int> müsteri { get; set; }
        public Nullable<byte> adet { get; set; }
        public Nullable<decimal> fiyat { get; set; }
    
        public virtual tablomüsteriler tablomüsteriler { get; set; }
        public virtual tabloürünler tabloürünler { get; set; }
    }
}
