using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolgushinVA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= Math.Sin(x)) && ((x > 0) && (x <= Math.PI) && (y > 0) && (x <= 0.5)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
