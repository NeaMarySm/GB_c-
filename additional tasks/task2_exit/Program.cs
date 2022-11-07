
string[] commands = { "exit", "help", "set name", "show name", "set password", "change password" };
string? password = null;
string? name = null;
int attempts = 3;
bool cycle = true;
while (cycle)
{
    Console.WriteLine("Enter Command");
    string input = Console.ReadLine();

    switch (input)
    {
        case "exit":
            cycle = false;
            break;
        case "help":
            ShowCommands(commands);
            break;
        case "set password":
            if (password == null)
            {
                SetPassword();
            }
            else
            {
                Console.WriteLine("Password is already set.");
            }
            break;
        case "change password":
            if (password == null)
            {
                SetPassword();
            }
            else
            {
                if (CheckPassword(attempts))
                {
                    SetPassword();
                }
                else
                {
                    Console.WriteLine("Wrong password. Try again later.");
                }
            }
            break;
        case "show name":
            if (password != null)
            {
                if (CheckPassword(attempts))
                {
                    ShowName();
                }
                else
                {
                    Console.WriteLine("Wrong password. Try again later.");
                }
            }
            else
            {
                ShowName();
            }
            break;
        case "set name":
            if (password != null)
            {
                if (CheckPassword(attempts))
                {
                    SetName();
                }
                else
                {
                    Console.WriteLine("Wrong password. Try again later.");
                }
            }
            else
            {
                SetName();
            }
            break;
        default:
            Console.WriteLine("Unknown command");
            break;
    }
}
Console.WriteLine("End");

//     if (input == "exit")
//     {
//         break;
//     }
//     else if (input == "help")
//     {
//         ShowCommands(commands);
//     }
//     else if (input == "set password")
//     {
//         if (password == null)
//         {
//             SetPassword();
//         }
//         else
//         {
//             Console.WriteLine("Password is already set.");
//         }
//     }
//     else if (input == "change password")
//     {
//         if (password == null)
//         {
//             SetPassword();
//         }
//         else
//         {
//             if (CheckPassword(attempts))
//             {
//                 SetPassword();
//             }
//             else
//             {
//                 Console.WriteLine("Wrong password. Try again later.");
//             }
//         }
//     }
//     else if (input == "show name")
//     {
//         if (password != null)
//         {

//             if (CheckPassword(attempts))
//             {
//                 ShowName();
//             }
//             else
//             {
//                 Console.WriteLine("Wrong password. Try again later.");
//             }
//         }
//         else
//         {
//             ShowName();
//         }
//     }
//     else if (input == "set name")
//     {
//         if (password != null)
//         {

//             if (CheckPassword(attempts))
//             {
//                 SetName();
//             }
//             else
//             {
//                 Console.WriteLine("Wrong password. Try again later.");
//             }
//         }
//         else
//         {
//             SetName();
//         }
//     }
//     else Console.WriteLine("Unknown command");
// }

void ShowCommands(string[] commands)
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
void SetPassword()
{
    Console.WriteLine("Enter new password");
    password = Console.ReadLine();
}
bool CheckPassword(int attempts)
{
    bool result = false;
    while (Convert.ToBoolean(attempts))
    {
        Console.WriteLine("Enter your password");
        string input = Console.ReadLine();
        attempts--;
        if (input == password)
        {
            result = true;
            break;
        }
        else
        {
            if (attempts == 0)
            {
                Console.WriteLine("No attempts left.");
                break;
            }
            else
            {
                Console.WriteLine("Wrong password. Try again.");
            }
        }
    }
    return result;
}


void SetName()
{
    Console.WriteLine("Enter your name");
    name = Console.ReadLine();
}
void ShowName()
{
    if (name != null)
    {
        Console.WriteLine("Your name: " + name);
    }
    else
    {
        Console.WriteLine("Name is not set. To set name type yes");
        string confirm = Console.ReadLine();
        if (confirm == "yes")
        {
            SetName();
        }
    }
}