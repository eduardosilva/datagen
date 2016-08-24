using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    internal static class Address
    {
        internal static string[] streetSuffix = new string[] { "Rua", "Avenida", "Travessa", "Ponte", "Alameda", "Marginal", "Viela", "Rodovia" };
        internal static string[] cityPrefix = new string[] { "Nova", "Velha", "Grande", "Vila", "Município de" };
        internal static string[] citySuffix = new string[] { "do Descoberto", "de Nossa Senhora", "do Norte", "do Sul" };
        internal static string[] states = new string[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" };

        public static string StreetName()
        {
            var suffix = streetSuffix.GetElementRandom();
            var name = Enumerable.Range(0, 100).GetElementRandom() % 2 == 0 ? Name.GetLastName() : Name.GetFirstName();

            var streeFomat = "{0} {1}";
            var result = String.Format(streeFomat, name, suffix);
            return result;
        }

        public static string CityName()
        {
            Func<string> f1 = () =>
            {
                var prefix = cityPrefix.GetElementRandom();
                var name = Name.GetFirstName();
                var suffix = citySuffix.GetElementRandom();
                return String.Format("{0} {1} {2}", prefix, name, suffix);
            };

            Func<string> f2 = () =>
            {
                var prefix = cityPrefix.GetElementRandom();
                var name = Name.GetFirstName();
                return String.Format("{0} {1}", prefix, name);
            };

            Func<string> f3 = () =>
            {
                var suffix = citySuffix.GetElementRandom();
                var name = Name.GetFirstName();
                return String.Format("{0} {1}", name, suffix);
            };

            Func<string> f4 = () =>
            {
                var suffix = citySuffix.GetElementRandom();
                var name = Name.GetLastName();
                return String.Format("{0} {1}", name, suffix);
            };

            var formats = new[] { f1, f2, f3, f4 };
            var format = formats.GetElementRandom();

            return format();
        }

        public static string StateName()
        {
            return states.GetElementRandom();
        }

        public static string FullAddress()
        {
            var street = StreetName();
            var number = Enumerable.Range(1, 999).GetElementRandom();
            var city = CityName();
            var state = StateName();

            var fullAddressFormat = "{0} {1} {2}";

            return String.Format(fullAddressFormat, street, number, city);
        }
    }
}
