public class Order{
    private double _sum;
    private List<Products> _products = new List<Products>();
    private Customers _customer;
    public Order(List<Products> products, Customers customer){
        _products = products;
        _customer = customer;

    }

    public void TotalPrice(){
        foreach (Products product in _products ){
            _sum += product.GetTotalPrice();
        }
        Console.WriteLine("Sum Before Shipping");
        Console.WriteLine(_sum);
        if (_customer.InUSACustomer()== true){
            _sum += 5;
        }
        else{
            _sum += 35;
        }
        Console.WriteLine();
        Console.WriteLine("Sum After Shipping");
        Console.WriteLine(_sum);
   

    }
    public void DisplayOrder(){
        Console.WriteLine();
        Console.WriteLine("=======================================================================================");
        Console.WriteLine();
        Console.WriteLine("Packing Label: ");
        PackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");
        ShippingLabel();
        Console.WriteLine();
        TotalPrice();
        Console.WriteLine("=======================================================================================");


    }
    public void PackingLabel(){
        foreach (Products product in _products){
            Console.WriteLine($"Product name: {product.GetProductName()}---------- ProductID: {product.GetProductID()}");
        }
    }
    public void ShippingLabel(){
        Console.WriteLine($"Name: {_customer.GetCustomerName()} ------ {_customer.GetAddress()}");
    }
    // public void AddProduct(Products product){
    //     _products.Add()
    // }
}