using System;

class ElectricCar : Car
{
    public new string name = "電気自動車";
    public new int gas = 0;
    public new int speed = 30;
    
    public new void show()
    {
        Console.WriteLine("名前:" + this.name);
        Console.WriteLine("ガス:" + this.gas);
        Console.WriteLine("速度:" + this.speed);
        Console.WriteLine("----");
    }
}
