public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;

    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_name} ({_productId}): ${_price:F2} - Quantity: {_quantity}";
    }
}