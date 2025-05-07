using BusinessAplication3TierArchitecture.businessLayer.bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAplication3TierArchitecture.dataLayer.dl
{
    internal class station
    {
        public static List<string> stations = new List<string> { };
        public bool AddStation(string newStation)
        {
            stations.Add(newStation);
            return true;
        }

        public bool DeleteStation(string stationToRemove)
        {
            if (stations.Contains(stationToRemove))
            {
                stations.Remove(stationToRemove);
                return true;
            }
            return false;
        }


    }
}
