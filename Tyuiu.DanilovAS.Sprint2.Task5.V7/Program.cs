using Tyuiu.DanilovAS.Sprint2.Task5.V7.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Данилов А. С. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич |  ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня. 	     *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня		     *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int startYear = 1990;
            Console.Write("Введите номер дня:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ответ: " + ds.FindMonthName(startYear, n));
            Console.ReadKey();
        }
    }
}
