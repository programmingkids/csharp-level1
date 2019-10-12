using System;

class Work13 {
    static void Main(string[] args)
    {
        int[] numbers = {85, 90, 88, 75, 94};
        
        int total = 0;
        foreach(int num in numbers) {
            total += num;
        }
        Console.WriteLine(total);
    }
}
