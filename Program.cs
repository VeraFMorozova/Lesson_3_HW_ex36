// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] generateArray(int Length, int start, int end)
{
    int [] result = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
void printArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
         if(i < array.Length - 1)
         {
            Console.Write(", ");
         }
    }
     Console.Write("]");
}
int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getSumOfOddNumber(int [] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] % 2 != 0)
        {
            Sum = Sum + array[i];
        }
        else 
        {
            Sum = Sum + 0;
        }
    }
    return Sum;
}
int Number = getUserData("Введите количество элементов в массиве");
int [] array = generateArray(Number, 0, 20);
printArray(array);
int SumOfOddNumber = getSumOfOddNumber(array);
Console.Write($"Сумма нечетных чисел в массиве равна {SumOfOddNumber}");