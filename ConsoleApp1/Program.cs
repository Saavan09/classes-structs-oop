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

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    //methods

    public void PrintWeaponStats()
    {
        Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
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

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();
    }
}