using System;

class Work10 {
    static void Main(string[] args)
    {
        for( int i = 1; i <= 3; i++ ) {
            Console.WriteLine("<< " + i.ToString() + " >>");
            for( int j = 1; j <= 3; j++ ) {
                Console.WriteLine( j );
            }
        }
    }
}
