string[] SplitTheString(string text)
{
    string[] resultArray = text.Split(";");
    return resultArray;
}

Console.WriteLine("Введите строки через " + ";");
string text = Console.ReadLine();
SplitTheString(text);