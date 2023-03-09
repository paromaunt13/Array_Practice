/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив целых чисел размерности 10х10 и заполните его
случайными элементами. Выведете на консоль полученный массив. Найдите суммы элементов
каждой строки, произведения элементов каждого столбца, и максимальный элемент главной
диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца).
*/

int[,] array = new int[10, 10];
Random random = new();

#region Инициализация массива
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {   
        array[i, j] = random.Next(1,10);
    }
}
#endregion

#region Вывод массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
#endregion

#region Сумма элементов каждой строки массива
for (int i = 0, s = 1; i < array.GetLength(0); i++, s++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Сумма элементов {s}-й строки массива - {sum}");
}
Console.WriteLine();
#endregion

#region Сумма произведения элементов каждого столбца массива
for (int i = 0, s = 1; i < array.GetLength(1); i++, s++)
{
    int sum = 1;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum *= array[j, i];
    }
    
    Console.WriteLine($"Сумма произведения элементов {s}-го стобца массива - {sum}");
}
Console.WriteLine();
#endregion

#region Максимальный элемент главной диагонали
int[] range = new int[array.Length];

for (int i = 0, j = 0; i < array.GetLength(0)&& j < array.GetLength(1); i++, j++)
{
    range[i] = array[i, j];
}
int max = range.Max();       

Console.WriteLine($"Максимальный элемент главной диагонали - {max}");
Console.WriteLine();
#endregion

Console.ReadKey();