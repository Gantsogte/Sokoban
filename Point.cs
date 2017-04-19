using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Point
    {
        /*x y Coordinattai neg tseg, class geheesee iluu ugugldiin butets bolj hereglegdene*/
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetPointX()
        {
            int x;
            x = this.x;
            return x;
        }
        public int GetPointY()
        {
            int y;
            y = this.y;
            return y;
        }
    }
}
