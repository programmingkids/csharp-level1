using System;

class Player
{
    
    public string name;
    public int level;
    
    public static int exp;
    
    public Player(string name, int level)
    {
        this.name = name;
        this.level = level;
    }
    
    public void show()
    {
        Console.WriteLine("名前:" + this.name);
        Console.WriteLine("レベル:" + this.level);
        Console.WriteLine("経験値:" + Player.exp);
    }
    
    public static void setExp(int exp)
    {
        Player.exp = exp;
    }
    
    public static int getExp()
    {
        return Player.exp;
    }
}