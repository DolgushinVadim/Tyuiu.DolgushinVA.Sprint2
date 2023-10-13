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
            if (g > 0)
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
                        res = $"{n:D2}.{m:D2}.{g:D4}";
                        break;
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
                        res = $"{n:D2}.{m:D2}.{g:D4}";
                        break;
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
                        res = $"{n:D2}.{m:D2}.{g:D4}";
                        break;
                    case 12:
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
                                g++;
                            }
                            else
                            {
                                throw new ArgumentException($"Введён некорректный день. Введённое значение {n}");
                            }
                        }
                        res = $"{n:D2}.{m:D2}.{g:D4}";
                        break;
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Введённое значение {m}");
                }
                return res;
            }
            else
            {
                throw new ArgumentException($"Введён некорректный год. Введённое значение {g}");
            }
        }
    }
}


