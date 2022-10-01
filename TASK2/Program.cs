// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


Console.WriteLine("Введите первое число");
double firstNumber = double.Parse( Console.ReadLine()!);

Console.WriteLine("Ввдеите второе число");
double secondNumber = double.Parse( Console.ReadLine()!);

Console.WriteLine("Ввдеите третье число");
double thirdNumber = double.Parse( Console.ReadLine()!);

const int SIZE = 3;
double[] ourArray = new double[SIZE] {firstNumber, secondNumber, thirdNumber};
double maxNumber = firstNumber;

for (int i = 0; i < SIZE; i++ )
{
if ( maxNumber <= ourArray[i])
{
    maxNumber = ourArray[i];
}

}
Console.WriteLine ("Самое большое число "+ maxNumber);

