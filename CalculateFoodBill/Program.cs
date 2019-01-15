using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // The solve function below takes as input the price of a meal, the tip percent, and the tax percent
    // and outputs the total cost of the meal, the sum of meal price, tip percent, and tax percent.

    static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double totalCost = 0;

        double decimalTip = ((double)tip_percent / 100);
        double decimalTax = ((double)tax_percent / 100);

        double actualTip = (meal_cost * decimalTip);
        double actualTax = (meal_cost * decimalTax);

        totalCost = (meal_cost + actualTip + actualTax);

        Console.WriteLine("The total cost of the meal is {0}.", totalCost);

        int roundedTotal = Convert.ToInt32(totalCost);

        Console.WriteLine("The tip as decimal is {0} and the tax as decimal is {1}.", decimalTip, decimalTax);

        Console.WriteLine("The ROUNDED total cost of the meal is {0}.", roundedTotal);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("meal cost");
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("tip percent");
        int tip_percent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("tax percent");
        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}