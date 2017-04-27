using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class BoxMan
    {
        /*Toglogchiin udirdah boxman
         Console deer 5 gej zuragdana*/
        const int LEFT = 1, UP = 2, RIGHT = 3, DOWN = 4;
        public static int BOXMAN = 5; //also 5 means in map BOXMAN
        int posBoxManX, posBoxManY;
        public BoxMan(int posX, int poxY)
        {
            this.posBoxManX = posX;
            this.posBoxManY = poxY;
        }

        //positioniih ni utgiig avna
        public int GetBoxManX()
        {
            return this.posBoxManX;
        }
        public int GetBoxManY()
        {
            return this.posBoxManY;
        }

        //BoxManii bairshiliig zugees ni hamaarch uurchilnu
        public void MoveBM(int direction)
        {
            switch (direction)
            {
                case LEFT:
                    this.posBoxManX--;
                    break;
                case UP:
                    this.posBoxManY--;
                    break;
                case RIGHT:
                    this.posBoxManX++;
                    break;
                case DOWN:
                    this.posBoxManY++;
                    break;
            }
        }
    }
}
