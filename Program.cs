// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

string[] NoMoreThreeCharacters(string[] array) // 1 вариант
{
    string temp = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            if (temp == string.Empty) temp += array[i];
            else temp = temp + "," + array[i];
        }
    }
    string[] filteredArray = temp.Split(',');
    return filteredArray;
}

string[] NoMoreThreeCharacters2(string[] array) // 2 вариант
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) size++;
    string[] filteredArray = new string[size];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
        if (array[j].Length <= 3) filteredArray[k++] = array[j];
    return filteredArray;
}

Console.WriteLine("Введите значения через запятую:");
string[] arrayOfInputValues = Console.ReadLine()!.Replace(" ", "").Split(',');
PrintStringArray(arrayOfInputValues);

Console.Write(" 1 вариант -> ");
string[] noMoreThreeCharacters = NoMoreThreeCharacters(arrayOfInputValues);
PrintStringArray(noMoreThreeCharacters);

Console.Write(" 2 вариант -> ");
string[] noMoreThreeCharacters2 = NoMoreThreeCharacters2(arrayOfInputValues);
PrintStringArray(noMoreThreeCharacters2);
