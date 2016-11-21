using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Fabrikam.Models
{
    class Menu
    {
        [JsonProperty(PropertyName = "Id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "anger")]
        public double Anger { get; set; }

        [JsonProperty(PropertyName = "contempt")]
        public double Contempt { get; set; }

       
    }
}
