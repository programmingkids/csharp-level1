using System;

class Work07 {
    static void Main(string[] args)
    {
        int total = 0;
        for( int i = 1; i <= 10; i++ ) {
            if( i % 2 == 0 ) {
                total += i;
            }
        }
        Console.WriteLine( total );
    }
}
