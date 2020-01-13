using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathAlgorithms
{
    class DFS
    {
        int[] d1 = new int[] { 1, 1, 1, -1, -1, -1, 0, 0 };  // X movements
        int[] d2 = new int[] { 1, -1, 0, 0, -1, 1, 1, -1 };  // Y movements
        public DFS(int start_x, int start_y, int end_x, int end_y, int height_, int width_, List<int> wallx, List<int> wally)
        {
            startX = start_x;
            startY = start_y;
            endX = end_x;
            endY = end_y;
            height = height_;
            width = width_;
            wallX = wallx;
            wallY = wally;

            initialize();
        }


        #region attributes
        int startX, startY;
        int endX, endY;
        static int height, width; // dimensions

        List<int> wallX = new List<int>(); //walls
        List<int> wallY = new List<int>();

        int[,] table = new int[50, 50]; // table
        List<Tuple<int, int>> toReturn = new List<Tuple<int, int>>();

        #endregion


        
        void initialize()
        {
            for (int i = 0; i <= width; i++)
            {
                for (int j = 0; j <= height; j++)
                {
                    table[i, j] = 0;// all cells to 0
                }
            }
             
            for (int i = 0; i < wallX.Count; i++)
            {
                table[wallX[i], wallY[i]] = 1;  // build the wall
            }

        }

       
        public void performDFS(Tuple<int,int,int> currentCell)
        {
            int currX, currY;

            Tuple<int, int> toAppend = Tuple.Create(currentCell.Item1, currentCell.Item2);
            currX = toAppend.Item1;
            currY = toAppend.Item2;
            if (currX< 0 || currY < 0 || currX >= width || currY >= height || table[currX,currY]==1) // check if cell available
                return; // if not then stop

            // otherwise continue...

            table[currX, currY] = 1; // mark as visited
            toReturn.Add(toAppend);
            if (currX == endX && currY == endY)
            {
                MessageBox.Show(currentCell.Item3.ToString() + " steps"); // number of steps
                return;
            }

            for(int i = 0; i < 8; i++)  // explore the neighbour cells
            {
                int nextX = currX + d1[i];
                int nextY = currY + d2[i];

                performDFS(Tuple.Create(nextX, nextY, currentCell.Item3 + 1)); // go to cell
            }
                 
        }

        public List<Tuple<int,int>> get_DFS_path()
        {
            performDFS(Tuple.Create(startX, startY, 0));
            return toReturn;
        }
    }

}
