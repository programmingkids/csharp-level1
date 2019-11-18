using System;

class Parent
{
    // 継承される
    public string param1;
    // 継承される
    protected string param2;
    // 継承されない
    private string param3;
    
    public Parent()
    {
        param1  ="this is parent param1";
        param2  ="this is parent param2";
        param3  ="this is parent param3";
    }
    
    public void show()
    {
        Console.WriteLine(this.param1);
        Console.WriteLine(this.param2);
        Console.WriteLine(this.param3);
        Console.WriteLine("----");
    }
}
