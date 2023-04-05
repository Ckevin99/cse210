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
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.LabelPacket());
        Console.WriteLine($"Total Price: {order1.CalculateTotalCost()}$\n");


        Address address2 = new Address("Paramount Blvd","Downey","California","United States");
        Customer customer2 = new Customer("Keilla", address2);
        List<Product> productList2 = new List<Product>();
        Product product4 = new Product("Notebook","15682",1000,1);
        productList2.Add(product4);
        Product product5 = new Product("Processor","12012",400,1);
        productList2.Add(product5);
        Order order2 = new Order(productList2, customer2);
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.LabelPacket());
        Console.WriteLine($"Total Price: {order2.CalculateTotalCost()}$");
    
        
        




    
    }
}