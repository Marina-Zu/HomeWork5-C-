// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

double[] CreateArray(int lenght)     // метод(функция) для создания массива
{
    double [] answer = new double[lenght];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(0, 100);
    }
    return answer;
}
void PrintArray(double[] array)                // вывод массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "   ");
    }
    System.Console.WriteLine();
}

double MaxMinMinus(double[] num)
{
    double max = num[0];
    double min = num[0];
    for (int i = 1; i < num.Length; i++)
    {
        if (max < num[i]) max = num[i];
        if (min > num[i]) min = num[i];
    }
    double result = max - min;
    return result;
}

int lenght = Prompt("Введите число элементов массива > ");
double [] array = CreateArray(lenght);
PrintArray(array);
double answer = MaxMinMinus(array);
System.Console.WriteLine($"Разность между max и min числом равна {answer}");

