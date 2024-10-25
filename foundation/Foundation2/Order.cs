public class Order {
    private static double NATIONAL_SHIPPING_COST = 5;
    private static double FOREIGN_SHIPPING_COST = 35;
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer) {
        _customer = customer;
    }
    
    private double GetShippingCost() {
        if(_customer.LivesInUSA()) return NATIONAL_SHIPPING_COST;

        return FOREIGN_SHIPPING_COST;
    }

    private string DisplayProducts() {
        string[] products = _products.Select(p => p.Display()).ToArray();

        return String.Join("\n", products);
    }

    public double CalculateTotalCost() {
        double productsTotal = _products.Count() == 0 ? 0 : _products.Select(p => p.CalculateTotal()).ToList().Sum();
        double total = productsTotal + GetShippingCost();
        
        return (double) Math.Round(total, 2);
    }

    public string DisplayPackingLabel() {
        return DisplayProducts();
    }

    public string DisplayShippingLabel() {
        return $"{_customer.GetName()}\n{_customer.GetAddress().Display()}";
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }
}