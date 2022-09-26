// Метод для строкового массива

string[] CreateStringArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element of array: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateStringArray(a);
ShowArray(myArray);