class Product
{
	public string Name { get; private set; }
	public double Price { get; private set; }
	private int _quantity;
	public int Quantity
	{
		get { return _quantity; }
		set { _quantity = value; }
	}
	public Product(string name, double price)
	{
		Name = name;
		Price = price;
		_quantity = 1;
	}
	public void Add(int amount = 1)
	{
		_quantity += amount;
	}
	public void Reduce(int amount = 1)
	{
		if (amount <= _quantity)
			_quantity -= amount;
		else Console.WriteLine("Not enough product");
	}
}