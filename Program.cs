// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4
// 000000 - > 1

System.Console.WriteLine("Введите число: ");
double num = double.Parse(Console.ReadLine());
int count = 1;
int count2 = 1;
// while (res1 * 10 % 10 != 0)
// {   
//     res1 = res1* 10;
//     count++;
// }

while (num * Math.Pow(10, 1 + count) % 10 != 0) { count++; };




// int MyPow(int a,int n)
// {
//    result = 1;
//    for(int i = 0;i < n; i++)
//       result *= a;
//    return result;
// }
// while (d * Math.Pow(10, 1 + i) % 10 != 0) { i++; }
// while (num%10 > 10)
// {
//     num %= 10;
//     count2++;
// }

// while (num >0)
// {
//     num = num/10;
//     count2++;
// }



System.Console.WriteLine(count);
System.Console.WriteLine(res1);
// System.Console.WriteLine(count2);
// System.Console.WriteLine(num);
