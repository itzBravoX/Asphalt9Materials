//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asphalt_9_Materials.ViewModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class StarRank
    {
        public int id { get; set; }
        public Nullable<int> StockStarRank { get; set; }
        public Nullable<int> FirstStarRank { get; set; }
        public Nullable<int> SecondStarRank { get; set; }
        public Nullable<int> ThirdStarRank { get; set; }
        public Nullable<int> FourthStarRank { get; set; }
        public Nullable<int> FifthStarRank { get; set; }
        public Nullable<int> SixthStarRank { get; set; }
        public Nullable<int> Max { get; set; }
    
        public virtual Grande Grande { get; set; }
    }
}
