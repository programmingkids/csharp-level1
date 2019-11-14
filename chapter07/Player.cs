using System;

class Player 
{
    public string name;
    public string weapon;
    public int hp;

    public Player(string name, string weapon, int hp)
    {
        this.name = name;
        this.weapon = weapon;
        this.hp = hp;
    }
    
    public void fight()
    {
        Console.WriteLine(this.name + "は" + this.weapon + "で戦った");
    }
    
    public void status()
    {
        Console.WriteLine(this.name + "の武器は" + this.weapon);
        Console.WriteLine(this.name + "のHPは" + this.hp);
    }
}
