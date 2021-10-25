using System;

namespace CSupporter.Modules.Contractors.DTO
{
    public class ContractorDetailsDto : ContractorDto
    {
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
