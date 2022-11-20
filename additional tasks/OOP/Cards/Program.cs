
CardDeck Deck1 = new CardDeck(52);
//Deck1.PrintDeck();
Player player1 = new Player("player1", Deck1);
Card card1 = player1.TakeRandomCard();

player1.AddCardsToHand(card1);
card1.PrintCard();

Card card2 = player1.TakeRandomCard();
player1.AddCardsToHand(card2);
card2.PrintCard();


Card[] cards = player1.TakeCards(5);
player1.AddCardsToHand(cards);

Console.WriteLine("---");
player1.ShowCardsInHand();
Console.WriteLine("---");
Deck1.PrintDeck();