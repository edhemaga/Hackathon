using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class Simptomi
    {
        public bool temperatura { get; set; }
        public bool umor { get; set; }
        public bool suhiKasalj { get; set; }
        public bool teskocaDisanja { get; set; }
        public bool grlobolja { get; set; }
        public bool proljev { get; set; }
        public bool bolovi { get; set; }
        public bool zacepljenjeNosa { get; set; }
        public bool curenjeNosa { get; set; }
        public bool blagiSimptomi { get; set; }
        public bool srednjiJakiSimptomi { get; set; }
        public bool veomaSlabiSimtomi { get; set; }
        public bool jakiSimptomi { get; set; }
        public bool kontaktSaZarazenomOsobom { get; set; }
        public int id { get; set; }
    }
}
