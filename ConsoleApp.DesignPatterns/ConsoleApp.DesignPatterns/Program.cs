using ConsoleApp.DesignPatterns.Patterns.Creational.Builder;
using ConsoleApp.DesignPatterns.Patterns.Creational.Factory;
using ConsoleApp.DesignPatterns.Patterns.Creational.Factory.Enum;

Console.WriteLine("Builder Pattern");

var simpleRoom = new SimpleRoomBuilder().Build().WithBed(1);
    
simpleRoom.Describe();

var familyRoom = new FamilyRoomBuilder().Build()
    .WithBalcony().WithBed(2).WithWiFi();

familyRoom.Describe();


Console.WriteLine("Factory Pattern");

PaymentFactory factory = new PaymentFactory();

var italianPayment = factory.Create(PaymentFactory.ServicesAvailableEnum.Italian);
italianPayment.EmailToCharge = "test@gmail.com";
italianPayment.MoneyToCharge = 104.3m;
italianPayment.OptionToCharge = ChargingOptionEnum.CreditCard;
italianPayment.ProcessCharging();

var brazilianPayment = factory.Create(PaymentFactory.ServicesAvailableEnum.Brazilian);
brazilianPayment.EmailToCharge = "test@gmail.com";
brazilianPayment.MoneyToCharge = 133.75m;
brazilianPayment.OptionToCharge = ChargingOptionEnum.DebitCard;
brazilianPayment.ProcessCharging();
