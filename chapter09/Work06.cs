using System;

class Work06 {
    static void Main(string[] args)
    {
        Dog dog = new Dog("ポチ", 5);
        dog.show();
        dog.cry();
        
        Console.WriteLine("----");
        
        Cat cat = new Cat("タマ", 3);
        cat.show();
        cat.cry();
    }
}
