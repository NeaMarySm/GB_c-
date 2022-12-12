/*
ООП 3. Написать программу взаимодействия с продавцом. У продавца есть список товаров. Это список по необходимости можно запросить, и он его покажет. Так же товар можно купить - тогда он перейдет к пользователю. Пользователь так же может посмотреть свои товары и средства для покупки.
*/

Product milk = new Product("milk", 25.0);
Product bread = new Product("bread", 15.0);
Product tomato = new Product("tomato", 5.0);

Seller market = new Seller("market");

Customer customer = new Customer("Mary", 100);

market.AddToProducts(milk, bread);
market.AddToProducts(milk, bread, bread);
market.AddToProducts(tomato, 3);

Console.WriteLine("\n--- Before --- \n");

customer.AskForProductList(market);
Console.WriteLine();
Console.WriteLine("__Seller__: ");
market.ShowAccount();
Console.WriteLine();
Console.WriteLine("__Customer__: ");
customer.ShowAccount();
customer.ShowProducts();

customer.Buy(market, bread);
customer.Buy(market, tomato, 2);

Console.WriteLine("\n--- After --- \n");

customer.AskForProductList(market);
Console.WriteLine();
Console.WriteLine("__Seller__: ");
market.ShowAccount();
Console.WriteLine();
Console.WriteLine("__Customer__: ");
customer.ShowAccount();
customer.ShowProducts();