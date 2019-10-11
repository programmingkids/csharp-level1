using System;

class Work10 {
    static void Main(string[] args)
    {
        int score = 85;
        if( score == 100 ) {
            Console.WriteLine("満点ですね");
        } else if( score >= 90 ) {
            Console.WriteLine("かなり良い点数です");
        } else if( score >= 80 ) {
            Console.WriteLine("良い点数です");
        } else if( score >= 70 ) {
            Console.WriteLine("普通です");
        } else {
            Console.WriteLine("がんばろう");
        }
    }
}
