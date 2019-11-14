using System;

class Work03 {
    static void Main(string[] args)
    {
        Product product = new Product();
        product.name = "鉛筆";
        product.price = 120;
        product.unit = 3;
        
        product.showInfo();
        product.showTotal();
    }
}
