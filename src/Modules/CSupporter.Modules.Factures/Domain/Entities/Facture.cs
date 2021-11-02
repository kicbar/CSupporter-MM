using System;
using System.Collections.Generic;

namespace CSupporter.Modules.Factures.Domain.Entities
{
    public class Facture
    {
        public Guid Id { get; set; }
        public string FactureNo { get; set; }
        public DateTime FactureDate { get; set; }
        public List<Position> Positions { get; set; }
        public decimal ValueBrutto { get; set; }
        public decimal ValueNetto { get; set; }
        public string ContractorId { get; set; }
    }
}
