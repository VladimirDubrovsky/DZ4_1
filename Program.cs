// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Введи число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число B");
int b = Convert.ToInt32(Console.ReadLine());

// Первый способ без цикла:

// Console.WriteLine(Math.Pow(a, b));

// Второй способ с циклом

int deg = a;

for (int i = 1; i < b; i++)
{
    deg = deg *a;
}

Console.WriteLine(deg);