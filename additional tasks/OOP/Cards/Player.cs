class Player
{
	public string _name;
	public Card[] _cardsInHand;
	public CardDeck _deck;
	public Player(string name, CardDeck deck)
	{
		_name = name;
		_deck = deck;
		_cardsInHand = new Card[0];
	}

	public Card TakeRandomCard()
	{
		int maxIndex = _deck._cards.Length;
		int randomIndex = new Random().Next(0, maxIndex + 1);
		Card randomCard = _deck._cards[randomIndex];
		_deck.RemoveFromDeck(randomCard);
		return randomCard;
	}
	public Card[] TakeCards(int number)
	{
		Card[] takenCards = new Card[number];
		for (int i = 0; i < number; i++)
		{
			takenCards[i] = TakeRandomCard();
		}
		return takenCards;
	}

	public void AddCardsToHand(Card card)
	{
		Card[] tempCards = new Card[_cardsInHand.Length + 1];
		for (int i = 0; i < _cardsInHand.Length; i++)
		{
			tempCards[i] = _cardsInHand[i];
		}
		tempCards[_cardsInHand.Length] = card;
		_cardsInHand = tempCards;
	}
	public void AddCardsToHand(Card[] cards)
	{
		Card[] tempCards = new Card[_cardsInHand.Length + cards.Length];
		for (int i = 0; i < _cardsInHand.Length; i++)
		{
			tempCards[i] = _cardsInHand[i];
		}
		for (int i = 0, j = _cardsInHand.Length; i < cards.Length; i++, j++)
		{
			tempCards[j] = cards[i];
		}
		_cardsInHand = tempCards;
	}
	public void ShowCardsInHand()
	{
		foreach (Card card in _cardsInHand)
		{
			card.PrintCard();
		}
	}
}