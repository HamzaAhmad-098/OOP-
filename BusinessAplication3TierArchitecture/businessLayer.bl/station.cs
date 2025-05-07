using BusinessAplication3TierArchitecture.dataLayer.dl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAplication3TierArchitecture.businessLayer.bl
{
    internal class station
    {
        public void ViewStations()
        {
            stations.Clear();
            Console.Clear();
            Console.WriteLine("List of Orange Line Stations in Lahore:");
            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {stations[i]}");
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
