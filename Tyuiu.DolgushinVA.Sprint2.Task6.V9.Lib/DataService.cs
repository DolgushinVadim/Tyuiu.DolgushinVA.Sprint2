using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolgushinVA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if ((n > 0) && (n < 31))
                    {
                        n++;
                    }
                    else
                    {
                        if (n == 31)
                        {
                            n = 1;
                            m++;
                        }
                        else
                        {
                            throw new ArgumentException($"Введён некорректный день. Введённое значение {n}");
                        }
                    }
                    return $"{n:D2}.{m:D2}";
                case 4:
                case 6:
                case 9:
                case 11:
                    if ((n > 0) && (n < 30))
                    {
                        n++;
                    }
                    else
                    {
                        if (n == 30)
                        {
                            n = 1;
                            m++;
                        }
                        else
                        {
                            throw new ArgumentException($"Введён некорректный день. Введённое значение {n}");
                        }
                    }
                    return $"{n:D2}.{m:D2}";
                case 2:
                    if ((n > 0) && (n < 28))
                    {
                        n++;
                    }
                    else
                    {
                        if (n == 28)
                        {
                            n = 1;
                            m++;
                        }
                        else
                        {
                            throw new ArgumentException($"Введён некорректный день. Введённое значение {n}");
                        }
                    }
                    return $"{n:D2}.{m:D2}";
                case 12:
                    if ((n > 0) && (n < 31))
                    {
                        n++;
                    }
                    else
                    {
                        throw new ArgumentException($"Введён некорректный день. Введённое значение {n}");
                    }
                    return $"{n:D2}.{m:D2}";
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Введённое значение {m}");
            }
        }
    }
}
