using System;

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }
    
    public override void cry()
    {
        Console.WriteLine("鳴き声:ワンワン");
    }
}
