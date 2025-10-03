using System.Globalization;

namespace Course1.Entities
{
    internal class Invoice
    {
        public double BasicPaiment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPaiment, double tax)
        {
            BasicPaiment = basicPaiment;
            Tax = tax;
        }
        public double TotalPayment{ 
            get { return BasicPaiment + Tax; }
        }
        public override string ToString()
        {
            return "Basic payment: "
                + BasicPaiment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
