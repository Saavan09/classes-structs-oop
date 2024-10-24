public class Adventurer
{
    public string name;
    public int exp;

    public Adventurer() //default constructor
    {
        Reset();
    }

    public Adventurer(string name)
    {
        this.name = name;
    }

    //methods

    public virtual void PrintStatsInfo() //virtual allows polymorphism to occur
    {
        Console.WriteLine("Adventurer: " + this.name + " - " + this.exp + " EXP");
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}