using System;

class Work04 {
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle();
        
        int area1 = triangle.getArea(5, 10);
        Console.WriteLine("三角形の面積:" + area1);
        
        int area2 = triangle.getArea(2, 6);
        Console.WriteLine("三角形の面積:" + area2);
    }
}
