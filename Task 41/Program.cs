// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел, которые хотите ввести:");
        int M = int.Parse(Console.ReadLine()); // Читаем количество чисел из консоли

        int count = 0; // Счетчик чисел, больших 0

        for (int i = 1; i <= M; i++)
        {
            Console.WriteLine("Введите число №" + i + ":");
            int number = int.Parse(Console.ReadLine()); // Читаем число из консоли

            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел, больших 0: " + count);
    }
}
