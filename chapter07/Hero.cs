using System;

class Hero
{
    public string name;
    public int hp;
    public int level;
    

    public Hero()
    {
        this.name = "ドナルド";
        this.hp = 10;
        this.level = 1;
    }
    
    public void fight()
    {
        Console.WriteLine(this.name + "は武器で戦った");
    }
    
    public void escape()
    {
        Console.WriteLine(this.name + "は逃げ出した");
    }
    
    public void status()
    {
        Console.WriteLine(this.name + "のHPは" + this.hp);
        Console.WriteLine(this.name + "のレベルは" + this.level);
    }
}
