using System;

class GameWorld 
{
    private static GameWorld gw;
    
    private GameWorld()
    {
        Console.WriteLine("GameWorldが作成されました");
    }
    
    public static GameWorld getGameWorld()
    {
        if( GameWorld.gw == null )
        {
            GameWorld.gw = new GameWorld();
        }
        return GameWorld.gw;
    }
    
    public void run()
    {
        Console.WriteLine("ゲームが実行中です");
    }
}
