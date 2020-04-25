using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathAlgorithms
{

    
    class Astar
    {


        int[] d1 = new int[] { 1, 1, 1, -1, -1, -1, 0, 0 };  // movements
        int[] d2 = new int[] { 1, -1, 0, 0, -1, 1, 1, -1 };
  
        public Astar(int start_x, int start_y, int end_x, int end_y, int height_, int width_, List<int> wallx, List<int> wally)
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


        public int calcH(Node a, Node b)
        {
            return (a.getX() - b.getX()) * (a.getX() - b.getX())
                                         +
                   (a.getY() - b.getY()) * (a.getY() - b.getY());
        }

        public Node equalize(Node a, Node b)
        {
            a.setX(b.getX());
            a.setY(b.getY());
            a.setG(b.getG());
            a.setH(b.getH());
            a.setF(b.getF());
            return a;
        }

        public void performAstar()
        {
            Node start = new Node(startX, startY);
            Node target = new Node(endX, endY);

            List<Node> OpenList = new List<Node>();
            List<Node> ClosedList = new List<Node>();
            bool found = false;
            OpenList.Add(start);

            while(OpenList.Count !=0 && !found)
            {
                Node currNode = new Node(-1, -1);
                currNode = OpenList[0];

                int index = 0, finalIndex = 0;

                /* Node with minimum [ F ] */
                foreach(Node someNode in OpenList )
                {
                    if (someNode.getF() < currNode.getF())
                    {
                        currNode = someNode;
                        finalIndex = index;
                    }
                    index++;
                }

                OpenList.RemoveAt(finalIndex);
                ClosedList.Add(currNode);
                /* Add the cell */
                Tuple<int, int> toAppend = Tuple.Create(currNode.getX(), currNode.getY());
                toReturn.Add(toAppend);

                if(currNode == target){
                    found = true;
                    break;
                }

                /* Generate Neighbors */
                List<Node> Neighbors = new List<Node>();

                for (int i = 0; i < 8; i++)
                {
                    int nX, nY;
                    nX = currNode.getX() + d1[i];
                    nY = currNode.getY() + d2[i];

                    // check if valid
                    if (nX < 0 || nY < 0 || nX >= height || nY >= width || table[nX,nY] ==1)
                        continue;
                    Node nextNode = new Node(nX, nY); // neighbor
                    Neighbors.Add(nextNode);
                }

                foreach(Node someNode in Neighbors )
                {

                    bool ok = true;
                    //  Ignore if in the ClosedList
                    foreach(Node closedNode in ClosedList)
                    {
                        if (closedNode == someNode)
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (!ok) continue;
                    // Calculate G,H,F
                    someNode.setG(currNode.getG() + 1);
                    someNode.setH(calcH(someNode, target));
                    someNode.setF(someNode.getG() + someNode.getH());

                    // Check if already in the OpenList
                    bool InOpenList = false;
                    foreach(Node openNode in OpenList )
                    {

                        // not worthed adding to OpenList
                        if (openNode == someNode && openNode.getG() < someNode.getG())
                        {
                            InOpenList = true;
                            break;
                        }
                    }
                    if (!InOpenList)
                        OpenList.Add(someNode);
                }
            }
        }
        public List<Tuple<int, int>> get_Astar_path()
        {
            performAstar();
            return toReturn;
        }
    }
}
