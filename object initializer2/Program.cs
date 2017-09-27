using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_initializer2
{
    public class Customer
    {
        private int _customerID;
        private string _companyName;
        private Phone _phone;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public Phone Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }

    public class Phone
    {
        private string _countryCode;
        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }
        private string _areacode;
        public string AreaCode
        {
            get { return _areacode; }
            set { _areacode = value; }
        }
        private string _phonenumber;
        public string Phonenumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }


        static void Main(string[] args)
        {
            Customer nCustomer = new Customer()
            {
                CustomerID = 102,
                CompanyName = "nTest Corporation"
            };

                Phone p = new Phone()
                {
                    CountryCode = "+91",
                    AreaCode = "216358",
                    Phonenumber = "9997117983"
                
               
            };
            Console.WriteLine($" CustomerID: {nCustomer.CustomerID}");
            Console.WriteLine($" CompanyName: {nCustomer.CompanyName}");
            Console.WriteLine($" CompanyName: {p.CountryCode}");
            Console.WriteLine($" CompanyName: {p.AreaCode}");
            Console.WriteLine($" CompanyName: {p.Phonenumber}");

            Console.ReadLine();
        }
    }

}
