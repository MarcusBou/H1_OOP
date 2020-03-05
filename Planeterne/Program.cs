using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<planet> planeter = new List<planet>();

            #region
            planeter.Add(new planet("Merkur", 0.330, 4879, 5427, 3.7 , 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false));
            planeter.Add(new planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false));
            planeter.Add(new planet("Jorden", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false));
            planeter.Add(new planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false));
            planeter.Add(new planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true));
            planeter.Add(new planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true));
            planeter.Add(new planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, false));
            planeter.Add(new planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true));
            planeter.Add(new planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false));
            #endregion

            foreach (var item in planeter)
            {
                Console.WriteLine($"Name: {item.PlanetName}\n Mass: {item.Mass}\n Density: {item.Density}\n Gravity: {item.Gravity}\n Rotation Period: {item.Rotation}\n Length of day: {item.DayLength}\n Distance from sun: {item.DistanceFromSun}\n Orbital Period: {item.OrbitalPeriod}\n Orbital Velocity: {item.OrbitalVelocity}\n Mean temperature: {item.MeanTemperature}\n Number of moons: {item.NumberMoon}\n Ring system? {item.Rings}\n\n");
            }

            Console.ReadKey();
        }
    }
}
