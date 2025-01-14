﻿using System;

namespace CSupporter.Shared.Infrastructure.Models.DTOs
{
    public class FactureDto
    {
        public int FactureId { get; set; }
        public string FactureNo { get; set; }
        public string FactureType { get; set; }
        public DateTime FactureDate { get; set; } = DateTime.Now;
        public double Value { get; set; }
        public string ContractorId { get; set; }
    }
}
