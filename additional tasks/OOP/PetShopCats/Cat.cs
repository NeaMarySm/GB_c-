
class PetShopCat
{
	public string _name;
	public string _breed;
	public string _color;
	public Gender _gender;
	public DateTime _dateOfBirth;
	public double _price;
	private string[] _foodToEat = { "fish", "milk", "meat", "water", "catfeed" };
	private int Age => DateTime.Today.Year - _dateOfBirth.Year;
	public PetShopCat(string name, string breed, Gender gender, string color, DateTime dateOfBirth, double price)
	{
		_name = name;
		_breed = breed;
		_gender = gender;
		_color = color;
		_dateOfBirth = dateOfBirth;
		_price = price;
	}
	public bool IsFood(string food)
	{
		bool result = false;
		foreach (string item in _foodToEat)
		{
			if (item == food.ToLower())
			{
				result = true;
				break;
			}
		}
		return result;
	}
	public void ShowCharacteristics()
	{
		Console.WriteLine($"The {_breed} cat, name: {_name}, gender: {_gender}, age: {Age}, colour: {_color}. Price {_price} RU");
	}
	public void ShowFoodPreferences()
	{
		Console.Write($"{_name} eats only: ");
		foreach (string item in _foodToEat)
		{
			Console.Write(item + " ");
		}
		Console.WriteLine();
	}
	public void Eat(string food)
	{
		if (IsFood(food))
		{
			Console.WriteLine($"{food} Yam-yam!");
		}
		else Console.WriteLine($"{food}!? Meh!");
	}
	public void Sleep()
	{
		Console.WriteLine("Zzzzzzzz...");
	}
	public void Meow()
	{
		Console.WriteLine("Meow-meow");
	}
	public void Scratch()
	{
		Console.WriteLine("  \\ \\ \\ \\ \n\\ | | | | \n| | | | ");
	}
}
