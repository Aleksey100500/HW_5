//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new  Random().Next(100, 999);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }   
}

void EveNum(int[] res)
{   
    int count1 = res.Length;
    int result = 0;

    int index = 0;

    while ( index < res.Length)
    {
        if ( res[index] % 2 == 0)
        {
            result++;
        }
        index++;
    }
    Console.WriteLine(result);
}
int[] array = new int[4];                   

FillArray(array);                           
PrintArray(array);                         
EveNum(array);                             


