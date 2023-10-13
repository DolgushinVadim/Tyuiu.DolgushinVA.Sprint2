using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolgushinVA.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (n < 31)
                    {
                        n++;
                    }
                    else
                    {
                        n = 1;
                        m++;
                    }
                    res = $"{n:D2}.{m:D2}.{g}";
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (n < 30)
                    {
                        n++;
                    }
                    else
                    {
                        n = 1;
                        m++;
                    }
                    res = $"{n:D2}.{m:D2}.{g}";
                    break;

                case 2:
                    if (n < 28)
                    {
                        n++;
                    }
                    else
                    {
                        n = 1;
                        m++;
                    }
                    res = $"{n:D2}.{m:D2}.{g}";
                    break;

                case 12:
                    if (n < 31)
                    {
                        n++;
                    }
                    else
                    {
                        n = 1;
                        m = 1;
                        g++;
                    }
                    res = $"{n:D2}.{m:D2}.{g}";
                    break;

                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Введённое значение {m}");
            }
            return res;
        }
    }
}


