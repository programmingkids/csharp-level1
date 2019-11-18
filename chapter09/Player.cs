using System;

class Player
{
    protected string name;

    public Player()
    {
        this.name = "名無し";
    }
    
    public virtual void fight()
    {
        Console.WriteLine(this.name + "は普通に戦った");
    }
    
    public virtual void useMagic()
    {
        Console.WriteLine(this.name + "は魔法を使った");
    }
    
    public virtual void escape()
    {
        Console.WriteLine(this.name + "は逃げ出した");
    }
}
