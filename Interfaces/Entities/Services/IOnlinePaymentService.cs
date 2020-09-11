namespace Interfaces.Entities.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);
    }
}