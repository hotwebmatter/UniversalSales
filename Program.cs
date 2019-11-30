using System;
using static System.Console;

namespace UniversalSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] salesArray = { {"Collier", "2500", "35000", "20000"},
                                {"Lee", "17000", "50000", "10000"},
                                {"Brown", "13000", "25000", "25000"},
                                {"Cano", "55000", "35000", "30000"} };
            SalesMatrix mySalesMatrix = new SalesMatrix();
            mySalesMatrix.SalesArray = salesArray;
            WriteLine(mySalesMatrix.DisplayAllSales());
        }
    }
}
