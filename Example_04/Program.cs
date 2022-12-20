// // Лекция 3
// // Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// } 
// Method2(msg: "Текст сообщения");   

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// // Method21(msg: "Текст", count: 4);
// // Method21(count: 4, msg: "новый текст");

// //Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// } 

// int yaer = Method3();
// // Console.WriteLine(yaer);


// //Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
    
//      while (i < count)
//      {
   
//           result = result + text;
//           i++; 
//      }
//      return result;

// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);



                              //Семинар 4 Домашняя работа:

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int numberA = ReadInt("Введите число A: ");
// int numberB = ReadInt("Введите число B: ");
// ToDegree(numberA, numberB);


// // Функция возведения в степень:
// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }

// // Функция ввода:
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);


// // Функция ввода:
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция подсчета цифр в числе:
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// // Функция вывода суммы цифр в числе:
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]                           

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода:
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}