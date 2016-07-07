using System;
using System.Text;

namespace Task02
{
    public class Customer
    {
        private string name;
        private decimal revenue;
        private string contactPhone;
        /// <summary>
        /// This object have name, revenue, phone and used to provide this information.
        /// </summary>
        /// <param name="name">name of customer</param>
        /// <param name="revenue">revenue of customer</param>
        /// <param name="contactPhone">Phone of customer</param>
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
        /// <summary>
        /// The method converts the string value to information on the subject in the right format.
        /// </summary>
        /// <param name="format">formatting type</param>
        /// <returns>Information about the object in the right format</returns>
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
