using System;
using System.ComponentModel.DataAnnotations;

namespace CSupporter.Modules.Factures.Domain.Entities
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        [Required]
        public int PositionNo { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Range(1, 1000)]
        [Required]
        public int ProductAmount { get; set; } = 1;

        public virtual Facture Facture { get; set; }
        public int FactureId { get; set; }
    }
}
