// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительными массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science", -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
int sizeFinalArray=0;
string[] CreateArray()
{
    Console.Write("Введите количество вводимых строк: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    int sizeFinalArray = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите строку: ");
        array[i] = Console.ReadLine();
        if (array[i].Length <= 3) sizeFinalArray++;
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

string[] SelectionArray(string[] array, int sizeFinalArray)
{
    int count = 0;
    string[] resultArray = new string [sizeFinalArray];
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
PrintArray(mass);

string[] result = SelectionArray(mass, sizeFinalArray);
PrintArray(result);