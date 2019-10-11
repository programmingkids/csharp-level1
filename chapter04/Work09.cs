using System;

class Work09 {
    static void Main(string[] args)
    {
        string signal = "黄";
        if( signal.Equals("青")) {
            Console.WriteLine("進みます");
        } else if( signal.Equals("黄")) {
            Console.WriteLine("注意して進みます");
        } else {
            Console.WriteLine("止まります");
        }
    }
}
