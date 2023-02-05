/*Задача 3: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3, 7.4, 22.3, 2, 78] -> 76*/

int InputInt(string message)
{
    System.Console.Write($"{message}");
    return int.Parse(Console.ReadLine()!);
}
double[] myArray(int size)
{
    double[] array = new double[size];
    for (int x = 0; x < array.Length; x++)
    {
        Random rnd = new Random();
        double numbers = (int)Math.Round(rnd.NextDouble() * (100 - 1) + 1, 2);
        array[x] = numbers;
    }
    return array;
}
void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        System.Console.WriteLine($"{item}\t ");
    }
    System.Console.WriteLine();
}

double MaxNum(double[] myArray)
{
    double max = myArray[0];
    for (int x = 0; x < myArray.Length; x++)
    {
        if (myArray[x] > max)
        {
            max = myArray[x];
        }
    }
    return max;
}
double MinNum(double[] myArray)
{
    double min = myArray[0];
    for (int x = 0; x < myArray.Length; x++)
    {
        if (myArray[x] < min)
        {
            min = myArray[x];
        }
    }
    return min;
}

int size = InputInt("Введите длинну массива: ");
double[] array = myArray(size);
PrintArray(array);
double max = MaxNum(array);
double min = MinNum(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round(max - min, 2)}");
