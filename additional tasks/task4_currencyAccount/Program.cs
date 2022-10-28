/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. Программа заканчивает свою работу в тот момент, когда решит пользователь. */

string[] currencies = { "usd", "eur", "ru", "cny" };
double rateEur = 0.978;
double rateRu = 0.016;
double rateCny = 0.136;

string userName = "sam";
string password = "pass";
bool authorized = false;
int attempts = 3;
bool cycle = true;

string[] allCommands = { "exit", "help", "rates", "login", "balance", "exchange", "deposit" };
string[] unAuthCommands = { "exit", "help", "rates", "login" };


double accountUsd = 0;
double accountEur = 0;
double accountRu = 0;
double accountCny = 0;


while (cycle)
{
    Console.WriteLine("Enter Command. To see available commands print 'help'");
    string input = Console.ReadLine();

    switch (input)
    {
        case "help":
            ShowHelp(authorized, allCommands, unAuthCommands);
            break;
        case "exit":
            cycle = false;
            break;
        case "login":
            LogIn();
            break;
        case "balance":
            if (authorized)
            {
                ShowBalance();
            }
            else
            {
                Console.WriteLine("You should be authorized to proceed.");
            }
            break;
        case "rates":
            ShowRates();
            break;
        case "deposit":
            if (authorized)
            {
                Deposit();
            }
            else
            {
                Console.WriteLine("You should be authorized to proceed.");
            }
            break;
        case "exchange":
            if (authorized)
            {
                Exchange();
            }
            else
            {
                Console.WriteLine("You should be authorized to proceed.");
            }
            break;
        default:
            Console.WriteLine("Unknown Command");
            break;
    }

}

// Methods

void ShowHelp(bool authorized, string[] commands, string[] unAuthCommands)
{
    if (!authorized)
    {
        PrintCommands(unAuthCommands);
    }
    else
    {
        PrintCommands(commands);
    }
}

void LogIn()
{
    if (Convert.ToBoolean(attempts))
    {
        Console.WriteLine("Enter username");
        string inputName = Console.ReadLine();
        Console.WriteLine("Enter password");
        string inputPassword = Console.ReadLine();
        if (inputName == userName && inputPassword == password)
        {
            authorized = true;
            Console.WriteLine("Authorization success");
            return;
        }
        else
        {
            attempts--;
            Console.WriteLine("Wrong password or username. Enter 'yes' to try again.");
            string confirm = Console.ReadLine();
            if (confirm.ToLower() == "yes")
            {
                LogIn();
            }
        }
    }
    else Console.WriteLine("No attempts left. Try again later");

}

void ShowRates()
{
    Console.WriteLine("Exchange rates:");
    Console.WriteLine($"1 USD = {rateEur} EUR");
    Console.WriteLine($"1 USD = {rateRu} RU");
    Console.WriteLine($"1 USD = {rateCny} CNY");
}

void ShowBalance()
{

    Console.WriteLine("Your Balance:");
    Console.WriteLine($"USD: {Math.Round(accountUsd, 2)}$");
    Console.WriteLine($"EUR: {Math.Round(accountEur, 2)}€");
    Console.WriteLine($"RU: {Math.Round(accountRu, 2)}₽");
    Console.WriteLine($"CNY: {Math.Round(accountCny, 2)}¥");

}

void PrintCommands(string[] commands)
{
    Console.WriteLine();
    int index = 0;
    while (index < commands.Length)
    {
        Console.WriteLine(commands[index]);
        index++;
    }
    Console.WriteLine();
}

void Deposit()
{
    Console.WriteLine("Choose deposit currency");
    ShowCurrencies(currencies);
    string inputCurrency = SetCurrency("Enter currency: ");
    Console.WriteLine("Enter deposit amount");
    double inputValue = Convert.ToDouble(Console.ReadLine());
    switch (inputCurrency)
    {
        case "usd":
            accountUsd += inputValue;
            break;
        case "eur":
            accountEur += inputValue;
            break;
        case "ru":
            accountRu += inputValue;
            break;
        case "cny":
            accountCny += inputValue;
            break;
    }
}

void Exchange()
{
    string initialCurrency = SetCurrency("Which currency account to use? ");
    string targetCurrency = SetCurrency("To what currency convert? ");
    double value = SetValue("Enter currency amount ");
    double balance = GetAccountBalance(initialCurrency);
    if (balance >= value)
    {
        double result = ConvertToTarget(initialCurrency, targetCurrency, value);
        ChangeAccountBalance(targetCurrency, result);
        ChangeAccountBalance(initialCurrency, -value);
        Console.WriteLine("Exchange success");
        ShowBalance();

    }
    else Console.WriteLine("Insufficient funds to exchange");

}

void ShowCurrencies(string[] currencies)
{
    Console.WriteLine("Available currencies:");
    foreach (string currency in currencies)
    {
        Console.Write(currency.ToUpper() + " ");
    }
    Console.WriteLine();
}

bool IsAvailableString(string inputString, string[] availableStrings)
{
    foreach (string elem in availableStrings)
    {
        if (inputString == elem)
        {
            return true;
        }
    }
    return false;
}

double ConvertToUsd(string inputCurrency, double inputValue)
{
    double result = inputValue;
    switch (inputCurrency)
    {
        case "usd":
            break;
        case "eur":
            result = inputValue * rateEur;
            break;
        case "ru":
            result = inputValue * rateRu;
            break;
        case "cny":
            result = inputValue * rateCny;
            break;
    }
    return result;
}

double ConvertToTarget(string inputCurrency, string targetCurrency, double inputValue)
{
    double result = inputValue;
    if (inputCurrency == targetCurrency)
    {
        return result;
    }
    double value = ConvertToUsd(inputCurrency, inputValue);
    switch (targetCurrency)
    {
        case "usd":
            result = value;
            break;
        case "eur":
            result = value / rateEur;
            break;
        case "ru":
            result = value / rateRu;
            break;
        case "cny":
            result = value / rateCny;
            break;
    }
    return result;
}

string SetCurrency(string message)
{
    while (true)
    {
        Console.Write(message);
        string input = (Console.ReadLine()).ToLower();
        if (IsAvailableString(input, currencies))
        {

            return input;
        }
        else
        {
            Console.WriteLine("Unavailable currency.");
        }
    }
}

double SetValue(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        double input = Convert.ToDouble(Console.ReadLine());
        if (input < 0)
        {
            Console.WriteLine("Invalid value.");
        }
        else
        {
            return input;
        }

    }

}

double GetAccountBalance(string currency)
{
    double result = accountUsd;
    switch (currency)
    {
        case "usd":
            break;
        case "eur":
            result = accountEur;
            break;
        case "ru":
            result = accountRu;
            break;
        case "cny":
            result = accountCny;
            break;
    }
    return result;
}

void ChangeAccountBalance(string currency, double value)
{
    switch (currency)
    {
        case "usd":
            accountUsd += value;
            break;
        case "eur":
            accountEur += value;
            break;
        case "ru":
            accountRu += value;
            break;
        case "cny":
            accountCny += value;
            break;
    }
}

