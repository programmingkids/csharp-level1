using System;

class Hero
{
    public string name;
    public int level;
    public int attackPoint;
    
    public Hero( string name, int level, int attackPoint )
    {
        this.name = name;
        this.level = level;
        this.attackPoint = attackPoint;
    }
    
    public void attack()
    {
        int attackPoint = this.getAttackPoint();
        Console.WriteLine(this.name + "は攻撃した！");
        Console.WriteLine("攻撃力は「" + attackPoint + "」でした！");
    }
    
    private int getAttackPoint()
    {
        int result = this.level * this.attackPoint;
        return result;
    }
}
