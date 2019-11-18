using System;

class Car
{
    public string name = "ガソリン車";
    public int gas = 30;
    public int speed = 60;
    
    public void show()
    {
        Console.WriteLine("名前:" + this.name);
        Console.WriteLine("ガス:" + this.gas);
        Console.WriteLine("速度:" + this.speed);
        Console.WriteLine("----");
    }
}
