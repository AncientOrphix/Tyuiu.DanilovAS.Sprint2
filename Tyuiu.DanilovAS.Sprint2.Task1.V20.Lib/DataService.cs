using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DanilovAS.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            DataService ds = new DataService();

            bool[] res = new bool[6];
            res[0] =(a<b)|(b>c);
            res[1] =(b==a)&(d!=17);
            res[2] = (c<=d)||(d>=b);
            res[3] = (c>d)&&(b!=d);
            res[4] = !(c <= d);
            res[5] = (c>b)^(b<d);

            return res;

        }
    }
}
