Console.Clear();
Console.Write("Введите число - ");
int numberA = int.Parse(Console.ReadLine());
int square = numberA*numberA;
Console.Write("Квадрат этого числа - ");
Console.WriteLine(square);
Console.Write($"Квадрат числа {numberA} равен {square}");