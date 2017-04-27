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
        public static int FLAG = 1;// 1 is value of flag also means FLAG
        public Flag(int x, int y)
        {
            this.posFlagX = x;
            this.posFlagY = y;
        }
        // x, y positionii utgiig uguh
        public void SetFlagPos(int x, int y)
        {
            this.posFlagX = x;
            this.posFlagY = y;
        }
        // x positionii utgiig avah
        public int GetFlagPosX()
        {
            return this.posFlagX;
        }
        // y positionii utgiig avah
        public int GetFlagPosY()
        {
            return this.posFlagY;
        }
    }
}

