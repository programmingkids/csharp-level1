using System;

class Monster
{
    public string name;
    protected int hp;
    protected int attackPoint;
    protected string weapon;
    
    protected Monster(string name, int hp, int attackPoint)
    {
        this.name = name;
        this.hp = hp;
        this.attackPoint = attackPoint;
        this.weapon = "武器はない";
    }
    
    public virtual void attack()
    {
        Console.WriteLine(this.name + "は攻撃した");
    }
    
    public void getDamage()
    {
        Console.WriteLine("[" + this.weapon + "]による攻撃!");
        Console.WriteLine(this.attackPoint + "のダメージを与えた");
    }
}
