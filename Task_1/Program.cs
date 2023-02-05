/*Задача 1: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];
{
    Random rnd = new Random();
    for (int x = 0; x < myArray.Length; x++)
    {
        myArray[x] = rnd.Next(100, 1000);
        Console.WriteLine("Значение элемента массива " + x + " = " + myArray[x]); //Могу сделать просто в ряд, если нужно//
    }
}
int OddNumbers(int[] myArray)
{
    int count = 0;
    for (int x = 0; x < myArray.Length; x++)
    {
        if (myArray[x] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
System.Console.WriteLine($"Всего {OddNumbers(myArray)} четных числа/чисел в массиве");