using System;

namespace CSupporter.Shared.Infrastructure.Models.DTOs
{
    public class IncomeCalculation
    {
        public int CalculateId { get; set; }
        public double CalculateValue { get; set; }
        public DateTime CalculateDate { get; set; } = DateTime.Now;
    }
}
