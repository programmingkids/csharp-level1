using System;

class Work06 {
    static void Main(string[] args)
    {
        int[] scores = {78,82,94,91};
        int total = 0;
        
        for( int i = 0; i < scores.Length; i++ ) {
            total += scores[i];
        }
        Console.WriteLine( total );
    }
}
