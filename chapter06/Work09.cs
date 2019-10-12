using System;

class Work09 {
    static void Main(string[] args)
    {
        int[] numbers = {2,3,5,6,8,9};
        
        foreach( int num in numbers ) {
            if( num % 2 == 1 ) {
                Console.WriteLine( num );
            }
        }
    }
}
