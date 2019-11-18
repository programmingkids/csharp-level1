using System;

class SuperHero : Player
{
    public SuperHero(string name)
    {
        this.name = name;
    }
    
    public override void fight()
    {
        Console.WriteLine(this.name + "は勇敢に戦った");
    }
    
    public override void useMagic()
    {
        Console.WriteLine(this.name + "は簡単な魔法を使った");
    }
    
    public override void escape()
    {
        Console.WriteLine(this.name + "は華麗に撤退した");
    }
}
