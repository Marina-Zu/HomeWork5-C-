// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int[] CreateArray(int lenght)     // метод(функция) для создания массива
{
    int[] answer = new int[lenght];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(100, 1000);
    }
    return answer;
}
void PrintArray(int[] array)                // вывод массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "   ");
    }
    System.Console.WriteLine();
}

int EvenNumber(int[] num)
{
    int summ = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 == 0) summ++;
    }
    return summ;
}

int lenght = Prompt("Введите число элементов массива > ");
int[] array = CreateArray(lenght);
PrintArray(array);
int result = EvenNumber(array);
System.Console.WriteLine($"В массиве {result} чётных чисел");