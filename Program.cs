// Задание №1
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;
// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"Число {number} является полиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number} НЕ является полиндромом");
//     }
// }
// else
// {
// Console.WriteLine($"Число {number} не является пятизначным числом");
// }
// Задание №2
// Console.WriteLine("Введите число N");
// string number = Console.ReadLine();
// int count = Convert.ToInt32(number);
// if (count > 0)
// {
//     for (int i = 1; i <= count; i++)
//     {

//         Console.WriteLine($"{i} в кубе = {i * i * i} ");

//     }
// }
// else
// {
//     Console.WriteLine("Необходимо ввести число больше нуля");
// }
// Задание №3
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

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

