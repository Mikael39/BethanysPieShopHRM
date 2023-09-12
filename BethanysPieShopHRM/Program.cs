using System;
using System.ComponentModel.Design;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int amount = 1234;
            int months = 12;

            int yearlyWage = CalculateYearlyWage(amount, months);
            Console.WriteLine($"Yearly wage: {yearlyWage}");
            Console.ReadLine();

            static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
            {
                return monthlyWage * numberOfMonthsWorked;
            }

        }
    }

}