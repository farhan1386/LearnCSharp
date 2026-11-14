using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Enums;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Domain
{
    public class TransactionRequest
    {
        public string? OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public Currency Currency { get; set; }
    }
}