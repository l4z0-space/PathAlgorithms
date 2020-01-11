﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathAlgorithms
{
    
    
    class BFS
    {

        int[] d1 = new int[] { 1, 1, 1, -1, -1, -1, 0, 0 };  // movements
        int[] d2 = new int[] { 1, -1, 0, 0, -1, 1, 1, -1 };
        public BFS(int start_x, int start_y, int end_x, int end_y, int height_, int width_, List<int> wallx, List<int> wally)
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


        #region methods
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

        public List<Tuple<int,int>> get_BFS_path()
        {
           
            var queue = new Queue<Tuple<int, int, int>>(); // generic queue declaration
          
            queue.Enqueue(Tuple.Create(startX, startY, 0));  // insert the starting point

            while (queue.Count != 0)  // while still elements in queue
            {
                var curr = queue.Dequeue(); // get the next element and pop it out the queue
           
                toReturn.Add(Tuple.Create(curr.Item1, curr.Item2));

                if (curr.Item1 == endX && curr.Item2 == endY) // if the target found break
                {
                    MessageBox.Show(curr.Item3.ToString()+" steps");
                    break;
                }

                for (int i = 0; i < 8; i++)  // for each neighbour
                {
                    // update the coordinates
                    int nextX = curr.Item1 + d1[i];
                    int nextY = curr.Item2 + d2[i];

                    // check if inside the bounds
                    if (nextX >= 0 && nextY >= 0 && nextX < width && nextY < height)
                    {
                        // check if visited before
                        if (table[nextX, nextY] == 0)
                        {
                            table[nextX, nextY] = 1;
                         //   Visited[Tuple.Create(nextX, nextY)] = true; // mark as visited
                            queue.Enqueue(Tuple.Create(nextX, nextY, curr.Item3+1));  // insert into queue
                            toReturn.Add(Tuple.Create(nextX, nextY));
                            
                        }
                    }
                }
            }
            #endregion


            return toReturn;
        }


    }
}