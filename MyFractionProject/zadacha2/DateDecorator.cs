using System;
using System.Globalization;
using System.Text;
namespace zadacha2{
    public abstract class DateDecorator : IDatePrinter
{
    protected IDatePrinter _datePrinter;

    public DateDecorator(IDatePrinter datePrinter)
    {
        _datePrinter = datePrinter;
    }

    public abstract string Print();
}
}
