/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создает метод, который в качестве аргументов принимает:
1)целочисленный массив(int [] array), 2)целочисленный индекс(int index), 3)количество
элементов (int count), возвращает целочисленный массив элементов(int [] subArray).
Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции
указанной в аргументе index, размерностью, которая соответствует значению аргумента count.
*/

int[] array = {1,3,6,9,4};
int[] newArray = ArrayReturn(array, 4, 10);
foreach (var item in newArray)
{
    Console.Write(item + " ");
}
int[] ArrayReturn(int[] array, int index, int count)
{
    int[] subArray = new int[count];
    array.CopyTo(subArray, index);
    return subArray;    
}

Console.ReadKey();