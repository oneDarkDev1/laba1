using System;
using System.Globalization;
using System.Text;
namespace zadacha2{
    public class AmericanDatePrinter : IDatePrinter{
        public string Print()
        {
            return DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt", CultureInfo.GetCultureInfo("en-US"));
        }
    }
}
