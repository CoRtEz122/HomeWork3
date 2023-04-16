// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число");
// int input = Convert.ToInt32(Console.ReadLine());

// int a = input / 10000;
// int b = input % 10;
// int c = input / 1000 % 10;
// int d = input % 100 / 10;
// Console.WriteLine("1-е число: "+a);
// Console.WriteLine("5-е число: "+b);
// Console.WriteLine("2-е число: "+c);
// Console.WriteLine("4-е число: "+d);

// if (a == b && c == d)
// {
//     Console.WriteLine("Да");
// }

// else
// {
//     Console.WriteLine("нет");
// }



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите X1");
// int X1 = Convert.ToInt32(Console.ReadLine());        

// Console.WriteLine("Введите X2");
// int X2 = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Введите Y1");
// int Y1 = Convert.ToInt32(Console.ReadLine());        

// Console.WriteLine("Введите Y2");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Z1");
// int Z1 = Convert.ToInt32(Console.ReadLine());        

// Console.WriteLine("Введите Z2");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2));

// Console.WriteLine(d);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите N");
int input = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i <= input)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}


