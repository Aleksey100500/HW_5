/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/
class Programm
{
    public static void Main (string[] args)
    {
        int sum = 0;
        int[] numbers = new int[4];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new  Random().Next(-99, 99);

            Console.Write(numbers[i] + " ");
        }

        for( int i = 0; i < numbers.Length; i++)
        {
            if ( i == 1) 
            {
                sum = sum + numbers[i];
            }

            if ( i == 3)
            {
                sum = sum + numbers[i];
            } 
        }
        Console.WriteLine(" | "+ sum);
    }
}