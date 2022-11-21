Console.Clear();
Console.Write("Введите число a - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b - ");
int numberB = int.Parse(Console.ReadLine());
Console.Write($"Является ли число {numberA} квадратом числа {numberB}? ");
int square = numberB*numberB;
if (numberA == square)
{
    Console.WriteLine ("Да, является.");
}
else
{
    Console.WriteLine ("Не является");
}
