using System;

class Tank  
{
    public string name;
    public int speed;
    public int bullets;
    
    public Tank(string name, int speed, int bullets)
    {
        this.name = name;
        this.speed = speed;
        this.bullets = bullets;
    }

    public void move()
    {
        Console.WriteLine("戦車[" + this.name + "]は" + this.speed + "で移動中");
    }
    
    public void shoot()
    {
        if(this.bullets > 0) {
            bullets--;
            Console.WriteLine("戦車[" + this.name + "]は大砲を発射しました");
            Console.WriteLine("残弾数は" + this.bullets);
        } else {
            Console.WriteLine("戦車[" + this.name + "]は弾がありません");
        }
    }
}
