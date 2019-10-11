using System;

class Work09 {
    static void Main(string[] args)
    {
        for( int i = 0; i < 10; i++ ) {
            if( i == 4 ) {
                Console.WriteLine("処理をスキップします");
                continue;
            }
            Console.WriteLine( i );
        }
    }
}
