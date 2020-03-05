using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class GUI
    {
        public static void mainMenu()
        {
            Kodenering Coordinator = new Kodenering(0);

            Console.WriteLine("===========================================================\n");
            Console.WriteLine("                     H1 Queue Operation\n");
            Console.WriteLine("===========================================================\n\n");
            Console.WriteLine("1. Add items\n");
            Console.WriteLine("2. Delete items\n");
            Console.WriteLine("3. Show the number of items\n");
            Console.WriteLine("4. Show min and max items\n");
            Console.WriteLine("5. Find an item\n");
            Console.WriteLine("6. Print all items\n\n");
            Console.Write("Choose: ");
            Coordinator.Choose = Int32.Parse(Console.ReadLine());
            Console.Clear();
        }

        public static void addItem()
        {

        }

        public static void deleteItem()
        {

        }

        public static void numberItems()
        {

        }

        public static void showMinMax()
        {

        }

        public static void findItem()
        {

        }

        public static void printItems() 
        {
            Console.Clear();
        }

    }
}
