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
         Console deer flagiig 1 eer zurna*/
        int posFlagX, posFlagY;
        const int FLAGVALUE = 1;
        public Flag(int x, int y)
        {
            this.posFlagX = x;
            this.posFlagY = y;
        }

        //flag zurah
        public void DrawFlag(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('1');
        }
    }
}
