/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев. После чего
пользователь вводит диапазон (например, 3 и 6 – поиск между 3-м и 6-м месяцем). Необходимо
определить месяц, в котором прибыль была максимальна и месяц, в котором прибыль была
минимальна с учетом выбранного диапазона.
*/

int[] months = new int[12];

Console.WriteLine($"Введите прибыль за каждый месяц, грн.: ");
for (int i = 0; i < months.Length; i++)
{
    Console.WriteLine($"Прибыль за {i+1}й месяц: ");
    months[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Введите первый месяц диапазона: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второй месяц диапазона: ");
int b = int.Parse(Console.ReadLine());

int[] revenueRange = months[--a..b];
int minRevenue = revenueRange.Min();
int maxRevenue = revenueRange.Max();

Console.WriteLine($"Минимальная прибыль в заданном диапазоне - {minRevenue} грн.");
Console.WriteLine($"Максимальная прибыль в заданном диапазоне - {maxRevenue} грн.");

Console.ReadKey();