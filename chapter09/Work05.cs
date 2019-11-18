using System;

class Work05 {
    static void Main(string[] args)
    {
        FireDragon fireDragon = new FireDragon("ファイヤードラゴン", 10, 20);
        IceDragon iceDragon = new IceDragon("アイスドラゴン",20, 10);
        
        fireDragon.attack();
        fireDragon.getDamage();

        Console.WriteLine("----");
        
        iceDragon.attack();
        iceDragon.getDamage();
    }
}
