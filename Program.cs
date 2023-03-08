// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine()!);

if (number%2==0)
{
    Console.WriteLine( "" + number + " число четное" );
}
else
{
  Console.WriteLine( "" + number + " число нечетное" );
}
