/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте метод, который в качестве параметра принимает слово,
а возвращает то же слово, но с измененным порядком букв в слове на обратный.
*/

Console.WriteLine("Введите слово: ");
string word = Console.ReadLine();

ReverseWord(word);
void ReverseWord(string inputWord)
{
    char[] reverseLetters = new char[inputWord.Length];
    for (int i = reverseLetters.Length - 1; i >= 0; i--)
    {
        reverseLetters[i] = inputWord[i];
        Console.Write(reverseLetters[i]);       
    }
}

Console.ReadKey();
