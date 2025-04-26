
namespace ConsoleApp.DesignPatterns.Patterns.Creational.Builder;

public class SimpleRoomBuilder : IRoomBuilder
{
    public Room Build()
    {
        return new Room("Simple Room");
    }
}
