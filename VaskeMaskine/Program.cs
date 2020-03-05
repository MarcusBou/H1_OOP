using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskeMaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klik enter for at tænde for vaskemaskinen");
            Console.ReadKey();
            vaskeProgram vaskTænd = new vaskeProgram(true);

            vaskeMaskineInterface.vaskeMaskinen();
            Console.ReadKey();
        }
    }
}
