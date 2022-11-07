string[] currencies = { "usd", "eur", "ru", "cny" };
double rateEur = 0.978;
double rateRu = 0.016;
double rateCny = 0.136;

ShowCurrencies(currencies);
string inputCurrency = SetCurrency("Enter your currency:");
string targetCurrency = SetCurrency("Enter target currency:");
double value = SetValue("Enter value:");
double result = ConvertToTarget(inputCurrency, targetCurrency, value);
Console.WriteLine(result);


string SetCurrency(string message)
{
    while (true)
    {
        Console.WriteLine(message);
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

