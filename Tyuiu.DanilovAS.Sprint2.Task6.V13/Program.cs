using Tyuiu.DanilovAS.Sprint2.Task6.V13.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Данилов А. С. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич |  ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращённую форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* g - год, m - порядковый номер месяца, n - число			             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(g, m, n);
            Console.WriteLine("Ответ: " + res);
            Console.ReadKey();
        }
    }
}
