// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int count = 0;
int result = 0;
int InPut()
{
    System.Console.WriteLine("Введите число: ");
    return int.Parse(Console.ReadLine());
}
int num = InPut();
void fis(int bar)
{
    while (bar > 0)
    {
        bar = bar / 10;
        count++;
    }
}
void Fronti(int[] func, int bar)
{
    for (int i = 0; i < count; i++) if (i == 0) func[i] = bar % 10;
        else
        {
            bar = bar / 10;
            func[i] = bar % 10;
        }
}
fis(num);
int [] massiv = new int [count];
Fronti(massiv, num);

void print()
{
for(int i = 0; i < count; i++)
    result += massiv[i];

System.Console.WriteLine(result);
}
print();