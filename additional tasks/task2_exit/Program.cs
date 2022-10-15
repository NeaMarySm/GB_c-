string exitWord = "exit";
bool cycle = true;
while(cycle){
    Console.WriteLine("Enter Something");
    string input = Console.ReadLine();
    if(input == exitWord){
        cycle = false;
    }
}
Console.WriteLine("End");