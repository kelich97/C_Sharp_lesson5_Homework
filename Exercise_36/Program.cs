// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int [] RandomArray()
{
    int size = 4;
    int [] arrayRandom = new int [size];
    for (int i = 0; i < size; i++)
    {
        arrayRandom[i] = new Random().Next(-100, 100); 
    }
    return arrayRandom;
}

void SumOfElem (int [] array)
{
    int count = 0;
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (count % 2 == 0)
            current = current + array[count];    
        count++;
        Console.Write(array[i] + "  " );
    }
    Console.Write(" -> " + current);
}

int [] arr = RandomArray();
SumOfElem(arr);










