using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Flag
    {
        /*Hairtsagiig avaachih etssiin bairshil
         Console deer flagiig -1 eer zurna*/
        Point positionFlag;
        const int FLAGVALUE = -1;
        public Flag(Point position)
        {
            this.positionFlag = position;
        }
        public void DrawFlag(Point position)
        {
            Console.SetCursorPosition(position.GetPointX, position.GetPointY);
            Console.Write('1');
        }
    }
}
