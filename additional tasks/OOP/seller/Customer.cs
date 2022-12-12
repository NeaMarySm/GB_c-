class Customer
{
	private string _name;
	public string Name => _name;
	private double _account;
	private List<Product> _products;

	public Customer(string name, double account = 0)
	{
		_name = name;
		_account = account;
		_products = new List<Product>();
	}
	public void Buy(Seller seller, Product product, int amount = 1)
	{
		if (product.Price * amount > _account) Console.WriteLine("Not enough money");
		else
		{
			if (seller.Sell(product, amount))
			{
				_account -= product.Price * amount;
				Product boughtProuduct = new Product(product.Name, product.Price);
				boughtProuduct.Quantity = amount;
				_products.Add(boughtProuduct);
			}
		}
	}
	public void AskForProductList(Seller seller)
	{
		seller.ShowProducts();
	}
	public void ShowProducts()
	{
		if (_products.Count == 0)
		{
			Console.WriteLine("Nothing bought yet");
		}
		else
		{
			Console.WriteLine("Products bought: ");
			foreach (Product product in _products)
			{
				Console.WriteLine(product.Name + " - " + product.Quantity);
			}
		}
	}
	public void ShowAccount()
	{
		Console.WriteLine("Available funds: " + _account);
	}
}