namespace ConsoleApp.DesignPatterns.Patterns.Creational.Builder;

public class FamilyRoomBuilder : IRoomBuilder
{
    public Room Build()
    {
        return new Room("Family Room");
    }
}
