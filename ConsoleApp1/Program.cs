using System;

public class Character
{
    public string name;
    public int exp;

    public Character() //default constructor
    {
        name = "Not assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }

    //methods

    public void PrintStatsInfo()
    {
        Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Character hero = new Character();
        hero.PrintStatsInfo();
        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();
    }
}