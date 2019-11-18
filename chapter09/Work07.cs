using System;

class Work07 {
    static void Main(string[] args)
    {
        SuperHero superHero = new SuperHero("勇者");
        superHero.fight();
        superHero.useMagic();
        superHero.escape();
        
        Console.WriteLine("----");
        
        Magician magician = new Magician("魔法使い");
        magician.fight();
        magician.useMagic();
        magician.escape();
    }
}
