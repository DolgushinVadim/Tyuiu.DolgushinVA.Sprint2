using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolgushinVA.Sprint2.Task3.V7.Lib
{
    public class DataService : ISprint2Task3V7
    {
        public double Calculate(double x)
        {
            double y = 0;
            if ((x > 0) && (x != 1))
            {
                y = x * Math.Pow((Math.Pow(x, 2) + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
                }
                else
                {
                    if ((x < 0) && (x > -11))
                    {
                        y = Math.Pow((7 + (1 / Math.Pow(x, 2))), x);
                    }
                    else
                    {
                        if (x <= -11)
                        {
                            y = Math.Pow(x, 4) - (3 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
