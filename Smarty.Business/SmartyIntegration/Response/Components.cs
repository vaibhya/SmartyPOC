using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smarty.Business.SmartyIntegration.Response
{
    public class Components
    {
        public string PrimaryNumber { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string DefaultCityName { get; set; }
        public string StateAbbreviation { get; set; }
        public string Zipcode { get; set; }
        public string Plus4Code { get; set; }
        public string DeliveryPoint { get; set; }
        public string DeliveryPointCheckDigit { get; set; }
    }
}