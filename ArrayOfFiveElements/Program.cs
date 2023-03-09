/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив размерностью в 5 элементов, 
выведите на экран все элементы массива.
*/

int[] fiveElements = {1, 5, 8 ,6, 4};
for (int i = 0; i < fiveElements.Length; i++)
{
    Console.Write(fiveElements[i] + " ");
}

Console.ReadKey();