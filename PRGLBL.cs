using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC
{
    public class PRGLBL
    {
        public void METOD1()
        {
            Console.WriteLine("Helou world");
        }
        public void METOD2()
        {
            Console.WriteLine("Сиди учи програмирование неуч");
        }
        public static bool Vdffd(int n)
        {
            return n % 2 == 0;

        }
        public static int df(int a, int b, int c)
        {
            return (a + b) / c;
        }
        public static string rt(int z, int x, int y)
        {
            if(z>(x+y))
            {
                return "z больше чем ссума x и y";
            }
            else
            {
                return "z меньше суммы x и y";
            }
        }

        public static void P()
        {
            Console.WriteLine("Введите число для проверки нечётности n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число {n} четное: {Vdffd(n)}");

            Console.WriteLine("Введите первое число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Результат (a+b)/c: {df(a, b, c)}");

            Console.WriteLine("Введите четвертое число z:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пятое число x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шестое число y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Условное вычисление ({z},{x},{y}): {rt(z, x, y)}");
        }

    }


}

