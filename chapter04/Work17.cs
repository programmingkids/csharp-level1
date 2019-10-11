using System;

class Work17 {
    static void Main(string[] args)
    {
        string signal = "黄";
        switch( signal ) {
            case "青":
                Console.WriteLine("進みます");
                break;
            case "黄":
                Console.WriteLine("注意して進みます");
                break;
            case "赤":
                Console.WriteLine("止まります");
                break;
            default:
                Console.WriteLine("エラーです");
                break;
                
        }
    }
}
