using System;
using System.ComponentModel.DataAnnotations;

namespace CSupporter.Modules.Contractors.DTO
{
    public class ContractorDto
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDetails { get; set; }
        public string NIP { get; set; }
    }
}
