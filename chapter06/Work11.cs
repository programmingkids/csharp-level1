using System;

class Work11 {
    static void Main(string[] args)
    {
        int[,] numbers = {{2,3,4},{5,6,7}};
        
        for( int i = 0; i < numbers.GetLength(0); i++ ) {
            for( int j = 0; j < numbers.GetLength(1); j++ ) {
                Console.WriteLine( numbers[i,j] );
            }
        }
    }
}
