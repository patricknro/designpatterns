using ConsoleApp.DesignPatterns.Patterns.Creational.Factory.Enum;

namespace ConsoleApp.DesignPatterns.Patterns.Creational.Factory.Services;

public interface IPaymentService
{
    string EmailToCharge { get; set; }
    decimal MoneyToCharge { get; set; }
    ChargingOptionEnum OptionToCharge { get; set; }

    void ProcessCharging();
}
