// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int numToThePower(int num, int deg)
{
    int result = 1;
    for(int i = 1; i <= deg; i++)
    {
        result = result * num;
    }
    return result;
}

Console.WriteLine("Int a number:");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Int a degree of a number:");

int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number {number} to the power of {degree} will be equal to {numToThePower(number, degree)}");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int numOfDigits(int num)
{
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int sumOfDigits(int numOfDigits, int num)
{
    int result = 0;
    for(int i = 0; i <= 5; i++)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine("Введите целое число");

int number = Convert.ToInt32(Console.ReadLine());

int numberOfDigits = numOfDigits(number);

int digitsSum = sumOfDigits(numberOfDigits, number);

Console.WriteLine($"Number {number} has {numberOfDigits} digits and their sum {digitsSum}");
*/

 //Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
 /*
 int[] createArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i ++)
    {
        Console.WriteLine($"Fill element with index {i}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void writeArr(int[] array, int size)
{
    Console.Write($"Your array have length {size} and elements - ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
}

Console.WriteLine("Enter the size of the array");

int arrSize = Convert.ToInt32(Console.ReadLine());

writeArr(createArray(arrSize), arrSize);
*/