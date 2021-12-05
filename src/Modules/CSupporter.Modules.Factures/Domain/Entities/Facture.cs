using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSupporter.Modules.Factures.Domain.Entities
{
    public class Facture
    {
        [Key]
        public int FactureId { get; set; }
        [Required]
        public string FactureNo { get; set; }
        [Required]
        [StringLength(7)]
        public string FactureType { get; set; } = "OUTCOME";
        [Required]
        public DateTime FactureDate { get; set; } = DateTime.Now;
        [Range(1, 1000)]
        public double Value { get; set; }
        [Required]
        public string ContractorId { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public virtual List<Position> Positions { get; set; }
    }
}
