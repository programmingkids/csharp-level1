using System;

class Work02 {
    static void Main(string[] args)
    {
        Hero hero = new Hero("ドナルド",3, 12);
        hero.attack();
        
        // hero.getAttackPoint(); // このメソッドは実行できない
    }
}
