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
        Point positionBox;
        const int BOXMASS = 3;
        public Box(Point position)
        {
            this.positionBox = position;
        }
        public void DrawBox(Point position)
        {
            Console.SetCursorPosition(position.GetPointX, position.GetPointY);
            Console.Write('3');
        }
    }
}
