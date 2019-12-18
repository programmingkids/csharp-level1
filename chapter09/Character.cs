using System;

class Character
{
    public string name;
    public int hp;
    public int mp;
    
    public Character()
    {
        this.name = "キャラクター";
        this.hp = 10;
        this.mp = 10;
    }
    
    public void sayHello()
    {
        Console.WriteLine("私は" + this.name + "です");
    }
    
    public void show()
    {
        Console.WriteLine("名前:" + this.name);
        Console.WriteLine("体力:" + this.hp);
        Console.WriteLine("魔法:" + this.mp);
        Console.WriteLine("----");
    }
    
    public void attack()
    {
        Console.WriteLine(this.name + "は攻撃した");
    }
}
