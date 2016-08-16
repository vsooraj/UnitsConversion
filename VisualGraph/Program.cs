using System;
using System.Collections.Generic;
using System.Linq;
using UnitsConversion;

namespace VisualGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> dataActual = new List<object>(new object[] { 2482000767, 343765, "5465465" });
            List<object> dataGoal = new List<object>(new object[] { 4482000767, 443765, "6465465" });
            List<object> tempList = new List<object>();
            tempList = dataGoal.Concat(dataActual).ToList();

            string tempCurrency = String.Empty;
            tempCurrency = Currency.GetCurrency(tempList);
            tempList = Currency.ConvertData(tempCurrency, tempList);
            Console.WriteLine(tempCurrency);
            foreach (object item in tempList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
