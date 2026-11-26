using System;

namespace DTO
{
    public class ReconciliationResultDTO
    {
        public DateTime ReconcileDate { get; set; }
        public int TotalTransactions { get; set; }
        public int MatchedCount { get; set; }
        public int DiscrepancyCount { get; set; }
        public string Status { get; set; }
    }
}