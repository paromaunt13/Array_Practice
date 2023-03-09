/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив размерностью в 5 элементов, 
выведите на экран все элементы массива в обратном порядке.
*/

int[] fiveElements = {1, 5, 8, 6, 4};
for (int i = fiveElements.Length - 1; i >= 0; i--)
{
    Console.Write(fiveElements[i] + " ");
}

Console.ReadKey();