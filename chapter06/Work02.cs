using System;

class Work02 {
    static void Main(string[] args)
    {
        // ok
        int[] a = new int[5]{ 2,4,5,6,9};
        
        // same
        //int[] a = new int[]{ 2,4,5,6,9};
        
        // same
        //int[] a = {2,4,5,6,9};
        
        Console.WriteLine( a[0] );
        Console.WriteLine( a[1] );
        Console.WriteLine( a[2] );
        Console.WriteLine( a[3] );
        Console.WriteLine( a[4] );
    }
}
