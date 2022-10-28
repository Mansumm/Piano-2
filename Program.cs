using System.Linq.Expressions;

namespace Пианино
{
    internal class Program
    {
        static int[] FirstOctave = { 35, 39, 44, 49, 54, 59, 61, 66, 71, 76, 81, 86 };
        static int[] SecondOctave = { 70, 75, 78, 83, 88, 93, 98, 103, 108, 113, 118, 123 };
        static int[] ThirdOctave = { 135, 140, 145, 150, 155, 170, 185, 196, 207, 220, 233, 246 };

        static void Main(string[] args)
        {
            Console.WriteLine("Выбери октаву: F1, F2, F3 \n " + "Клавиши: D, R, F, T, G, Y, H, U, J, I, K, L");
            do
            {
                int[] a = Octave();
                if (a == FirstOctave)
                {
                    Console.WriteLine("1 октава: ");
                    Sound(a);
                }
                if (a == SecondOctave)
                {
                    Console.WriteLine("2 октава");
                    Sound(a);

                }
                else if (a == ThirdOctave)
                {
                    Console.WriteLine("3 октава");
                    Sound(a);
                }

            } while (true);
            static int[] Octave()
            {
                int[] klav = new int[13];
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Console.WriteLine(Key.Key);
                    if (Key.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("Первая октава: ");
                        klav = FirstOctave;
                        return klav;
                    }
                    else if (Key.Key == ConsoleKey.F2)
                    {
                        Console.WriteLine("Вторая октава: ");
                        klav = SecondOctave;
                        return klav;
                    }
                    else if (Key.Key == ConsoleKey.F3)
                    {
                        Console.WriteLine("Третья октава: ");
                        klav = ThirdOctave;
                        return klav;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Выбери октаву: F1, F2, F3 \n " +
                            "Клавиши: D, R, F, T, G, H, U, J, I, K, L");
                        return klav;
                    }
                }
            }
        }

        private static int[] Sound(int[] bah)

        {
            int[] clavisha = new int[13];
            do
            {
                ConsoleKey KeySound = Console.ReadKey().Key;
                switch (KeySound)
                {
                    case ConsoleKey.D:
                        Console.Beep(bah[0] + 1000, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.R:
                        Console.Beep(bah[1] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.F:
                        Console.Beep(bah[2] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.T:
                        Console.Beep(bah[3] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.G:
                        Console.Beep(bah[4] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(bah[5] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.H:
                        Console.Beep(bah[6] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.U:
                        Console.Beep(bah[7] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.J:
                        Console.Beep(bah[8] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.I:
                        Console.Beep(bah[9] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.K:
                        Console.Beep(bah[10] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.L:
                        Console.Beep(bah[11] + 1050, 300);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;

                    case ConsoleKey.F1:
                        bah = FirstOctave;
                        return bah;
                        break;
                    case ConsoleKey.F2:
                        bah = SecondOctave;
                        return bah;
                        break;
                    case ConsoleKey.F3:
                        bah = ThirdOctave;
                        return bah;
                        break;
                    default:
                        Console.Clear();
                        continue;
                        break;

                }
            } while (true);
        }
    }
}