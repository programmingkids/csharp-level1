using System;

class Work01 {
    static void Main(string[] args)
    {
        Character c = new Character();
        c.sayHello();
        c.show();
        c.attack();
        
        Console.WriteLine("======");
        
        Hero h = new Hero();
        h.sayHello();
        h.show();
        h.attack();
        h.specialAttack();
    }
}
