using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public static class CurrentExtensions
    {
        static int seed = Environment.TickCount;
        private static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));
        private static IEnumerable<int> rangeToBoolean = Enumerable.Range(0, 100);

        public static T GetElementRandom<T>(this IEnumerable<T> source)
        {
            var result = source.ElementAt(random.Value.Next(0, source.Count()));

            return result;
        }

        public static bool GetRandomBool(this Random source)
        {
            return rangeToBoolean.GetElementRandom() % 2 == 0;
        }

        public static decimal NextDecimal(this Random random)
        {
            byte scale = (byte)random.Next(29);
            bool sign = random.Next(2) == 1;
            return new decimal(random.Next(),
                               random.Next(),
                               random.Next(),
                               sign,
                               scale);
        }

        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunksize)
        {
            while (source.Any())
            {
                yield return source.Take(chunksize); source = source.Skip(chunksize);
            }
        }

    }
}
