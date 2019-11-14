using System;

class Work06 {
    static void Main(string[] args)
    {
        Magician m1 = new Magician("アリエル", 15, 20, 2);
        m1.status();
        m1.fight();
        
        Console.WriteLine("------");
        
        Magician m2 = new Magician("ベル", 20, 30, 3);
        m2.status();
        m2.fight();
    }
}
