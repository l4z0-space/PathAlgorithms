using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathAlgorithms
{   
    /* Node used in A* algorithm */
    class Node
    {
        int x, y, F, G, H;
        public Node(int _x, int _y)
        {
            x = _x;
            y = _y;
            F = 0;
            G = 0;
            H = 0;
        }

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public int getG()
        {
            return G;
        }
        public int getF()
        {
            return F;
        }
        public int getH()
        {
            return H;
        }

        public void setX(int _x)
        {
            x = _x;
        }
        public void setY(int _y)
        {
            y = _y;
        }
        public void setF(int _F)
        {
            F = _F;
        }
        public void setH(int _H)
        {
            H = _H;
        }
        public void setG(int _G)
        {
            G = _G;
        }



        public static bool operator ==(Node lhs, Node rhs)
        {
            bool status = false;
            if (lhs.x == rhs.x && lhs.y == rhs.y)
                status = true;
            return status;
        }
        public static bool operator !=(Node lhs, Node rhs)
        {
            bool status = true;
            if (lhs.x == rhs.x && lhs.y == rhs.y)
                status = false;
            return status;
        }
    }
}
