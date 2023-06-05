// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4
// 000000 - > 1

System.Console.WriteLine("Введите число: ");
double num = double.Parse(Console.ReadLine());
int count = 0;
int count2 = 1;
while (num * up(10, 1 + count) % 10 != 0) { count++; };
while (num / up(10, count2) > 1) { count2++;}
int result = count + count2;


int up (int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
        res = res*a;

return res;
}

System.Console.WriteLine($"Цифр после запятой: {count}");
System.Console.WriteLine($"Цифр до запятой: {count2}");
System.Console.WriteLine(result);
