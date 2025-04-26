using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Patterns.Creational.Builder;

public class Room
{
    private readonly string _name;
    private bool wiFiFreeOfCharge;
    private int numberOfBeds;
    private bool balconyAvailable;

    public Room(string name)
    {
        _name = name;
    }

    public Room WithBalcony()
    {
        balconyAvailable = true;
        return this;
    }

    public Room WithBed(int numberOfBeds)
    {
        this.numberOfBeds = numberOfBeds;
        return this;
    }

    public Room WithWiFi()
    {
        wiFiFreeOfCharge = true;
        return this;
    }

    public Room Describe()
    {
        StringBuilder describeBuilder = new StringBuilder();
        describeBuilder.AppendLine(_name); 
        describeBuilder.AppendLine($"Number of bed(s): {numberOfBeds}."); 
        describeBuilder.AppendLine(balconyAvailable ? "There is a balcony." : "There is not a balcony."); 
        describeBuilder.AppendLine(wiFiFreeOfCharge ? "This room is wi-fi Free." : "This room is not wi-fi Free."); 

        Console.WriteLine(describeBuilder.ToString());
        return this;
    }
}
