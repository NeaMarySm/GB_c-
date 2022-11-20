class CardDeck
{
	private int _deckSize;
	public Card[] _cards;

	public CardDeck(int deckSize)
	{
		_deckSize = deckSize;
		FullfillDeck();
	}
	public void FullfillDeck()
	{
		_cards = new Card[_deckSize];
		int cardsAdded = 0;
		for (int i = _deckSize == 54 ? 0 : 5; i < _deckSize / 4; i++)
		{
			_cards[cardsAdded++] = new Card(Suit.Hearts, (Rank)i);
			_cards[cardsAdded++] = new Card(Suit.Diamonds, (Rank)i);
			_cards[cardsAdded++] = new Card(Suit.Clubs, (Rank)i);
			_cards[cardsAdded++] = new Card(Suit.Spades, (Rank)i);
		}
	}
	public void PrintDeck()
	{
		foreach (Card card in _cards)
		{
			card.PrintCard();
		}
	}
	public void RemoveFromDeck(Card cardToRemove)
	{
		Card[] tempCardsDeck = new Card[_cards.Length - 1];
		int index = 0;
		foreach (Card card in _cards)
		{
			if (card == cardToRemove)
			{
				continue;
			}
			tempCardsDeck[index] = card;
			index++;
		}
		_cards = tempCardsDeck;
	}
}