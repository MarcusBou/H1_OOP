using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Kodenering
    {
        private int choose;
        public int Choose { set { choose = value; } get { return choose; } }

        public Kodenering(int Choose)
        {
            this.choose = Choose;
            switch (choose)
            {
                case '1':
                    GUI.addItem();
                    break;
                case '2':
                    GUI.deleteItem();
                    break;
                case '3':
                    GUI.numberItems();
                    break;
                case '4':
                    GUI.showMinMax();
                    break;
                case '5':
                    GUI.findItem();
                    break;
                case '6':
                    GUI.printItems();
                    break;
                default:
                    GUI.mainMenu();
                    break;
            }
        }
        
    }
}
