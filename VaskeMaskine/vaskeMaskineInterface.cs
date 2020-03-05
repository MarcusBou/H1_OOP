using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskeMaskine
{
    class vaskeMaskineInterface
    {
        public static void vaskeMaskinen()
        {
            vaskeProgram vaskTænd = new vaskeProgram(true);
            vaskeProgram program = new vaskeProgram();

            Console.Clear();
            Console.WriteLine("[---------------------------------------------------------------]");
            Console.WriteLine(" Power: on");
            Console.WriteLine("[---------------------------------------------------------------]");
            Console.WriteLine("Fill in soap: 1              |               Soap: " + program.Sæbe);
            Console.WriteLine("Åben døren: 2                |               Door open: " + program.Door);
            Console.WriteLine("Quick wash: 3                |               Program: ");
            Console.WriteLine("Wash: 4                      |                   ");
            Console.WriteLine("Eco Wash: 5                  |                   ");
            Console.WriteLine("Turn off: 6                  |                   ");
            Console.Write("Choose: ");
            program.Valg = Int32.Parse(Console.ReadLine());
        }

    }
}
