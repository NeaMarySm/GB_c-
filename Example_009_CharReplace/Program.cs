string text = "В последней своей книге «Научитесь мыслить и рисовать как Леонардо да Винчи: семь шагов к гениальности каждый день» \nМайкл Гелб описывает 7 творческих принципов знаменитого мастера, чтобы развить креативность и максимально \nактивизировать свой творческий потенциал";

string newText = Replace(text, 'а', '@');
// Console.WriteLine(newText);

newText = Replace(newText, ' ', '_');
Console.WriteLine(newText);


string Replace(string text, char oldChar, char newChar)
{
    int length = text.Length;
    string result = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldChar)
        {
            result = result + $"{newChar}";
        }
        else
        {
            result = result + text[i];
        }
    }
    return result;
}

