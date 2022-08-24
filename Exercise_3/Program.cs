/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/
class Program
{
    public static void Main (string[] args)
    {
        double result = 0;


        double[] numbers = new double[5];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-99, 99);

            Console.Write(numbers[i] + " ");
        }
        double min = numbers.Min();
        double max = numbers.Max();

        result = max - min;
        Console.WriteLine(" " +  "=> " + result);
    }
}