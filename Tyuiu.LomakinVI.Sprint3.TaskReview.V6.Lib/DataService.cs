using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LomakinVI.Sprint3.TaskReview.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double chisl = 3 * Math.Cos(x);
                double znam = 4 * x - 0.5;
                if (znam == 0)
                {
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                double result = chisl / znam + Math.Sin(x) - 5 * x - 2;
                y = Math.Round(result, 2);

                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
