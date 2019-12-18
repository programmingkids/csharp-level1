using System;

class Hero : Character
{
    public string specialWeapon;
    
    public Hero()
    {
        this.name = "勇者";
        this.hp = 30;
        this.mp = 20;
        this.specialWeapon = "勇者の剣";
    }
    
    public void specialAttack()
    {
        Console.WriteLine(this.name + "は" + this.specialWeapon + "で攻撃した");
    }
}
