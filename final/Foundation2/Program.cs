using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Avenida novo planeta","Alagoinhas","Bahia","Brazil");
        Customer customer1 = new Customer("Kevin", address1);
        List<Product> productList1 = new List<Product>();
        Product product1 = new Product("Ram Memory 8GB","35722",50,2);
        productList1.Add(product1);
        Product product2 = new Product("SSD 512GB","42762",100,1);
        productList1.Add(product2);
        Order order1 = new Order(productList1, customer1);
        Console.WriteLine(order1.LabelPacket());




    
    }
}