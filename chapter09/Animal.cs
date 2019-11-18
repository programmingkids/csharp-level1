using System;

class Animal
{
    public string name;
    public int age;
    
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public void show()
    {
        Console.WriteLine("名前:" + this.name);
        Console.WriteLine("年齢:" + this.age);
    }
    
    public virtual void cry()
    {
        Console.WriteLine("鳴き声:なし");
    }
}
