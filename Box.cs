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
        const int LEFT = 1, UP = 2, RIGHT = 3, DOWN = 4;
        public static int BOX = 3;// 3 is mass of box also means BOX
        //baiguulagch
        public Box(int x, int y)
        {
            this.posBoxX = x;
            this.posBoxY = y;
        }
        // x, y positionii utgiig uguh
        public void SetBoxPos(int x, int y)
        {
            this.posBoxX = x;
            this.posBoxY = y;
        }
        // x positionii utgiig avah
        public int GetBoxPosX()
        {
            return this.posBoxX;
        }
        // y positionii utgiig avah
        public int GetBoxPosY()
        {
            return this.posBoxY;
        }

        public void MoveBox(int direction)
        {
            switch (direction)
            {
                case LEFT:
                    this.posBoxX--;
                    break;
                case UP:
                    this.posBoxY--;
                    break;
                case RIGHT:
                    this.posBoxX++;
                    break;
                case DOWN:
                    this.posBoxY++;
                    break;
            }
        }
    }
}
