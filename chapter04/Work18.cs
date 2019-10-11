using System;

class Work18 {
    static void Main(string[] args)
    {
        string job = "勇者";
        
        switch( job ) {
            case "勇者":
                Console.WriteLine("勇気をもって戦え");
                break;
            case "魔法使い":
                Console.WriteLine("魔法で戦え");
                break;
            case "戦士":
                Console.WriteLine("武器で戦え");
                break;
            default:
                Console.WriteLine("とにかく戦え");
                break;
        }
    }
}
