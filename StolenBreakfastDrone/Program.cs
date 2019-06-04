using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StolenBreakfastDrone
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class DroneManager
    {
        public static int FindUniqueDeliveryId(int[] deliveryIds)
        {
#if MINE

            Dictionary<int, int> suspects = new Dictionary<int, int>();
            // Find the one unique ID in the array
            // Iterate the deliveryIds, creating a dictionary.  Find the id(s) in dictionary with < 2 mentions.
            foreach (int id in deliveryIds)
            {
                if (suspects.Keys.Contains(id))
                {
                    suspects[id]++;
                }
                else
                {
                    suspects.Add(id, 1);
                }
            }

            // var one = suspects.Where((LessThanTwoMentions)).ToList() ;
            var one = suspects.Where(pair => pair.Value < 2).ToList();

            if (one.Any( ))
            {
                return one.First().Key;
            }

            return 0;
#else
            //
            // This is the solution from IC.
            //
            int uniqueDeliveryId = 0;

            foreach (int deliveryId in deliveryIds)
            {
                uniqueDeliveryId ^= deliveryId;
            }

            return uniqueDeliveryId;
#endif
        }

        private static bool LessThanTwoMentions(KeyValuePair<int, int> arg)
        {
            if (arg.Value < 2)
            {
                return true;
            }

            return false;
        }
    }
}
