//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("Введите число, которое Вы хотите найти: ");
int num1 = int.Parse(Console.ReadLine());
int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); 
        Console.Write($"{res[i]} ");
    }
    return res;
}
int [] array = GetArray(10, -5, 5);

Console.WriteLine();

void SelectionSort(int[]array)
{
for (int i = 0; i < array.Length - 1 ; i++)
{
if(array[j] == array[num1]); Console.Write($"да");
else Console.Write($"нет");
}
}
SelectionSort(array);

