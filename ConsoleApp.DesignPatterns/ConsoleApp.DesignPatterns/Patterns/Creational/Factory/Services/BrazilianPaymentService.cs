using ConsoleApp.DesignPatterns.Patterns.Creational.Factory.Enum;


namespace ConsoleApp.DesignPatterns.Patterns.Creational.Factory.Services;

public class BrazilianPaymentService : IPaymentService
{
    public string EmailToCharge { get; set; } = default!;
    public decimal MoneyToCharge { get; set; }
    public ChargingOptionEnum OptionToCharge { get; set; }

    public void ProcessCharging()
    {
        Console.WriteLine("### BRAZILIAN METHOD");
        Console.WriteLine($"E-mail charging: {EmailToCharge}, Money to Charge: {MoneyToCharge}, Debit/Credit: {OptionToCharge}");
    }
}
