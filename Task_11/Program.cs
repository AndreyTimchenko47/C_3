// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 999 + 1);
Console.WriteLine($"Случайное трёхзначное число -> {number}");

int Circumcision(int num)
{
    int firstDigit = num / 100;
    Console.WriteLine($"Случайное  число -> {firstDigit}");
    int thirdDigit = num % 10;
    Console.WriteLine($"Случайное  число -> {thirdDigit}");
    firstDigit = firstDigit * 10;
    int result = firstDigit + thirdDigit;
    return result;
}

int newnumb = Circumcision(number);
Console.WriteLine($"Случайное двухзначное число -> {newnumb}");
