class Seller
{
	private string _name;
	public string Name => _name;
	private double _account;
	private List<Product> _products;

	public Seller(string name, double account = 0)
	{
		_name = name;
		_account = account;
		_products = new List<Product>();
	}
	public void AddToProducts(params Product[] newProducts)
	{
		List<Product> tempList = new List<Product>();
		tempList.AddRange(newProducts);
		foreach (Product item in tempList)
		{
			Product? prod = _products.Find(p => p == item);
			if (prod != null) prod.Add();
			else _products.Add(item);
		}
	}
	public void AddToProducts(Product product, int amount = 1)
	{
		Product? prod = _products.Find(p => p == product);
		if (prod != null) prod.Add(amount);
		else
		{
			product.Quantity = amount;
			_products.Add(product);
		}
	}
	public void ReduceProductQuantity(Product item, int amount)
	{
		foreach (Product product in _products)
		{
			if (product == item) product.Reduce(amount);
			if (product.Quantity == 0) _products.Remove(product);
		}
	}
	public void ShowProducts()
	{
		if (_products.Count == 0)
		{
			Console.WriteLine("Product list is empty.");
		}
		else
		{
			Console.WriteLine("List of products: ");
			foreach (Product product in _products)
			{
				Console.WriteLine("* " + product.Name
				+ ", price: " + product.Price
				+ ", quantity: " + product.Quantity);
			}
		}
	}
	public bool Sell(Product product, int amount)
	{
		Product? prod = _products.Find(p => p == product);
		if (prod != null)
		{
			if (amount <= prod.Quantity)
			{
				ReduceProductQuantity(prod, amount);
				_account += prod.Price * amount;
				return true;
			}
			else
			{
				Console.WriteLine("Not enough product available");
				return false;
			}
		}
		else
		{
			Console.WriteLine("No such product available");
			return false;
		}
	}
	public void ShowAccount()
	{
		Console.WriteLine("Funds in the account: " + _account);
	}
}