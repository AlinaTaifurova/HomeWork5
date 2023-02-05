/*Задача 2: 
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 6] -> 0*/

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
int SumOdd(int[] myArray)
{
    int sum = 0;
    for (int x = 1; x < myArray.Length; x += 2)
    {
        {
            sum = sum + myArray[x];
        }
    }
    return sum;
}
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {SumOdd(myArray)}");