Console.Clear();
Console.Write("Введите  трехзначное число - ");
int number1 = int.Parse(Console.ReadLine());
int result = number1%10;
Console.Write($"Последняя цифра числа {number1} является {result} ");