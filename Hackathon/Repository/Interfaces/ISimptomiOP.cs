using Hackathon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Repository.Interfaces
{
    interface ISimptomiOP
    {
        Task<Simptomi> DodajSimptome(Simptomi simptomi);
    }
}
