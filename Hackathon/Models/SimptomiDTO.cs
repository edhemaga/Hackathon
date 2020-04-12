using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class SimptomiDTO
    {
        [JsonProperty("000000")]
        public int temperatura { get; set; }
        [JsonProperty("000001")]
        public int umor { get; set; }
        [JsonProperty("000002")]
        public int suhiKasalj { get; set; }
        [JsonProperty("000003")]
        public int teskocaDisanja { get; set; }
        [JsonProperty("000004")]
        public int grlobolja { get; set; }
        [JsonProperty("000005")]
        public int proljev { get; set; }
        [JsonProperty("000006")]
        public int bolovi { get; set; }
        [JsonProperty("000007")]
        public int zacepljenjeNosa { get; set; }
        [JsonProperty("000008")]
        public int curenjeNosa { get; set; }
        [JsonProperty("000009")]
        public int blagiSimptomi { get; set; }
        [JsonProperty("00000a")]
        public int srednjiJakiSimptomi { get; set; }
        [JsonProperty("00000b")]
        public int veomaSlabiSimtomi { get; set; }
        [JsonProperty("00000c")]
        public int jakiSimptomi { get; set; }
        [JsonProperty("00000d")]
        public int kontaktSaZarazenomOsobom { get; set; }

    }
}
