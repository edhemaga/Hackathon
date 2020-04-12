using Hackathon.Models;
using Hackathon.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Repository
{
    public class SimptomiOP : ISimptomiOP
    {
        public async Task<Simptomi> DodajSimptome(Simptomi simptomi)
        {
            var _simptomi = new Simptomi()
            {
                temperatura = simptomi.temperatura,
                umor = simptomi.umor,
                suhiKasalj = simptomi.suhiKasalj,
                teskocaDisanja = simptomi.teskocaDisanja,
                grlobolja = simptomi.proljev,
                bolovi = simptomi.bolovi,
                zacepljenjeNosa = simptomi.zacepljenjeNosa,
                curenjeNosa = simptomi.curenjeNosa,
                blagiSimptomi = simptomi.blagiSimptomi,
                srednjiJakiSimptomi = simptomi.srednjiJakiSimptomi,
                veomaSlabiSimtomi = simptomi.veomaSlabiSimtomi,
                jakiSimptomi = simptomi.jakiSimptomi,
                kontaktSaZarazenomOsobom = simptomi.kontaktSaZarazenomOsobom
            };
            return _simptomi;
        }
    }
}
