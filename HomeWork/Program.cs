// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] InputMassive()
{
    System.Console.WriteLine("Введите числа через запятую с пробелами:");
    string[] arr = Console.ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);
    return arr;
}

int CountNum(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (int.Parse(arr[i]) > 0) count++;
    }
    return count;
}

string[] Array = InputMassive();
System.Console.WriteLine($"Количетво чисел больше 0 в массиве равно {CountNum(Array)}");