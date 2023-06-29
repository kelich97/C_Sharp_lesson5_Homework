// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.WriteLine("Hello, World!");

double [] RandomArray()
{
    int size = 5;
    double [] randomArray = new double [size];
    for( int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(0, 100) + new Random().NextDouble();
    }
    return randomArray;
}


void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2}.  ");
    }
    Console.WriteLine();
}

void FindMinMax (double[] array)
{
    double max = 0;
    double min = 100;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
        
    }
    Console.Write($"{max:f2} - {min:f2} = {(max - min):f2} ");
}

double[] array = RandomArray();
PrintArray(array);
FindMinMax(array);










