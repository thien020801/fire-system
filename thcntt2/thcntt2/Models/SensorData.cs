//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace thcntt2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SensorData
    {
        public int id { get; set; }
        public Nullable<double> temperature { get; set; }
        public Nullable<double> humid { get; set; }
        public Nullable<System.DateTime> time { get; set; }
        public string farmid { get; set; }
    }
}
