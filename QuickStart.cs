using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class QuickStart
    {// КОПИРУЙ ВСЁ ОТСЮДА, ТУТ ВСЕ ЗАДАЧИ И НУЖНЫЕ ФУНКЦИИ
        public static void Task1()
        {
            int a;
            if(!Input("a",out a)) // Если инпут пошёл не по плану - return, "завершаем программу"
                return;

            int b;
            if((!Input("b",out b)))
                return;

            int c = a + b;
            int d = a - b;
            int e = a * b;
            Console.WriteLine($"a + b = {c}, a - b = {d}, a * c = {e}"); // $ в начале строки означает что это строка с особым форматом, благодаря этосу в {} мы можем писать переменные
        }

        public static void Task2()
        {
            int a;
            if(!Input("a",out a))
                return;

            int t = a * a;
            int y = t * t;
            Console.WriteLine($"a в степени 4 = {y}");
        }

        public static void Task3()
        {
            int x;
            if(!Input("x", out x))
                return;

            int y = (((x * 2 - 3) * x + 4) * x - 5) * x - 6;
            Console.WriteLine($"y = {y}");
        }

        public static void Task4()
        {
            int a;
            if(!Input("a", out a))
                return;

            int b;
            if(!Input("b", out b))
                return;

            int x;
            if(!Input("x", out x)) //Вроде 4 было, на фотке не понятно
                return;            //      |
                                   //      v
            double S = (a * a) - (b * b) / 4 * Math.Tan(x); // Math.Tan возвращает тангенс числа
            Console.WriteLine($"S = {S}");
        }

        public static void Task5()
        {
            int x;
            if(!Input("x", out x))
                return;

            int y;
            if(!Input("y", out y))
                return;

            int max;
            if(x > y) // Если х больше чем у - максимальное х 
            {
                max = x;
            }
            else // В другом случае максимальное у
            {
                max = y;
            }
            Console.WriteLine($"максимальное {max}");
        }

        public static void Task6()
        {
            int x;
            if(!Input("x", out x))
                return;

            int y;
            if(!Input("y", out y))
                return;

            int min;
            if(x < y) // Тоже самое что и в предыдущей задаче, но меняем знак, и делаем минимум
            {
                min = x; 
            }
            else
            {
                min = y;
            }
            Console.WriteLine($"минимальное {min}");
        }

        public static void Task7()
        {
            int x;
            if(!Input("x", out x))
                return;

            int y;
            if(!Input("y", out y))
                return;

            int z;
            if(!Input("z", out z))
                return;

            int min; // Тоже самое что и в предыдущей задаче, сравнивем y и z
            if(y < z)
            {
                min = y;
            }
            else
            {
                min = z;
            }
            if(x < min) // Если х меньше чем минимальное из y и z, значит он минимальное
            {
                min = x;
            }

            Console.WriteLine($"минимальное {min}");
        }

        public static void Task8()
        {
            int x;
            if(!Input("x", out x))
                return;

            int y;
            if(!Input("y", out y))
                return;

            if(x > 0) // Если х больше нуля, то х = х в квадрате
            {
                x = x * x;
            }
            if(y > 0) // С игриком тоже самое
            {
                y = y * y;
            }
            Console.WriteLine($"x = {x}, y = {y}");
        }

        public static void Task9()
        {
            int N;
            if (!Input("N", out N))
                return;

            int i = 1;

            while(i < N) // Цикл. До тех пор пока i меньше чем N, делаем...
            {
                Console.WriteLine(i); // Выводим i 
                i++; // Инкремент, тоже самое что i = i + 1 т.е. увеличиваем на 1
            }
        }

        public static void Task10()
        {
            for(int i = 1; i < 10; i++) // Цикл со счётчиком. По порядку - создаем переменную i; выполням цикл пока i < 10; инкрементируем переменную (уже объяснял)
            {
                int A = i; // Присваиваем А значение счётчика
                int B = A * A; // Присваиваем B А в квадрате
                Console.WriteLine($"{A} в квадрате = {B}");
            }
        }

        public static bool Input(string name, out int a)
        {
            Console.Write($"Введите {name}: ");
            string s = Console.ReadLine();

            if (int.TryParse(s, out a) == false)
            {
                Console.WriteLine("Некорректное значение");
                return false;
            }
            return true;
        }
    }
}
