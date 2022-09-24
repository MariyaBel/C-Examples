// В тексте строчные буквы k заменить на заглавные K
// заглавные С заменить на с

string text = "Whenever I see your sweetest smile,"
            + "My pain and sorrow are gone for a while."
            + "Whenever I get mad because you're so unruly,"
            + "You'll just hug me and say, "I'm sorry!"";


string Replace(string text, char oldValue, char newValue) // функция по замене элемента в строке
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result =result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, 'с', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'k', 'K');