using System;

class Work15 {
    static void Main(string[] args)
    {
        int score = 90;
        
        if( score >= 90 ) {
            Console.WriteLine("成績はAです");
        } else if( score >= 80 ) {
            Console.WriteLine("成績はBです");
        } else if( score >= 70 ) {
            Console.WriteLine("成績はCです");
        } else if( score >= 60 ) {
            Console.WriteLine("成績はDです");
        } else {
            Console.WriteLine("成績はEです");
        }
    }
}
