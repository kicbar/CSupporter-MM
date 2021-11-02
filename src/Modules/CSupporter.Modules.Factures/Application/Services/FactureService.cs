using CSupporter.Modules.Factures.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSupporter.Modules.Factures.Application.Services
{
    public class FactureService : IFactureService
    {
        private readonly IFactureRepository _factureRepository;

        public FactureService(IFactureRepository factureRepository)
        {
            _factureRepository = factureRepository;
        }
    }
}
