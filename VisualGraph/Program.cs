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
            List<object> dataActual = new List<object>(new object[] { 248556, 7655423, 54232465 });
            List<object> dataGoal = new List<object>(new object[] { 4442305, 4433425, 64423465 });
            List<object> tempList = new List<object>();
            tempList = dataGoal.Concat(dataActual).ToList();

            string tempCurrency = String.Empty;
            tempCurrency = Currency.GetCurrency(tempList);
            tempList = Currency.ConvertData(tempCurrency, tempList);
            if (!string.IsNullOrEmpty(tempCurrency))
            {
                Console.WriteLine(tempCurrency);
            }
            foreach (object item in tempList)
            {
                double temp = (double)item;
                Console.WriteLine(string.Format("{0:0.00}", temp) + tempCurrency);
            }
        }
    }
}
