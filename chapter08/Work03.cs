using System;

class Work03 {
    static void Main(string[] args)
    {
        Player p1 = new Player("エルサ", 3);
        Player p2 = new Player("アナ", 2);
        
        Player.setExp(10);
        Console.WriteLine( "経験値:" + Player.getExp() );
        Console.WriteLine("----");
        
        Player.setExp(20);
        
        p1.show();
        
        Console.WriteLine("----");
        
        p2.show();
    }
}
