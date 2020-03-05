using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class planet
    {
        private string planetName;
        private double mass, diameter, density, gravity, rotation, dayLength, distanceFromSun, orbitalPeriod, orbitalVelocity, meanTemperature, numberMoon = 0;
        private bool rings = false;

        #region
        public string PlanetName {set { planetName = value; } get { return planetName; } }
        public double Mass { set { mass = value; } get { return mass; } }
        public double Diameter { set { diameter = value; } get { return diameter; } }
        public double Density { set { density = value; } get { return density; } }
        public double Gravity { set { gravity = value; } get { return gravity; } }
        public double Rotation { set { rotation = value; } get { return rotation; } }
        public double DayLength { set { dayLength = value; } get { return dayLength; } }
        public double DistanceFromSun { set { distanceFromSun = value; } get { return distanceFromSun; } }
        public double OrbitalPeriod { set { orbitalPeriod = value; } get { return orbitalPeriod; } }
        public double OrbitalVelocity { set { orbitalVelocity = value; } get { return orbitalVelocity; } }
        public double MeanTemperature { set { meanTemperature = value; } get { return meanTemperature; } }
        public double NumberMoon { set { numberMoon = value; } get { return numberMoon; } }
        public bool Rings { set { rings = value; } get { return rings; } }
        #endregion

        public planet(string planetName, double mass, double diameter, double density, double gravity, double rotation, double dayLength, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, double meanTemperature, double numberMoon, bool rings )
        {
            this.planetName = planetName;
            this.mass = mass;
            this.diameter = diameter;
            this.density = density;
            this.gravity = gravity;
            this.rotation = rotation;
            this.dayLength = dayLength;
            this.distanceFromSun = distanceFromSun;
            this.orbitalPeriod = orbitalPeriod;
            this.orbitalVelocity = orbitalVelocity;
            this.meanTemperature = meanTemperature;
            this.numberMoon = numberMoon;
            this.rings = rings;
        }
    }
}
