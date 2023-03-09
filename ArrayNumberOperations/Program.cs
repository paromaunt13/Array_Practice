/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив размера N элементов (размер массива задет
пользователь), заполнить его произвольными целыми значениями. Вывести на экран:
наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов,
среднее арифметическое всех элементов, вывести все нечетные значения.
*/

Console.WriteLine("Введите размерность массива: ");
int[] numbers = new int[int.Parse(Console.ReadLine())];

int sum = 0;
int average = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Random random = new();
    numbers[i] = random.Next(1,20);
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
    average = sum / numbers.Length;

    if (numbers[i] % 2 != 0)
    {
        Console.WriteLine($"Нечетное значение - {numbers[i]}");
    }
}

Console.WriteLine($"Наибольшее значение массива - {numbers.Max()}");
Console.WriteLine($"Наименьшее значение массива - {numbers.Min()}");
Console.WriteLine($"Сумма всех элементов массива - {sum}");
Console.WriteLine($"Среднее арифметическое всех элементов массива - {average}");

Console.ReadKey();