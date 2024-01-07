Console.Clear();
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArrayReversed(int [] arr, int index)
{
    if (index>=0)
    {
        Console.Write(arr[index] + ", " ); 
        PrintArrayReversed(arr, index - 1); 
    }
}

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
Console.WriteLine(string.Join(", ", array));
PrintArrayReversed(array, array.Length - 1); 