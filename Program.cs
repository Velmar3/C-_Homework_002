/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// int Threenumber()
// {
//     Console.Write("Введите трёхзначное число: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int result = ((n / 10) % 10);
//     Console.Write("Вторая цифра: " + result);
//     return result;
// }

// Threenumber();

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

// void ThreeNumberTwo()
// {
//     Console.Write("Введите число: ");
//     int n = Convert.ToInt32(Console.ReadLine());
        
//     if (n < 100) 
//     {
//         Console.Write("Третьей цифры нет!");
//     }
//     else
//     {
//         for ( ; n >= 1000; n /= 10);
//         int result = n % 10;
//         Console.Write("Третья цифра: " + result);
//     }
// }

// ThreeNumberTwo();

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

// void TaskThree()
// {
//     Console.Write("Введите цифру от 1 до 7: ");
//     int n = Convert.ToInt32(Console.ReadLine());
        
//     if (n <= 0) 
//     {
//         Console.Write("Ошибка! Неправильная цифра.");
//     }
//     else if (n < 2)
//     {
//         Console.Write("Нет");
//     }
//     else if (n < 3)
//     {
//         Console.Write("Нет");
//     }
//     else if (n < 4)
//     {
//         Console.Write("Нет");
//     }
//     else if (n < 5)
//     {
//         Console.Write("Нет");
//     }
//     else if (n < 6)
//     {
//         Console.Write("Нет");
//     }
//     else if (n < 7)
//     {
//         Console.Write("Да");
//     }
//     else if (n < 8)
//     {
//         Console.Write("Да");
//     }
    
// }

// TaskThree();

