using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Level
    {
        public static int HEIGHT = 8, WIDTH = 8;
        public const int WALL = 9, EMPTY = 0;
        public int[,] map = new int[HEIGHT, WIDTH];
        public Level()
        {
            LevelOne();
        }

        //level 1-iin map-d utga olgoh
        private void LevelOne()
        {
            int column;
            for(column=0; column<HEIGHT; column++)
            {
                //gadna hureend utga uguh
                map[0, column] = WALL;
                map[column, 0] = WALL;
                map[7, column] = WALL;
                map[column, 7] = WALL;
                //Dotorh utguudiig uguh
                if (column == 1) { map[column, 1] = WALL;      map[column, 2] = WALL;  map[column, 3] = WALL;          map[column, 4] = Flag.FLAG; map[column, 5] = WALL;  map[column, 6] = WALL; }
                if (column == 2) { map[column, 1] = WALL;      map[column, 2] = WALL;  map[column, 3] = WALL;          map[column, 4] = EMPTY;     map[column, 5] = WALL;  map[column, 6] = WALL; }
                if (column == 3) { map[column, 1] = Flag.FLAG; map[column, 2] = EMPTY; map[column, 3] = Box.BOX;       map[column, 4] = Box.BOX;   map[column, 5] = WALL;  map[column, 6] = WALL; }
                if (column == 4) { map[column, 1] = WALL;      map[column, 2] = WALL;  map[column, 3] = BoxMan.BOXMAN; map[column, 4] = Box.BOX;   map[column, 5] = EMPTY; map[column, 6] = Flag.FLAG; }
                if (column == 5) { map[column, 1] = WALL;      map[column, 2] = WALL;  map[column, 3] = Box.BOX;       map[column, 4] = WALL;      map[column, 5] = WALL;  map[column, 6] = WALL; }
                if (column == 6) { map[column, 1] = WALL;      map[column, 2] = WALL;  map[column, 3] = Flag.FLAG;     map[column, 4] = WALL;      map[column, 5] = WALL;  map[column, 6] = WALL; }
            }
        }

        //mapiing neg nudiing utga avah
        public int GetMapNodeValue(int posX, int poxY)
        {
            return this.map[posX, poxY];
        }
    }
}
