// курс "Знакомство с языками программирования" вебинар 4 домашнее задание

// Задача 25: Напишите цикл, который принимает
// на вход два числа (А и В) и возводит число
// А в натуральную степерь В.

int RaiseNumberAToPowerB(int A, int B)
{
    if (B < 0)
    {
        System.Console.WriteLine("Число В должно быть больше -1");
        return -1;
    }

    if (A == 0) return 0;

    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }

    return result;
}
string exit_condition = String.Empty;
while (exit_condition != "n")
{
    System.Console.WriteLine("Программа принимает на вход два числа (А и В) и возводит число А в натуральную степерь В");
    System.Console.Write("Введите число А: ");
    int.TryParse(Console.ReadLine(), out int A);
    int B = -1;
    while (B < 0)
    {
        System.Console.Write("Введите число B: ");
        int.TryParse(Console.ReadLine(), out B);
        if(B >= 0) break;
        System.Console.WriteLine("Число B должно быть больше -1");
    }
    System.Console.WriteLine($"{A} в степени {B} равно: {RaiseNumberAToPowerB(A, B)}");
    System.Console.WriteLine();
    System.Console.Write("Хотите сделать это ещё раз? y / n  ");
    exit_condition = Console.ReadLine();
}

System.Console.WriteLine("Благодарим за использование программы!");