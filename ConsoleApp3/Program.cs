namespace ConsoleApp3
{
    internal class Program
    {
        static DateTime date = new DateTime(2023, 10, 23);
        static int date1 = 1;
        static int position = 1;
        static void Main(string[] args)
        {
            Menu();
            Strelki();
            Desc();
        }
        static void Menu()
        {
            if (date1 == 1)
            {
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
                Console.WriteLine("  1. Придти на пары");
                Console.WriteLine("  2. Поиграть в HOI4");
            }
            else if (date1 == 2)
            {
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
                Console.WriteLine("  1. Долго ехать в МПТ");
                Console.WriteLine("  2. Долго ехать домой");
            }
            else if (date1 == 3)
            {
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
                Console.WriteLine("  1. Проснуться");
                Console.WriteLine("  2. Сидеть за компом");
            }
        }
        static void Strelki()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && position > 1)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 3)
                    {
                        position = 2;
                    }
                }
                else if ( key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(date.ToShortDateString());
                    date1--;
                    Menu();
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(+1);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(date.ToShortDateString());
                    date1++;
                    Menu();
                }


                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
        }
        static void Desc()
        {
            if (position == 1 && date1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Придти на пары");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Пары со второй по пятую.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 2 && date1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Поиграть в HOI4");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Играть в Hearts of Iron 4 минимум 2 часа.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 1 && date1 == 2)
            {
                Console.Clear();
                Console.WriteLine("Долго ехать в МПТ");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Ехать в МПТ 2 часа и сидеть со 2 по 5 пару.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 2 && date1 == 2)
            {
                Console.Clear();
                Console.WriteLine("Долго ехать домой");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Ехать домой 2 часа и потом отдыхать.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 1 && date1 == 3)
            {
                Console.Clear();
                Console.WriteLine("Проснуться");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Проснуться не раньше 10:00 и не позже 12:30.");
                Console.WriteLine(date.ToShortDateString());
            }
            else if (position == 2 && date1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Сидеть за компом4");
                Console.WriteLine("---------------");
                Console.WriteLine("Описание: Играть во что-нибудь весь день, при наличии ДЗ возможно сделать его.");
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
}