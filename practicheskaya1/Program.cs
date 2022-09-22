int command = 0;
while (command != 9)
{
    Console.WriteLine("Введите номер команды из предложенных ниже: ");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое число из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1% от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    int vibor = Convert.ToInt32(Console.ReadLine());
    command = vibor;

    if (command == 1)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        Console.WriteLine("Ответ:");
        Console.WriteLine(c = a + b);

    }
    if (command == 2)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        Console.WriteLine("Ответ:");
        Console.WriteLine(c = b - a);
    }
    if (command == 3)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        Console.WriteLine("Ответ:");
        Console.WriteLine(c = a * b);

    }
    if (command == 4)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        Console.WriteLine("Ответ:");
        Console.WriteLine(c = a / b);
    }
    if (command == 5)
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());

        int c = 1;

        Console.WriteLine("Введите степень:");
        int b = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < b; i++)
        {
            c = c * a;
        }

        Console.WriteLine("Ответ:");
        Console.WriteLine(c);
    }
    if (command == 6)
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ответ:");
        Console.WriteLine(Math.Sqrt(a));

    }
    if (command == 7)
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());

        float b;

        Console.WriteLine("Ответ:");
        Console.Write(b = (float)(a / 100.0));
        Console.WriteLine("%");

    }
    if (command == 8)
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());

        int b = 1;
        int c = 1;
        int i = 0;

        while (i < a)
        {
            c = c * b;
            b++;
            i++;
        }

        Console.WriteLine("Ответ:");
        Console.WriteLine(c);

    }
}