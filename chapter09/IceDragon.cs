using System;

class IceDragon : Monster
{

    public IceDragon(string name, int hp, int attackPoint) : base(name, hp, attackPoint)
    {
        this.weapon = "アイストルネード";
    }
    
    public override void attack()
    {
        Console.WriteLine(this.name + "は氷で攻撃した");
    }
}
