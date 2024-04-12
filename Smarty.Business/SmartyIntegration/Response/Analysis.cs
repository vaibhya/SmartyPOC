using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smarty.Business.SmartyIntegration.Response
{
    public class Analysis
    {
        public string DpvMatchCode { get; set; }
        public string DpvFootnotes { get; set; }
        public string DpvCmra { get; set; }
        public string DpvVacant { get; set; }
        public string DpvNoStat { get; set; }
        public string Active { get; set; }
        public string Footnotes { get; set; }
        public string EnhancedMatch { get; set; }
    }
}