using System;

public class Dude
{
    public string name;
    public int exp;

    public Dude() //default constructor
    {
        Reset();
    }

    public Dude(string name)
    {
        this.name = name;
    }

    //methods

    public virtual void PrintStatsInfo() //virtual allows polymorphism to occur
    {
        Console.WriteLine("Dude: " + this.name + " - " + this.exp + " EXP");
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}