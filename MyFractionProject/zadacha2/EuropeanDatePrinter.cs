using System;
using System.Globalization;
using System.Text;

namespace zadacha2{
    public class EuropeanDatePrinter : IDatePrinter
{
    public string Print()
    {
        return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.GetCultureInfo("fr-FR"));
    }
}
}
