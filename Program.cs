// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



int InPut(string mes)
{
    System.Console.WriteLine(mes);
    return int.Parse(Console.ReadLine());
    
}

int a = InPut("Введите число A: ");
int b = InPut("Введите число B: ");
int res = 1;

for (int i = 0; i < b; i++)
    res = res*a;

System.Console.WriteLine(res);