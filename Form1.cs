using System;
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        void prepareBoard()
        {
            board.BackgroundColor = Color.Black;
            board.DefaultCellStyle.BackColor = Color.Black;

            for(int i = 0; i < 10; i++)
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
                //Console.WriteLine("stop wait timer");
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
                        // MessageBox.Show(i.ToString() + " : " + j.ToString());
                        xWalls.Add(i);
                        yWalls.Add(j);
                       // board[i, j].Style.BackColor = Color.Red;
                    }

                    if (board[i, j].Selected)
                    {
                        // MessageBox.Show(i.ToString() + " : " + j.ToString());
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
           
            if (clr == true) toColor = color2;
            int iterator = 0;
            foreach (Tuple<int, int> x in path)
            {
                wait(100);
                int xx = x.Item1;
                int yy = x.Item2;
                if (clr == true)
                {
                    board[xx, yy].Value = iterator;
                }

                if (xx == 6 && yy == 8)
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

            BFS bfs = new BFS(0, 0, 6, 8, 9, 9, xWalls, yWalls); // create BFS object
            Tuple<List<Tuple<int, int>>, List<Tuple<int, int>>> paths = bfs.get_BFS_path(); // run BFS and get the paths (traversal and shortest)
            List<Tuple<int, int>> path = paths.Item1;
            List<Tuple<int, int>> shortestPath = paths.Item2;
            //MessageBox.Show(path.Count.ToString());

            ColorTheBoard(path, false); // colors the board

            MessageBox.Show("Now showing the shortest path...");

            ColorTheBoard(shortestPath, true);


        }

        private void RunDFS_Click(object sender, EventArgs e)
        {

            List<int> xWalls = new List<int>();
            List<int> yWalls = new List<int>();

            Tuple<List<int>, List<int>> walls = BuildWalls();  // calls the BuildWalls method

            xWalls = walls.Item1;
            yWalls = walls.Item2;

            DFS dfs = new DFS(0, 0, 6, 8, 9, 9, xWalls, yWalls); // create BFS object

            List<Tuple<int, int>> path = dfs.get_DFS_path();  // run DFS get the cells traversed in BFS order
            //MessageBox.Show(path.Count.ToString());

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
