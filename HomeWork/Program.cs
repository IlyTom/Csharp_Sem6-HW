// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] InputConst()
{
    System.Console.WriteLine("Введите коэффициенты прямой k и b:");
    double[] arr = new double[2];
    arr[0] = double.Parse(Console.ReadLine()!);
    arr[1] = double.Parse(Console.ReadLine()!);
    return arr;
}

void CheckCoordinateXLine(double[] arr1, double[] arr2)
{
    double x = (arr2[1] - arr1[1]) / (arr1[0] - arr2[0]);
    double y = arr1[0] * x + arr1[1];
    System.Console.WriteLine($"Точка пересечения двух прямых находиться в точке ({x}; {y})");
}

double[] Array1 = InputConst();
double[] Array2 = InputConst();

CheckCoordinateXLine(Array1, Array2);