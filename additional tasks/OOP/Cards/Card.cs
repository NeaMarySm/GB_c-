class Card
{
	private Suit _suit;
	private Rank _rank;

	public Card(Suit suit, Rank rank)
	{
		_suit = suit;
		_rank = rank;
	}
	public void PrintCard()
	{
		Console.WriteLine($"{_rank} of {_suit}");
	}
}

enum Suit
{
	Hearts,
	Diamonds,
	Clubs,
	Spades

}
enum Rank
{
	Ace,
	Two,
	Three,
	Four,
	Five,
	Six,
	Seven,
	Eight,
	Nine,
	Ten,
	Jack,
	Queen,
	King
}