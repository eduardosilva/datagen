using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    internal static class Name
    {
        #region First and Last names

        internal static string[] firstNames = { "Alessandro",
  "Alessandra",
  "Alexandre",
  "Aline",
  "Antônio",
  "Breno",
  "Bruna",
  "Carlos",
  "Carla",
  "Célia",
  "Cecília",
  "César",
  "Danilo",
  "Dalila",
  "Deneval",
  "Eduardo",
  "Eduarda",
  "Esther",
  "Elísio",
  "Fábio",
  "Fabrício",
  "Fabrícia",
  "Félix",
  "Felícia",
  "Feliciano",
  "Frederico",
  "Fabiano",
  "Gustavo",
  "Guilherme",
  "Gúbio",
  "Heitor",
  "Hélio",
  "Hugo",
  "Isabel",
  "Isabela",
  "Ígor",
  "João",
  "Joana",
  "Júlio César",
  "Júlio",
  "Júlia",
  "Janaína",
  "Karla",
  "Kléber",
  "Lucas",
  "Lorena",
  "Lorraine",
  "Larissa",
  "Ladislau",
  "Marcos",
  "Meire",
  "Marcelo",
  "Marcela",
  "Margarida",
  "Mércia",
  "Márcia",
  "Marli",
  "Morgana",
  "Maria",
  "Norberto",
  "Natália",
  "Nataniel",
  "Núbia",
  "Ofélia",
  "Paulo",
  "Paula",
  "Pablo",
  "Pedro",
  "Raul",
  "Rafael",
  "Rafaela",
  "Ricardo",
  "Roberto",
  "Roberta",
  "Sílvia",
  "Sílvia",
  "Silas",
  "Suélen",
  "Sara",
  "Salvador",
  "Sirineu",
  "Talita",
  "Tertuliano",
  "Vicente",
  "Víctor",
  "Vitória",
  "Yango",
  "Yago",
  "Yuri",
  "Washington",
  "Warley" };

        internal static string[] lastNames = new string[] { "Silva",
  "Souza",
  "Carvalho",
  "Santos",
  "Reis",
  "Xavier",
  "Franco",
  "Braga",
  "Macedo",
  "Batista",
  "Barros",
  "Moraes",
  "Costa",
  "Pereira",
  "Carvalho",
  "Melo",
  "Saraiva",
  "Nogueira",
  "Oliveira",
  "Martins",
  "Moreira",
  "Albuquerque"};

        #endregion

        internal static string[] companySuffix = new string[] { "S.A.", "LTDA", "e Associados", "Comércio" };

        internal static string GetLastName()
        {
            var result = lastNames.GetElementRandom();
            return result;
        }

        internal static string GetFirstName()
        {
            var result = firstNames.GetElementRandom();
            return result;
        }
    }
}
