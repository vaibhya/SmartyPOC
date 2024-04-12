using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smarty.Business.SmartyIntegration.Response
{
    public class SmartyResponse
    {
        public int InputIndex { get; set; }
        public int CandidateIndex { get; set; }
        public string DeliveryLine1 { get; set; }
        public string LastLine { get; set; }
        public string DeliveryPointBarcode { get; set; }
        public string SmartyKey { get; set; }
        public Components Components { get; set; }
        public Metadata Metadata { get; set; }
        public Analysis Analysis { get; set; }
    }
}