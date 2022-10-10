//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
/*
Console.WriteLine ("Введите пятизначное число");
String X = Console.ReadLine()!;
if (X.Length == 5){
    if (X[0] == X[4] && X[1]==X[3]){
        Console.WriteLine("Число является палиндромом");
    }
    else
    Console.WriteLine("Число не является полиндромом");
} else{
    Console.WriteLine("Число не является пятизначным");
}
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine ("Введите коорднату первой точки х");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите коорднату первой точки y");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите коорднату первой точки z");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите коорднату второй точки х");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите коорднату второй точки y");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите коорднату второй точки z");
int z2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt (Math.Pow (x2-x1, 2) + Math.Pow (y2-y1, 2) + Math.Pow (z2-z1, 2));

Console.WriteLine ($"{result:f3}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int i = 1;
int result = 0;
while (i <= num){
    result = Convert.ToInt32(Math.Pow (i, 3));
    Console.Write($"{result}, ");
    i++;
}
*/