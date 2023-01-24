Console.Clear();

// 1. Задать массив из 8 элементов и вывести их на экран
/* 
int size = 8;

int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

//PrintArray(SetArray(size));
Console.WriteLine();
 */
// Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
/* int size = 12; // количество элементов массива
int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}
//задаем массив
int[] arr = SetArray(size);
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0) sum1 += arr[i];
    else sum2 += arr[i];
}
Console.WriteLine ($"Сумма отрицательных чисел массива = {sum1}");
Console.WriteLine ($"Сумма положительных чисел массива = {sum2}");
// cчитаем суммы и выводим их
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}
//это вывод массива
PrintArray(arr);
Console.WriteLine(); */

// Написать программу замену элементов массива на противоположные
/* Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine()!); 
int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int[] arr = SetArray(size);
Console.WriteLine(string.Join(", ", arr));
for (int i = 0; i < arr.Length; i ++)
{
    arr[i] = -arr[i];// arr[i] * -1;
}
Console.WriteLine(string.Join(",", arr)); */

/* Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите левую границу диапазона");
int minimum = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите правую границу диапазона");
int maximum = int.Parse(Console.ReadLine()!); 
int[] array = new int[size];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(minimum, maximum + 1);
Console.Write("Your array: ");
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
    array[i] = -array[i];
Console.Write("Your changed array: ");
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
 */


void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}
int[] CreateArray(int size, int minimum, int maximum)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minimum, maximum + 1);
    return array;
}
void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}
void Swap<T>(ref T first, ref T second)
{
    T tmp = first;
    first = second;
    second = tmp;
}
Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side elements of array: ");
int minimum = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side elements of array: ");
int maximum = int.Parse(Console.ReadLine() ?? "0");
if (minimum > maximum)
    Swap(ref minimum,ref maximum);
int[] array = CreateArray(size, minimum, maximum);
Console.Write("Your array: ");
PrintArray(array);
ChangeArray(array);
Console.Write("Your changed array: ");
PrintArray(array);








