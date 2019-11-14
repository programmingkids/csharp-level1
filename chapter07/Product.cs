using System;

class Product 
{
    public string name;
    public int price;
    public int unit;
    
    public void showInfo()
    {
        Console.WriteLine("商品の名前:" + this.name);
        Console.WriteLine("商品の金額:" + this.price);
        Console.WriteLine("商品の個数:" + this.unit);
    }

    public void showTotal()
    {
        int total = this.price * this.unit;
        Console.WriteLine("商品の合計:" + total);
    }
}
