using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smarty.Business.SmartyIntegration.Response
{
    public class Metadata
    {
        public string RecordType { get; set; }
        public string ZipType { get; set; }
        public string CountyFips { get; set; }
        public string CountyName { get; set; }
        public string CarrierRoute { get; set; }
        public string CongressionalDistrict { get; set; }
        public string Rdi { get; set; }
        public string ElotSequence { get; set; }
        public string ElotSort { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Precision { get; set; }
        public string TimeZone { get; set; }
        public int UtcOffset { get; set; }
        public bool Dst { get; set; }
    }
}