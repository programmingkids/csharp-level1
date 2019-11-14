using System;

class Work07 {
    static void Main(string[] args)
    {
        Player player = new Player("ボブ", "鋼の剣", 10);
        player.fight();
        player.status();
    }
}
