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
            string userInput = string.Empty;
            int month = 0;
            SalesMatrix mySalesMatrix = new SalesMatrix();
            mySalesMatrix.SalesArray = salesArray;
            WriteLine(mySalesMatrix.DisplayAllSales());

            Write("************************\n");
            Write("Enter sales month (1, 2, or 3): ");
            userInput = ReadLine();
            while (int.TryParse(userInput, out month) == false)
            {
                // Invalid Input
                Write("Invalid input. Enter sales month (1, 2, or 3): ");
                userInput = ReadLine();
            }

            WriteLine(mySalesMatrix.DisplayMonthlySales(month));

            Write("************************\n");
            Write("Enter name: ");
            WriteLine(mySalesMatrix.DisplayPersonSales(ReadLine()));
        }
    }
}
