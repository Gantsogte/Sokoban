using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Level
    {
        public static int[,] map = new int[8, 8];
        public Level()
        {
            LevelOne();
        }

        //level 1-iin baiguulagch
        private void LevelOne()
        {
            int i;
            for(i=0; i<8; i++)
            {
                if (i == 1) { map[i, 1] = 9; map[i, 2] = 9; map[i, 3] = 9; map[i, 4] = 1; map[i, 5] = 9; map[i, 6] = 9; }
                if (i == 2) { map[i, 1] = 9; map[i, 2] = 9; map[i, 3] = 9; map[i, 4] = 0; map[i, 5] = 9; map[i, 6] = 9; }
                if (i == 3) { map[i, 1] = 1; map[i, 2] = 0; map[i, 3] = 3; map[i, 4] = 3; map[i, 5] = 9; map[i, 6] = 9; }
                if (i == 4) { map[i, 1] = 9; map[i, 2] = 9; map[i, 3] = 5; map[i, 4] = 3; map[i, 5] = 0; map[i, 6] = 1; }
                if (i == 5) { map[i, 1] = 9; map[i, 2] = 9; map[i, 3] = 3; map[i, 4] = 9; map[i, 5] = 9; map[i, 6] = 9; }
                if (i == 6) { map[i, 1] = 9; map[i, 2] = 9; map[i, 3] = 1; map[i, 4] = 9; map[i, 5] = 9; map[i, 6] = 9; }
                map[0, i] = 9;
                map[i, 0] = 9;
                map[7, i] = 9;
                map[i, 7] = 9;
            }
            //Console.WriteLine("Map Loaded\n");
            //throw new NotImplementedException();
        }

        //mapiing neg nudiing utga avah
        public int GetMaps(int x, int y)
        {
            return this.map[x,y];
        }

        //map zurah
        public void DrawMap()
        {
            int i, j;
            for(i=0; i<8; i++)
            {
                for(j=7; j>=0; j--)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(map[i, j]);
                }
            }
        }
    }
    
}
