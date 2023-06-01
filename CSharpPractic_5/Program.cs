using System;

class MainClass
{
    static void ShowColor()
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Yoou color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("You color is green!");
                break;

            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("You cokor is cyan!");
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("You color is yellow!");
                break;

        }
    }

    public static void Main(string[] args)
    {
        var (name, age) = ("Alex", 33);

        ShowColor();

        Console.WriteLine("Моё имя: {0}", name);
        Console.WriteLine("Мой возвраст: {0}", age);

        ShowColor();

        Console.Write("Введите имя: ");
        name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        ShowColor();
    }
}