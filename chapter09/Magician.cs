using System;

class Magician : Player
{
    public Magician(string name)
    {
        this.name = name;
    }
    
    public override void fight()
    {
        Console.WriteLine(this.name + "は戦うのは得意ではない");
    }
    
    public override void useMagic()
    {
        Console.WriteLine(this.name + "は強力な魔法を使った");
    }
    
    public override void escape()
    {
        Console.WriteLine(this.name + "は逃げる魔法を使った");
    }
}
