                                    //    Домашняя работа по 3 семинару:         

//     Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");


// }
  
//          Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");


// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.Write(message);
// //     return Convert.ToInt32(Console.ReadLine());
// }


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125                                     
                                              
//  int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }


// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }                                             
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                              
                                                // Задание на семинаре 3:

// //Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuart (double x, double y)
// {
//     if(x>0 && y>0)
//     return 1;
//     if(x<0 && y>0)
//     return 2;
//     if(x<0 && y<0)
//     return 3;
//     if(x>0 && y<0)
//     return 4;

//     return 0;
// }

// Console.WriteLine("Input X:");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y:");
// double y = Convert.ToDouble(Console.ReadLine());

// int result = FindQuart(x,y);

// if(result==0)
// Console.WriteLine("Point not find");
// else
// Console.WriteLine($"Point located in {result} quart");



//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindCoordinats (int quart)
// {
//     if(quart==1)
//     {
//         Console.WriteLine("Диапазон координат (x+ y+)");
//     }
//     if(quart==2)
//     {
//         Console.WriteLine("Диапазон координат (x- y+)");
//     }
//     if(quart==3)
//     {
//         Console.WriteLine("Диапазон координат (x- y-)");
//     }
//     if(quart==4)
//     {
//         Console.WriteLine("Диапазон координат (x+ y-)");
//     }
//     if ( quart < 1 && quart > 4)
//     Console.WriteLine("Заданной четверти не существует");
// }

// Console.WriteLine("Введите номер четверти:");
// int quart = Convert.ToInt32(Console.ReadLine());
// FindCoordinats(quart);



//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// void Coordinats( double x, double y,double x1, double y1)
// {
//    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x-x1),2)+Math.Pow((y-y1),2)),2));
// }
// Console.WriteLine("input x=");
// double x=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y=");
// double y=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input x1=");
// double x1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y1=");
// double y1=Convert.ToDouble(Console.ReadLine());
// Coordinats(x,y,x1,y1);




//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N
 
// void Quad(int N)
// {
//     if (N<1)
//     {
//         Console.WriteLine("Вы ввели неправильные данные");
//     }
//     int index=1;
//     while(index < N+1) 
//     {
//         Console.WriteLine(Math.Pow(index,2));
//     index=index+1;
//     }
// }
// Console.WriteLine("input N=");
//  int x=Convert.ToInt32(Console.ReadLine());
//  Quad(x);
