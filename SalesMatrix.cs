﻿using System;
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
            return result;
        }

        public string DisplayMonthlySales(int month)
        {
            if (month < 1 || month > 3)
            {
                return String.Format("Invalid input. Month value out of range.\n");
            }
            double monthlySales = 0;
            for (int i = 0; i < salesArray.GetLength(0); i++)
            {
                monthlySales += double.Parse(salesArray[i, month]);
            }
            return String.Format("Total for month {0:c}\n", monthlySales);
        }

        public string DisplayPersonSales(string person)
        {
            for (int i = 0; i < salesArray.GetLength(0); i++)
            {
                if (salesArray[i, 0].ToUpper() == person.ToUpper())
                {
                    double personSales = 0;
                    for (int m = 0; m < 3; m++)
                    {
                        personSales += double.Parse(salesArray[i, m + 1]);
                    }
                    return String.Format("Sales for {0} are {1:c}\n", person.ToUpper(), personSales);
                }
            }
            return string.Format("Name {0} not found", person);
        }
    }
}
