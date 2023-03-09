void Insert(string?[] array, int n)
{
    Console.WriteLine("Введите элементы массива");
    int count = 0;
    while (count < n)
    {
        Console.Write("Введите " + (count + 1) + " элемент массива - ");
        array[count] = Console.ReadLine();
        count++;
    }
}
int CheckCount(string[] array, int n)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i].Length < 4) count++;
    }
    return count;
}
void FillArray(string[] array, string[] newarray)
{
    int position = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length < 4)
        {
            newarray[position] = array[i];
            position++;
        }
    }
}
void PrintArray(string[] array, int n)
{
    Console.Write("{");
    for (int i = 0; i < n; i++)
    {
        Console.Write(array[i]);
        if (i != n - 1) Console.Write(" ; ");
    }
    Console.Write("}");
    Console.WriteLine();
}

Console.WriteLine("Введите количество элеметов массива: ");
int n = int.Parse(Console.ReadLine()!);
string[] startarray = new string[n];
Insert(startarray, n);
Console.WriteLine("Введен массив: ");
PrintArray(startarray, n);
int newarraylength = CheckCount(startarray, n);
string[] newarray = new string[newarraylength];
FillArray(startarray, newarray);
Console.WriteLine("Новый массив: ");
PrintArray(newarray, newarraylength);



