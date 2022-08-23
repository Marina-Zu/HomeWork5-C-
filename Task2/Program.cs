// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        answer[i] = rnd.Next(0, 100);
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

int SumUnevenNumbers(int[] num)
{
    int summ = 0;
    for (int i = 0; i < num.Length; i = i + 2)
    {
        summ = summ + num[i];
    }
    return summ;
}

int lenght = Prompt("Введите число элементов массива > ");
int[] array = CreateArray(lenght);
PrintArray(array);
int result = SumUnevenNumbers(array);
System.Console.WriteLine($"Сумма чисел на нечетных позициях равна {result}");