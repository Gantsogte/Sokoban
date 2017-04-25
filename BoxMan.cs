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
        const int POWER = 5;
        int posBM_X, posBM_Y;
        public BoxMan(int x, int y)
        {
            this.posBM_X = x;
            this.posBM_Y = y;
        }
        //BoxManii bairshiliig zugees ni hamaarch uurchilnu
        public void MoveBM(int direction)
        {
            switch (direction)
            {
                case LEFT:
                    this.posBM_X--;
                    break;
                case UP:
                    this.posBM_Y--;
                    break;
                case RIGHT:
                    this.posBM_X++;
                    break;
                case DOWN:
                    this.posBM_Y++;
                    break;
            }
        }
        //zurah 
        public void DrawBM(int x0, int y0, int x, int y)
        {
            /*Shine position deer 5 zurangaa umnuh position deer hooson zai zurah buyu arilgana*/
            Console.SetCursorPosition(x0, y0);
            Console.Write(' ');
            Console.SetCursorPosition(x, y);
            Console.Write('5');
        }
    }
}
