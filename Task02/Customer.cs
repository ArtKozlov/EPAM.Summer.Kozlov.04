using System;
using System.Text;

namespace Task02
{
    public class Customer
    {
        private string name;
        private decimal revenue;
        private string contactPhone; 
        public Customer(string name, decimal revenue, string contactPhone)
        {
            this.name = name;
            this.revenue = revenue;
            this.contactPhone = contactPhone;
        }

        public string Name
        {
            get { return name; }
        }

        public decimal Revenue
        {
            get { return revenue; }
        }

        public string ContactPhone
        {
            get { return contactPhone; }
        }

        public string ToString(string format)
        {
            if (format == null)
            {
                throw new ArgumentNullException();
            }
            string answer = "Customer record: ";
            switch (format)
            {
                case "Ph":
                    return answer + ContactPhone;
                case "R":
                    return answer + Revenue.ToString();
                case "N":
                    return answer + Name;
                case "NPhR":
                    return answer + Name + ", " + ContactPhone + ", " + Revenue.ToString();
                case "NPh":
                    return answer + Name + ", " + ContactPhone;
                case "NR":
                    return answer + Name + ", " + Revenue.ToString();
                case "PhR":
                    return answer + ContactPhone + ", " + Revenue.ToString();
                default:
                    throw new FormatException(String.Format("The '{0}' format string is not supported.", format));
            }
        }

    }
}
