using System;

namespace BaiTapThietKeDam.Models
{
    public class EtabsAPI_PropFrame
    {
        public string SectionName { get; set; }
        public double Width { get; set; }  
        public double Height { get; set; } 
        public double ATOP { get; set; }   // a trên
        public double ABOT { get; set; }   // a dưới

        public double H0 => Height - ABOT; // Chiều cao làm việc h0
    }
}