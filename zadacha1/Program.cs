Console.Clear();
string[] array = new string[6] {"456", "Hello", "Kazan", "12", "num", "=!"};
Console.Write($"Изходный массив: [");
PrintArray(array);
Console.Write($"] ");
Console.Write($"\nИтоговый массив: [");
string[] myArray = new string[array.Length];
SortArray(array, myArray);
PrintArray(myArray);
Console.Write($"]");


void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SortArray(string[] array,string[] myArray)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        myArray[count] = array[i];
        count++;
    }
}