// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительными массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science", -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();

string[] CreateArray()
{
    int size = default;
    Console.Write("Введите размер массива: ");
    while (!int.TryParse(Console.ReadLine(), out size))
        Console.Write("Повторите попытку.\nВведите натуральное положительное целое число: ");

    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int FindSizeFinalArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Convert.ToString(array[i]).Length <= 3) count++;
    }
    return count;
}

string[] SelectionArray(string[] array, int finalSizeArr, int count = 0)
{

    string[] resultArray = new string[finalSizeArr];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }
    }
    return resultArray;
}

string[] mass = CreateArray();
Console.Write($"Изначальный массив - ");
PrintArray(mass);

int finalSizeArray = FindSizeFinalArray(mass);

Console.Write($"  Финальный массив - ");
string[] result = SelectionArray(mass, finalSizeArray);
PrintArray(result);