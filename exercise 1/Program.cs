﻿Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number/100;
int secondDigit = number/ 10 % 10;
int thirdDigit = number % 10;
Console.WriteLine("Вторая цифра " + secondDigit);