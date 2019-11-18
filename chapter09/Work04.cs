using System;

class Work04 {
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.show();
        
        HybridCar car2 = new HybridCar();
        car2.show();
        
        ElectricCar car3 = new ElectricCar();
        car3.show();
    }
}
