// ;Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите целое число");
int ourNumber = int.Parse(Console.ReadLine());

if ( ourNumber%2 ==0)
{
    Console.WriteLine("Да, это число четное");
}
else 
{
    Console.WriteLine("Нет, это число не четное");
}