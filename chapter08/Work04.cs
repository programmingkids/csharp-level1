using System;

class Work04 {
    static void Main(string[] args)
    {
        GameWorld gameWorld = GameWorld.getGameWorld();
        gameWorld.run();
        
        gameWorld = GameWorld.getGameWorld();
        gameWorld.run();
    }
}
