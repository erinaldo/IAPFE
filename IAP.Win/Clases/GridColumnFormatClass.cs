using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.Win.Clases
{
    public class ColumnFormatRecord
    {
        private double fPayment;
        private long fLenght;
        private DateTime fPurchaseDate;
        private int fNumber;

        public ColumnFormatRecord(double fPayment, long fLenght, DateTime fPurchaseDate, int fNumber)
        {
            this.fPayment = fPayment;
            this.fLenght = fLenght;
            this.fPurchaseDate = fPurchaseDate;
            this.fNumber = fNumber;
        }

        public double Payment
        {
            get { return fPayment; }
            set { fPayment = value; }
        }

        public long Lenght
        {
            get { return fLenght; }
            set { fLenght = value; }
        }

        public DateTime PurchaseDate
        {
            get { return fPurchaseDate; }
            set { fPurchaseDate = value; }
        }

        public int Number
        {
            get { return fNumber; }
            set { fNumber = value; }
        }
    }
    public class BaseFormatter : IFormatProvider, ICustomFormatter
    {

        public object GetFormat(Type fFormat)
        {
            if (fFormat == typeof(ICustomFormatter)) return this;
            else return null;
        }

        public string Format(string fFormat, object arg, IFormatProvider provider)
        {
            if (fFormat == null)
            {
                if (arg is IFormattable)
                    return ((IFormattable)arg).ToString(fFormat, provider);
                else
                    return arg.ToString();
            }


            if (!fFormat.StartsWith("B"))
            {
                if (arg is IFormattable)
                    return ((IFormattable)arg).ToString(fFormat, provider);
                else
                    return arg.ToString();
            }

            fFormat = fFormat.Trim(new char[] { 'B' });
            int b = Convert.ToInt32(fFormat);
            return Convert.ToString((int)arg, b);
        }
    }
}
