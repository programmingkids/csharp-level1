using System;

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }
    
    public override void cry()
    {
        Console.WriteLine("鳴き声:ニャーニャー");
    }
}
