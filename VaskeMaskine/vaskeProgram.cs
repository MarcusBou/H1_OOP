using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskeMaskine
{
    class vaskeProgram
    {
        //Booleans
        private bool tændSluk, sæbe, door = false;
        public bool Sæbe{set { sæbe = value; } get{ return sæbe; } }
        public bool Door {set { door = value; } get { return door; } }

        //ints
        private int valg;
        public int Valg { set { this.valg = value; } get{ return this.valg; } }

        //strings
        private string program;
        public string Program {set { program = value; }get { return program; } }

        public vaskeProgram()
        {

        }

        public vaskeProgram(bool Tænd)
        {
            this.tændSluk = Tænd;
        }
        
       
    }
}
