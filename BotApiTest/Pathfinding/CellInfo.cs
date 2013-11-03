using Optimus.Common.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotApiTest.Pathfinding
{
    public class CellInfo
    {
        public double Heuristic, F,G;
        public bool Opened;
        public bool Closed;
        public int X, Y;
        public DirectionsEnum Orientation;
        public bool Mov; 
        public CellInfo(double H, bool opened, bool closed, int x, int y, bool mov)
        {
            Heuristic = H;
            Opened = opened;
            Closed = closed;
            X = x;
            Y = y;
            Mov = mov;
        }
        public CellInfo()
        {

        }

        public void CalculeHeuristic(CellInfo end)
        {
            Heuristic = 10 * Math.Sqrt((end.Y - Y) * (end.Y - Y) + (end.X));
        }


        public bool OpenList, ClosedList;
        public int parent;

        public int CellId
        {
            get { return Calcule(); }
        }

        private int Calcule()
        {
            int HighPart = X - Y;
            int LowPart = (Y + HighPart / 2);
            int resul = HighPart * 14 + LowPart;
            return resul;
        }
        public void Fixed(CellInfo currentNode,CellInfo endNode)
        {
            if (X > endNode.Y)
            {
                int diff_x = X - endNode.X;
                if (diff_x == 0)
                {
                    if (X == currentNode.X - 1)
                    {
                        if (Y == currentNode.Y + 1)
                        {
                            Heuristic -= 1;
                        }
                    }
                }
            }

            if (Y < endNode.Y)
            {
                int diff_x = X - endNode.X;
                if (diff_x == 0)
                {
                    if (X == currentNode.X + 1)
                    {
                        if (Y == currentNode.Y - 1)
                        {
                            Heuristic -= 1;
                        }
                    }
                }
            }

            if (X < endNode.X)
            {
                int diff_y = Y - endNode.Y;
                if (diff_y <= 20)
                {
                    if (Y == currentNode.Y + 1)
                    {
                        if (X == currentNode.X - 2)
                        {
                            Heuristic -= 2;
                        }
                    }
                }
            }



        }

        public DirectionsEnum OrientationTo(CellInfo cell, bool diagonal = true) // thank for Bim
        {
            int dx = cell.X - X;
            int dy = Y - cell.Y;

            double distance = Math.Sqrt(dx * dx + dy * dy);
            double angleInRadians = Math.Acos(dx / distance);

            double angleInDegrees = angleInRadians * 180 / Math.PI;
            double transformedAngle = angleInDegrees * (cell.Y > Y ? (-1) : (1));

            double orientation = !diagonal ? Math.Round(transformedAngle / 90) * 2 + 1 : Math.Round(transformedAngle / 45) + 1;

            if (orientation < 0)
            {
                orientation = orientation + 8;
            }

            return (DirectionsEnum)(uint)orientation;
        }
    }
}
