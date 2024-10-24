using System;

public class Character
{
    public string name;
    public int exp;

    public Character() //default constructor
    {
        Reset();
    }

    public Character(string name)
    {
        this.name = name;
    }

    //methods

    public virtual void PrintStatsInfo() //virtual allows polymorphism to occur
    {
        Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}

public class Paladin: Character
{
    public Weapon weapon;
    public Paladin(string name): base(name)
    {

    }

    public Paladin(string name, Weapon weapon): base(name)
    {
        this.weapon = weapon;
    }

    //methods

    public override void PrintStatsInfo() //overrides character's print stats method
    {
        Console.WriteLine("Hail " + this.name + " - take up your " + this.weapon.name + "!");
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

        //inheritance
        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        //Testing external class adventurer
        Adventurer mike = new Adventurer("Mike");
        mike.PrintStatsInfo();
    }
}