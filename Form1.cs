﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            prepareBoard();
        }

        int startX=2, startY=2, endX=16, endY=16;

        void prompt_user()
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        void prepareBoard()
        {
            board.BackgroundColor = Color.Black;
            board.DefaultCellStyle.BackColor = Color.Black;

            for(int i = 0; i < 19; i++)
            {
                board.Rows.Add();
            }
            
            foreach(DataGridViewTextBoxColumn c in board.Columns)
            {
                c.Width = board.Width / board.Columns.Count;
            }

            foreach(DataGridViewRow r in board.Rows)
            {
                r.Height = board.Height / board.Rows.Count;
            }
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }


        Tuple<List<int>,List<int>> BuildWalls()
        {

            int height_SZ = board.Rows.Count;
            int width_SZ = board.Columns.Count;
            List<int> xWalls = new List<int>();
            List<int> yWalls = new List<int>();
            
            for (int i = 0; i < width_SZ; i++)
            {
                for (int j = 0; j < height_SZ; j++)
                {
                    if (board[i, j].Style.BackColor == Color.Red)
                    {
                        xWalls.Add(i);
                        yWalls.Add(j);
                    }

                    if (board[i, j].Selected)
                    {
                        board[i, j].Selected = false;
                    }
                }
            }
            return Tuple.Create(xWalls, yWalls);
        }

        

        void ColorTheBoard(List<Tuple<int, int>> path, bool clr)
        {
            var toColor = Color.Yellow;
            var color2 = Color.Green;
           /* If clr is true it means we are coloring the shortest path ( in case of BFS ) */
            if (clr == true) toColor = color2;
            int iterator = 0;
            foreach (Tuple<int, int> x in path)
            {
                wait(70);
                int xx = x.Item1;
                int yy = x.Item2;
                if (clr == true)
                {
                    board[xx, yy].Value = iterator; //If shortest path then mark current steps
                }

                if (xx == endX && yy == endY)
                {
                    board[xx, yy].Style.BackColor = toColor;
                    board[xx, yy].Value = "ok!";
                    break;
                }
                else board[xx, yy].Style.BackColor = toColor;

                iterator++;
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            int height_SZ = board.Rows.Count;
            int width_SZ = board.Columns.Count;
            

            for (int i = 0; i < width_SZ; i++)
            {
                for (int j = 0; j < height_SZ; j++)
                {
                    if (board[i, j].Selected) {
                        board[i, j].Selected = false;
                        board[i, j].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void RunBFS_Click(object sender, EventArgs e)
        {
            List<int> xWalls = new List<int>();
            List<int> yWalls = new List<int>();

            Tuple<List<int>, List<int>> walls = BuildWalls();  // calls the BuildWalls method

            xWalls = walls.Item1;
            yWalls = walls.Item2;
                       // BFS(startX,startY,ebdX,endY, row,col, (position of walls ))
            BFS bfs = new BFS(startX, startY, endX, endY, 19, 20, xWalls, yWalls); // create BFS object
            Tuple<List<Tuple<int, int>>, List<Tuple<int, int>>> paths = bfs.get_BFS_path(); // run BFS and get the paths (traversal and shortest)
            List<Tuple<int, int>> path = paths.Item1;
            List<Tuple<int, int>> shortestPath = paths.Item2;
            //MessageBox.Show(path.Count.ToString());

            ColorTheBoard(path, false); // colors the board

            if (shortestPath.Count() == 0) { MessageBox.Show("No path for the selected cells..."); }
            else
            {
                MessageBox.Show("Now showing the shortest path...");
                ColorTheBoard(shortestPath, true);
            }

        }

        private void RunDFS_Click(object sender, EventArgs e)
        {

            List<int> xWalls = new List<int>();
            List<int> yWalls = new List<int>();

            Tuple<List<int>, List<int>> walls = BuildWalls();  // calls the BuildWalls method
            
            xWalls = walls.Item1;
            yWalls = walls.Item2;
                            // (sX,Sy,eX,eY, row,col)
            DFS dfs = new DFS(startX, startY, endX, endY, 19, 20, xWalls, yWalls); // create DFS object

            List<Tuple<int, int>> path = dfs.get_DFS_path();  // run DFS get the cells traversed in BFS order
            
            ColorTheBoard(path,false); // colors the board
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            int height_SZ = board.Rows.Count;
            int width_SZ = board.Columns.Count;

            for (int i = 0; i < width_SZ; i++)
            {
                for (int j = 0; j < height_SZ; j++)
                {
                    board[i, j].Style.BackColor = Color.Black;
                    board[i, j].Value = "";
                }
            }
        }
    }
}
