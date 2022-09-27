// Перебор всех слов из заданного алфавита

int n=1;
void FindWords(string alphabet, char [] word, int length = 0)// alphabet - алафавит букв для перебора, word - массив (слово=массив)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;// счетчтк+слово
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("aisr", new char [4]);//2х буквенных слов = 4^2 = 16, 3x- 4^3=64, 4х = 4^4 =256 и т.д.