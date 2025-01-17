﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PathAlgorithms
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            runDFS.Enabled = false;
            runBFS.Enabled = false;
            runAstar.Enabled = false;
            select.Enabled = false;
            prepareBoard();

            
        }

        int startX, startY, endX, endY;

        void disableButtons()
        {
            runBFS.Enabled = false;
            runDFS.Enabled = false;
            runAstar.Enabled = false;
            select.Enabled = false;
            clear.Enabled = false;
            button1.Enabled = false;
        }

        void enableButtons()
        {
            runBFS.Enabled = true;
            runDFS.Enabled = true;
            runAstar.Enabled = true;
            select.Enabled = true;
            clear.Enabled = true;
            button1.Enabled = true;
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
            disableButtons();
            var toColor = Color.Orange;
            var color2 = Color.Green;
           /* If clr is true it means we are coloring the shortest path ( in case of BFS ) */
            if (clr == true) toColor = color2;
            int iterator = 0;

            for (int currIT= 0; currIT < path.Count;currIT++ )
            {
                Tuple<int, int> x = path[currIT];
                wait(70);
                int xx = x.Item1;
                int yy = x.Item2;
                if (clr == true)
                {
                    
                    board[xx, yy].Value = iterator; //If shortest path then mark current steps
                    board[xx, yy].Style.BackColor = toColor;
                }

                if (xx == endX && yy == endY)
                {
                    board[xx, yy].Style.BackColor = toColor;
                    board[xx, yy].Value = "ok!";
                    break;
                }
                else
                {
                    
                    if (currIT > 0 ) // color previous (not yellow)
                    {
                        Tuple<int, int> prevX = path[currIT - 1];
                        board[prevX.Item1, prevX.Item2].Style.BackColor = toColor;
                    }
                    if(board[xx, yy].Style.BackColor != toColor && clr==false) // if not colored then color it yellow (current)
                    {
                        board[xx, yy].Style.BackColor = Color.Yellow;
                        //board[xx, yy].Value = iterator;
                    }
                    
                }
                iterator++;
            }
            clear.Enabled = true;
            button1.Enabled = true;
        }

        private void Select_Click(object sender, EventArgs e)
        {
            int height_SZ = board.Rows.Count;
            int width_SZ = board.Columns.Count;
            

            for (int i = 0; i < width_SZ; i++)
            {
                for (int j = 0; j < height_SZ; j++)
                {
                    if (board[i, j].Selected && board[i,j].Style.BackColor!= Color.Brown) {
                        board[i, j].Selected = false;
                        board[i, j].Style.BackColor = Color.Red;
                    }
                }
            }
        }
        // select start and end button
        private void Button1_Click(object sender, EventArgs e) 
        {
            try
            {

                startY = Int32.Parse(startLISTx.SelectedItem.ToString()) - 1;
                startX = Int32.Parse(startLISTy.SelectedItem.ToString()) - 1;
                endY = Int32.Parse(endLISTx.SelectedItem.ToString()) - 1;
                endX = Int32.Parse(endLISTy.SelectedItem.ToString()) - 1;
                if (startX == endX && startY == endY)
                {
                    MessageBox.Show("Please check coordinates...");
                }
                else
                {
                    board[startX, startY].Style.BackColor = Color.Brown;
                    board[startX, startY].Value = "start";

                    board[endX, endY].Style.BackColor = Color.Brown;
                    board[endX, endY].Value = "end";

                    enableButtons();
                    button1.Enabled = false;
                    startLISTx.ClearSelected();
                    startLISTy.ClearSelected();
                    endLISTx.ClearSelected();
                    endLISTy.ClearSelected();

                }
                
            }catch(Exception )
            {
                MessageBox.Show("Please check coordinates..."); 
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

            if (shortestPath.Count() == 0) {
                MessageBox.Show("No path for the selected cells...");
                clearBoard();
            }
            else
            {
                MessageBox.Show("Now showing the shortest path...");
                ColorTheBoard(shortestPath, true);
            }
            pathCount.Text = (shortestPath.Count()-1).ToString()+ " steps";

        }

        private void RunAstar_Click(object sender, EventArgs e)
        {
            List<int> xWalls = new List<int>();
            List<int> yWalls = new List<int>();

            Tuple<List<int>, List<int>> walls = BuildWalls();  // calls the BuildWalls method

            xWalls = walls.Item1;
            yWalls = walls.Item2;
           
            Astar astar = new Astar(startX, startY, endX, endY, 19, 20, xWalls, yWalls); // create A* object
            Tuple<List<Tuple<int, int>>, List<Tuple<int, int>>> paths = astar.get_Astar_path(); // run A* and get the paths (traversal and shortest)
            List<Tuple<int, int>> path = paths.Item1;
            List<Tuple<int, int>> shortestPath = paths.Item2;
  
            ColorTheBoard(path, false); // colors the board

            if (shortestPath.Count() == 0)
            {
                MessageBox.Show("No path for the selected cells...");
                clearBoard();
            }
            else
            {
                MessageBox.Show("Now showing the shortest path...");
                ColorTheBoard(shortestPath, true);
            }
            pathCount.Text = (shortestPath.Count() - 1).ToString() + " steps";

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

            pathCount.Text = (path.Count() - 1).ToString() + " steps";
        }

        void clearBoard()
        {
            button1.Enabled = true;
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
            // enableButtons();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clearBoard();
        }
    }
}
