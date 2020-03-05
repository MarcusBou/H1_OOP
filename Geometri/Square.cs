using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Square
    {
        private double length, height;
        
        public double Length { set { length = value; } get { return length; } }
        public double Height { set{ height = value; } get { return height; } }
        
        public Square()
        {

        }

        public Square(double Site)
        {
            this.length = Site;
            this.height = Site;
        }

        public double ArealKvadrat()
        {
            return this.length * this.length;
        }

        public double omkreds()
        {
            return 4 * this.length;
        }
    }
}
