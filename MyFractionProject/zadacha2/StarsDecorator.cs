using System;
using System.Globalization;
using System.Text;

namespace zadacha2{
    public class StarsDecorator : DateDecorator
{
    public StarsDecorator(IDatePrinter datePrinter) : base(datePrinter) { }

    public override string Print()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("*** ");
        sb.Append(_datePrinter.Print());
        sb.Append(" ***");
        return sb.ToString();
    }
}
}
