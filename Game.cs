using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Game
    {
        public static void Main(string[] args)
        {
            //LEFT = 1, UP = 2, RIGHT = 3, DOWN = 4;
            Level lvl = new Level();
            lvl.DrawMap();
            
            //negees olon flag, boxiin object uusgeh !!!!
            Flag[4] flag;
            Box[4] box;

            int i, j;
            //mapaa unshij objectuudaa baiguulna
            for(i=0; i<8; i++)
            {
                for(j=0; j<8; j++)
                {
                    int mapNodeValue = lvl.GetMaps(i, j);
                    if(mapNodeValue == 1)
                    {
                        Flag flag = new Flag(i, j);
                    }
                    if(mapNodeValue == 3)
                    {
                        Box box = new Box(i, j);
                    }
                    if(mapNodeValue == 5)
                    {
                        BoxMan boxMan = new BoxMan(i, j);
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
