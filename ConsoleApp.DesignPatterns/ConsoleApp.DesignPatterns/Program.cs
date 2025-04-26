using ConsoleApp.DesignPatterns.Patterns.Creational.Builder;

Console.WriteLine("Builder Pattern");

var simpleRoom = new SimpleRoomBuilder().Build().WithBed(1);
    
simpleRoom.Describe();

var familyRoom = new FamilyRoomBuilder().Build()
    .WithBalcony().WithBed(2).WithWiFi();

familyRoom.Describe();
