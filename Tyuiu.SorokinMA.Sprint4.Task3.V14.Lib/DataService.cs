using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SorokinMA.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0)+1;
            int columns = array.Length / rows;
            int m = int.MinValue;
            for (int i =0; i<rows;i++)
            {
                for(int j =0; j<columns;j++)
                {
                    if (i == 3 && array[i, j] > m) m = array[i, j];
                }
            }
            return m;
        }
    }
}
