// Написать программу копирования массива

int [] array = new int [7];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write($"{array[i]}\t");
}
Console.WriteLine();

int [] copy = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    copy[i] = array[i];
    Console.Write($"{copy[i]}\t");
}