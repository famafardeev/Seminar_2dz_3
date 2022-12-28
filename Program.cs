// Задача 1. Напишите программу, которая на вхд принимает пятизначное
// число и проверяет, является ли оно полиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
string Num = Convert.ToString(num);
if (Num.Length == 5)
{
    if ((Num[0]) == (Num[4]) && (Num[1]) == (Num[3]))
    {
        Console.WriteLine($" Введённое число является полиндромом ");
    }
    else{
        Console.WriteLine($" Введённое число не является полиндромом ");
    }
}
else{
    Console.WriteLine($" Ввели неправильное число: ");
}


// Задача 2. Напишите программу, которая на вход принимает координаты 
// двух точек и находит расстояние между ними в 3d пространстве.

Console.WriteLine(" Введите координату х точки 1: ");
int xA = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Введите координату y точки 1: ");
int yA = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Введите координату z точки 1: ");
int zA = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Введите координату х точки 2: ");
int xB = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Введите координату y точки 2: ");
int yB = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Введите координату z точки 2: ");
int zB = int.Parse(Console.ReadLine()!);
double res = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine($" Расстояние между точками: {res:f2} ");

// Задача 3. Напишите программу, которая на вход принимает число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}

