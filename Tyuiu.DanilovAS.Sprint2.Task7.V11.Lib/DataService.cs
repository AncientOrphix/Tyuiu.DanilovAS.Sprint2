using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool result;
            //1) y = x
            //2) x^2 + y^2 =1
            if ((y>=x) && (Math.Pow(x,2) + Math.Pow(y,2) <= 1))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
