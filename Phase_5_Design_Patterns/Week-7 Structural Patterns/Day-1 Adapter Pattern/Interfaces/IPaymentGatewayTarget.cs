using Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Domain;

namespace Phase_5_Design_Patterns.Week_7_Structural_Patterns.Adapter_Pattern.Interfaces
{
    public interface IPaymentGatewayTarget
    {
        void ProcessPayment(TransactionRequest request);
    }
}