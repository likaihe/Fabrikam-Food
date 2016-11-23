using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify.DataModels
{
    public class Timeline
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "anger")]
        public string Anger { get; set; }

        [JsonProperty(PropertyName = "contempt")]
        public string Contempt { get; set; }


    }
}
