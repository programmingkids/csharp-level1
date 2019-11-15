using System;

class Work01 {
    static void Main(string[] args)
    {
        Person p1 = new Person();

        p1.setName("ミッキー");
        p1.setAge(15);
        
        Console.WriteLine( "p1の名前:" + p1.getName() );
        Console.WriteLine( "p1の年齢:" + p1.getAge() );
        
        Console.WriteLine("----");
        
        Person p2 = new Person();
        
        p2.setName("ミニー");
        p2.setAge(-10);

        Console.WriteLine( "p2の名前:" + p2.getName() );
        Console.WriteLine( "p2の年齢:" + p2.getAge() );
    }
}
