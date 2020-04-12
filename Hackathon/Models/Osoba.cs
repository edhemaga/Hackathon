using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class Osoba
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodenja { get; set; }
        public string struka { get; set; }
        public string brojTelefona { get; set; }
        public KontaktOsoba kontaktOsoba { get; set; }
        public List<Simptomi> simptomi { get; set; }
        public List<DodatneInformacije> dodatneInformacije { get; set; }
    }
}
