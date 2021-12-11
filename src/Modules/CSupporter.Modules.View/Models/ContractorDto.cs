using System;

namespace CSupporter.Modules.View.Models
{
    public class ContractorDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDetails { get; set; }
        public string NIP { get; set; }
    }
}
