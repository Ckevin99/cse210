using System;



class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;



    public Order(List<Product> products, Customer customer){
        _products = products;
        _customer = customer;


    }


    public int CalculateTotalCost(){

        int totalCost = 0;
        foreach (Product x in _products){
            totalCost = totalCost + x.TotalPrice();

        }
        if (_customer.IsInUSA()){
            totalCost = totalCost + 5;

        }else if (!_customer.IsInUSA()){
            totalCost = totalCost + 35;
        }
        return totalCost;
    }

    public string LabelPacket(){

        string labelPacket= "-------Products-------\n";

        foreach(Product x in _products){
        
        
        
        
        labelPacket = labelPacket + x.GetName() + "-" + x.GetID() + "\n";
            
        }
        
        
        return labelPacket;


    }


    public string ShippingLabel(){

      return _customer.GetName() +"\n" + _customer.GetAddress();

    }
















}