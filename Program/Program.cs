//разбиение строки через разделитель
string[] SplitTheString(string textAr)
{
    string[] resultArray = textAr.Split(";");
    return resultArray;
}

//коррекция строки по количеству символов(не более 3)
string[] CorrectTheLine(string[] array)
{
    string[] correctLine = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            correctLine[i] = array[i];
        }
        else correctLine[i] = string.Empty;
    }

    correctLine = correctLine.Where(e => e != string.Empty).ToArray();//удалить элементы массива, равные пустой строке
    return correctLine;
}

//распечатать строки
void PrintLines(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
}

Console.WriteLine("Введите строки через " + '"' + ";" + '"');
string text = Console.ReadLine();
if (text != string.Empty)
{
    SplitTheString(text);
    string[] textArray = SplitTheString(text);
    string[] correctArray = CorrectTheLine(textArray);
    PrintLines(correctArray);
}
else Console.WriteLine("Вы не заполнили строку");


