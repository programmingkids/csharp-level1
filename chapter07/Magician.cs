using System;

class Magician
{
    public string name;
    public int hp;
    public int mp;
    public int level;
    
    public Magician(string name, int hp, int mp, int level)
    {
        this.name = name;
        this.hp = hp;
        this.mp = mp;
        this.level = level;
    }
    
    public void fight()
    {
        Console.WriteLine(this.name + "は魔法で戦った");
    }
    
    public void status()
    {
        Console.WriteLine(this.name + "のHPは" + this.hp);
        Console.WriteLine(this.name + "のMPは" + this.mp);
        Console.WriteLine(this.name + "のレベルは" + this.level);
    }
}
