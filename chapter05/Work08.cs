using System;

class Work08 {
    static void Main(string[] args)
    {
        for( int i = 0; i < 10; i++ ) {
            if( i == 4 ) {
                Console.WriteLine("処理を中止します");
                break;
            }
            Console.WriteLine( i );
        }
    }
}
