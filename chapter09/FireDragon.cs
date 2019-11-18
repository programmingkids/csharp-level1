using System;

class FireDragon : Monster
{

    public FireDragon(string name, int hp, int attackPoint) : base(name, hp, attackPoint)
    {
        this.weapon = "巨大なマグマ";
    }
    
    public override void attack()
    {
        Console.WriteLine(this.name + "は炎で攻撃した");
    }
}
