void ShowArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(" ]");
}

string[] CreateArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        arr[i] = Console.ReadLine();
              
    }

    return arr;
}

int NumberOfValues(string[] arr)
{
    int m = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) m++;
    }

    return m;
}

string[] MinimumThreeCharacters(string[] arr, int m)
{
    string[] newArray = new string[m];

    for (int i = 0, j = 0; i < arr.Length && j < newArray.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[j] = arr[i];
            j++;
        }
    }

    return newArray;
}

Console.WriteLine("Укажите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(n);
ShowArray(myArray);
Console.WriteLine();

if (NumberOfValues(myArray) == 0)
{
    Console.WriteLine("В массиве нет элементов с длиной менее или равной трем");
}
else
{
    ShowArray(MinimumThreeCharacters(myArray, NumberOfValues(myArray)));
}