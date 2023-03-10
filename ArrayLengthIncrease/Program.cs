/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте метод, который будет выполнять увеличение длины
массива переданного в качестве аргумента, на 1 элемент. Метод, должен принимает два
аргумента, первый аргумент - типа int[] array, второй аргумент - типа int value. В теле
метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0,
при этом длина нового массива, должна увеличиться на 1 элемент, а элементы получаемого
массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.
*/

int[] array = {1, 3};
ArrayLengthAdd(array, 2);
void ArrayLengthAdd(int[] array, int value)
{   
    int[] newArray = new int[array.Length + 1];
    newArray[0] = value;
    array.CopyTo(newArray, 1);

    foreach (var item in newArray)
    {
        Console.Write(item + " ");
    }
}

Console.ReadKey();
