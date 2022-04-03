// Написать программу, которая из 
// имеющегося массива строк 
// формирует массив из строк,
// длинна которых меньше либо равна 3 символа.


string[] firstArray = { "One", "Repo", "Double", "123", "3345", "Fin", "Finish" };
Console.WriteLine("Задан массив строк:");
PrintArray(firstArray);
string[] newArray = GetNewArray(firstArray);
string[] GetNewArray(string[] firstArray)
{
    string[] newArray = new string[firstArray.Length];
    int size = 0;
    for (var i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[size] = firstArray[i];
            size++;
        }
    }
    Array.Resize(ref newArray, size);
    return newArray;
}
void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write(item);
    }
}
Console.WriteLine();
Console.WriteLine("Строки из трёх слов :");
PrintArray(newArray);
