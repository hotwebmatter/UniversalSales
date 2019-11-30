using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSales
{
    class SalesMatrix
    {
        private string[,] salesArray;
        
        public string[,] SalesArray
        {
            set { salesArray = value; }
        }

        public string DisplayAllSales()
        {
            string result = String.Format("************************\n");
            result += String.Format("Display all sales\n");
            result += String.Format("Name\tJan\tFeb\tMar\n");
            // Generate sales matrix
            for (int i = 0; i < salesArray.GetLength(0); i++)
            {
                result += String.Format("{0}\t{1}\t{2}\t{3}\n", salesArray[i, 0], salesArray[i, 1], salesArray[i, 2], salesArray[i, 3]);
            }
            result += String.Format("\n************************\n");
            return result;
        }

        public string DisplayMonthlySales(int month)
        {
            double monthlySales = 0;
            string result = String.Format("************************\n");
            for (int i = 0; i < salesArray.GetLength(0); i++)
            {
                monthlySales += double.Parse(salesArray[i, month]);
            }
            result += String.Format("Total for month {0:c}", monthlySales);
            result += String.Format("\n************************\n");
            return result;
        }
    }
}
