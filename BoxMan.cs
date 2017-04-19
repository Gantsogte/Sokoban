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
        Point positionBM;
        public BoxMan(Point position)
        {
            this.positionBM = position;
        }
        public void MoveBM(int direction)
        {
            switch (direction)
            {
                case LEFT:
                    //todo
                    break;
                case UP:
                    //todo
                    break;
                case RIGHT:
                    //todo
                    break;
                case DOWN:
                    //todo
                    break;
            }
        }
        public void DrawBM(Point pos, Point lastPos)
        {
            /*Shine position deer 5 zurangaa umnuh position deer hooson zai zurah buyu arilgana*/
            Console.SetCursorPosition(lastPos.getPointX, lastPos.getPointY);
            Console.Write(' ');
            Console.SetCursorPosition(pos.GetPointX, pos.GetPointY);
            Console.Write('5');
        }
    }
}
