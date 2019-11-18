using System;

class HybridCar : Car
{
    public new string name = "ハイブリッドカー";
    public new int gas = 10;
    public new int speed = 40;
    
    public new void show()
    {
        Console.WriteLine("名前:" + this.name);
        Console.WriteLine("ガス:" + this.gas);
        Console.WriteLine("速度:" + this.speed);
        Console.WriteLine("----");
    }
}
