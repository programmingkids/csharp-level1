using System;

class Work10 {
    static void Main(string[] args)
    {
        int[,] numbers = new int[2,3];
        numbers[0,0] = 2;
        numbers[0,1] = 3;
        numbers[0,2] = 4;
        numbers[1,0] = 5;
        numbers[1,1] = 6;
        numbers[1,2] = 7;
        
        Console.WriteLine( numbers[0,0] );
        Console.WriteLine( numbers[0,1] );
        Console.WriteLine( numbers[0,2] );
        Console.WriteLine( numbers[1,0] );
        Console.WriteLine( numbers[1,1] );
        Console.WriteLine( numbers[1,2] );
    }
}
