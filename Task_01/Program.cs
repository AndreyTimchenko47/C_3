// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из диапазона 10-99 - - > {number}");

// int firstDigit = number / 10; // 38 / 10 = 3 так как целые числа
// int secondDigit = number % 10; // 38 % 10 = 8 остаток числа после деления

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа - > {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа - > {secondDigit}");

//int result = firstDigit > secondDigit ? firstDigit : secondDigit; // другой вариант условия и его вывода

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа - > {maxDigit}");

int MaxDigit(int num) // решение задачи через функцию
{
    int firstDigit = num / 10; 
    int secondDigit = num % 10; 
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
