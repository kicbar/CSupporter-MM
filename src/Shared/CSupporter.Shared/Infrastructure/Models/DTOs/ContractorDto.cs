﻿using System;

namespace CSupporter.Shared.Infrastructure.Models.DTOs
{
    public class ContractorDto
    {
        public Guid ContractorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDetails { get; set; }
        public string NIP { get; set; }
    }
}
