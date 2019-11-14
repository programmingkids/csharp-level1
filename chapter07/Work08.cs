using System;

class Work08 {
    static void Main(string[] args)
    {
        Tank myTank = new Tank("タイガー3号",5, 3);
        
        for( int i = 0; i < 5; i++ ) {
            myTank.move();
            myTank.shoot();
            Console.WriteLine("----");
        } 
    }
}
