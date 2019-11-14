using System;

class Work02 {
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title = "ミッキーの大冒険";
        book1.price = 1200;
        
        Console.WriteLine("本1のタイトル:" + book1.title);
        Console.WriteLine("本1の金額:" + book1.price);
        
        Console.WriteLine("======");
        
        Book book2 = new Book();
        book2.title = "ミニーのおすすめレシピ";
        book2.price = 1500;
        
        Console.WriteLine("本2のタイトル:" + book2.title);
        Console.WriteLine("本2の金額:" + book2.price);
    }
}
