using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Box
    {
        /*Hairtsag, mass ni 3
         Console deer 3 gej zuragdana*/
        int posBoxX, posBoxY;
        const int BOXMASS = 3;
        public Box(int x, int y)
        {
            this.posBoxX = x;
            this.posBoxY = y;
        }

        //box zurah
        public void DrawBox(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('3');
        }
    }
}
