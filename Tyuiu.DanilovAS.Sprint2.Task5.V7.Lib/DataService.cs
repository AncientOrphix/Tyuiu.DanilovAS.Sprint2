using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int monthIndex = n % 12;

            string monthName;

            switch (monthIndex)
            {
                case 1:
                    monthName = "Январь";
                    break;
                case 2:
                    monthName = "Февраль";
                    break;
                case 3:
                    monthName = "Март";
                    break;
                case 4:
                    monthName = "Апрель";
                    break;
                case 5:
                    monthName = "Май";
                    break;
                case 6:
                    monthName = "Июнь";
                    break;
                case 7:
                    monthName = "Июль";
                    break;
                case 8:
                    monthName = "Август";
                    break;
                case 9:
                    monthName = "Сентябрь";
                    break;
                case 10:
                    monthName = "Октябрь";
                    break;
                case 11:
                    monthName = "Ноябрь";
                    break;
                case 0:
                    monthName = "Декабрь";
                    break;
                default:
                    monthName = "Неизвестный месяц"; 
                    break;
            }

            return monthName;


            //n  - дни, startyear - 2;
            /* string res;
             switch (n)
             {
                 case 1: res = "январь"; break;
                 case 2: res = "февраль"; break;
                 case 3: res = "март"; break;
                 case 4: res = "апрель"; break;
                 case 5: res = "май"; break;
                 case 6: res = "июнь"; break;
                 case 7: res = "июль"; break;
                 case 8: res = "август"; break;
                 case 9: res = "сентябрь"; break;
                 case 10: res = "октябрь"; break;
                 case 11: res = "ноябрь"; break;
                 case 12: res = "декабрь"; break;
                 default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");
             }
             return res;*/
        }
    }
}
