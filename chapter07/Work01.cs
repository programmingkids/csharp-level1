using System;

class Work01 {
    static void Main(string[] args)
    {
        Book book = new Book();
        book.title = "ミッキーの大冒険";
        book.price = 1200;
        
        Console.WriteLine("本のタイトル:" + book.title);
        Console.WriteLine("本の金額:" + book.price);
    }
}
