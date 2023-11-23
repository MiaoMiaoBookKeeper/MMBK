using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBK.Service
{
    public class HR
    {
        /*
   * Complete the 'mostActive' function below.
   *
   * The function is expected to return a STRING_ARRAY.
   * The function accepts STRING_ARRAY customers as parameter.
   */

        public static List<string> mostActive(List<string> customers)
        {
            // find customer count >= 5% of total
            Dictionary<string, int> result = new();
            foreach (var c in customers)
            {
                if (result.TryGetValue(c, out int value))
                {
                    result[c]++;

                }
                else
                {
                    result.Add(c, 0);
                }

            }
            // order ASC

            decimal limit = customers.Count() * 0.05m;

            List<string> output = new();
            foreach (var kvp in result)
            {
                if (kvp.Value >= limit)
                {
                    output.Add(kvp.Key);
                }
            }

             output.Sort();
            return output;

        }

    }

}
