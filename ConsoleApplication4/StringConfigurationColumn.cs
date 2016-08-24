using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class StringConfigurationColumn : ConfigurationColumn<string>
    {
        public int MinLength { get; set; }
        public StringType SType { get; set; }

        public enum StringType
        {
            Name,
            Address,
            Company,
            Product,
            Department
        }

        protected override object GenerateTypedValue()
        {
            if (SType == StringType.Name)
                return GenerateName();

            if (SType == StringType.Company)
                return GenerateCompanyName();

            if (SType == StringType.Address)
                return GenerateAddress();

            if (SType == StringType.Product)
                return GenerateProductName();

            return GenerateDepartment();
        }

        private object GenerateDepartment()
        {
            var result = String.Format("{0}", Commerce.GetDepartmentName());
            return result;
        }

        private object GenerateProductName()
        {
            var result = String.Format("{0}", Commerce.GetProductName());
            return result;
        }

        private static object GenerateCompanyName()
        {
            var companyName = Name.GetLastName();
            var companySuffix = Name.companySuffix.GetElementRandom();

            var result = String.Format("{0} {1}", companyName, companySuffix);
            return result;
        }

        private static object GenerateName()
        {
            var firstName = Name.GetFirstName();
            var lastName = Name.GetLastName();

            var result = String.Format("{0} {1}", firstName, lastName);
            return result;
        }

        private static object GenerateAddress()
        {
            var result = String.Format("{0}", Address.FullAddress());
            return result;
        }
    }
}
