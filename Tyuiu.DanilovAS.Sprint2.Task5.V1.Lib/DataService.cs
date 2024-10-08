using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task5.V1.Lib
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int daysInMonth = 0;
            switch (value)
            {
                case 1: daysInMonth = 31; break;//31
                case 2: daysInMonth = 28; break;//29 - Високосный
                case 3: daysInMonth = 31; break;//31
                case 4: daysInMonth = 30; break;//30
                case 5: daysInMonth = 31; break;//31
                case 6: daysInMonth = 30; break;//30
                case 7: daysInMonth = 31; break;//31
                case 8: daysInMonth = 31; break;//31
                case 9: daysInMonth = 30; break;//30
                case 10:daysInMonth = 31; break;//31
                case 11:daysInMonth = 30; break;//30
                case 12:daysInMonth = 31; break;//31

            }
            return daysInMonth;
        }
    }
}
