using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint4.Task7.V10.Lib;

namespace Tyuiu.SorokinMA.Sprint4.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            string c = "695847142536";
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Сорокин М. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Сорокин Михаил Анатольевич | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр . Преобразуйте ее в     *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество строк = "+a);
            Console.WriteLine("Количество столбцов = "+b);
            Console.WriteLine("Строка \""+c+"\"");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] d = new int[a, b];
            Console.WriteLine("Матрица :");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    d[i, j] = int.Parse(c.Substring(i * a + j, 1));
                    Console.Write($" {d[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма нечётных чисел = " + ds.Calculate(a, b, c));
            Console.ReadKey();

        }
    }
}
