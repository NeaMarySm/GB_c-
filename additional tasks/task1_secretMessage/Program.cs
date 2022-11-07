/*
1. В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.
*/

string secret = "some secret message";
string password = "verydifficultpassword";
int attempts = 3;

while (Convert.ToBoolean(attempts))
{
    Console.WriteLine("Enter your password");
    string input = Console.ReadLine();
    attempts--;

    if (input == password)
    {
        Console.WriteLine(secret);
        attempts = 0; 
    }
    else
    {
        if (attempts == 0)
        {
            Console.WriteLine("No attempts left");
        }
        else
        {
            Console.WriteLine("Wrong password. Try again. " + attempts + " attempts left.");
        }
    }
}
