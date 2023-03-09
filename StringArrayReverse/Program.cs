/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте два строковых массива с именами A и B (размерностью
4 элемента). Массив A заполняется в цикле пользователем. Получить результирующий массив B,
обратный к исходному массиву A (элементы массива B идут в обратном порядке по отношению к массиву A).
*/
Console.WriteLine("Заполните массив четырьмя строками: ");

string[] aString = new string[4];
string[] bString = new string[4];

for (int i = 0; i < aString.Length; i++)
{
    aString[i] = Console.ReadLine();
}

for(int j = 0, i = aString.Length - 1; j < bString.Length && i >= 0; j++, i--)
{
   bString[j] = aString[i];
   Console.Write(bString[j] + " ");
}

Console.ReadKey();