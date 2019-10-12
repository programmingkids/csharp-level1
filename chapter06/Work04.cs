using System;

class Work04 {
    static void Main(string[] args)
    {
        string[] colors = {"blue","red","green"};
        colors[1] = "orange";
        colors[2] = "purple";
        
        Console.WriteLine( colors[0] );
        Console.WriteLine( colors[1] );
        Console.WriteLine( colors[2] );
    }
}
