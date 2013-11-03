using OptimusApi.Tool.D2P.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Drawing;
namespace BotApiTest.Pathfinding
{
    public class Pathfinding
    {
        private const int MapHeight = 20;
        private const int MapWidth = 14;
        public CellInfo[] MapStatus = new CellInfo[560];
        private List<CellInfo> openList = new List<CellInfo>();
        public int LenghtPath { get; private set; }
        private Map Map { get; set; }

        private int start, end;

        private bool finished = false;
        public Pathfinding(int _start, int _end, Map currentMap)
        {
            start = _start;
            end = _end;
            Map = currentMap;
            LoadPoint();
            InitInformation();
        }

        private void CalculPath()
        {
            CellInfo currentCell = MapStatus[start];
            while (!finished){
                FindNeighboringCell(currentCell);
                currentCell = openList[0]; 
                currentCell.ClosedList = true;
                currentCell.OpenList = false;
                openList.RemoveAt(0);
            }
        }

        private List<short> FinalPath()
        {
            CellInfo currentCell = MapStatus[end];
            List<CellInfo> cells = new List<CellInfo>();
          while (CoordToCellId(currentCell.X, currentCell.Y) != CoordToCellId(MapStatus[start].X, MapStatus[start].Y))
            {
                cells.Add(currentCell);
                currentCell = MapStatus[currentCell.parent];
            }
           cells.Add(MapStatus[start]);
           cells.Reverse();
          
            return GetCompressedPath(cells);
        }

        private void InitInformation()
        {
            for (int i = 0; i < 560; i++)
            {
                if (i == start){
                    MapStatus[i].Closed = false;
                    MapStatus[i].Opened = true;
                }
                else if (i == end){
                    MapStatus[i].Closed = true;
                    MapStatus[i].Opened = false;
                }
                else{
                    MapStatus[i].Closed = false;
                    MapStatus[i].Opened = false;
                }
                MapStatus[i].CalculeHeuristic(MapStatus[end]);
            }
        }

        private void LoadPoint()
        {
            int loc_1 = 0;
            int loc_2 = 0;
            int loc_3 = 0;
            int loc_4 = 0;
            int loc_5 = 0;
            while (loc_5 < MapHeight) /*  on actualize tout les noeud avec leur vrais valeur x,y */
            {
                loc_4 = 0;
                while (loc_4 < MapWidth)
                {
                    bool mov = Map.Cells[loc_3].Mov;
                    MapStatus[loc_3] = new CellInfo(0, false, false, loc_1 + loc_4, loc_2 + loc_4, mov);
                    loc_3++;
                    loc_4++;
                }
                loc_1++;
                loc_4 = 0;
                while (loc_4 < MapWidth)
                {
                    bool mov = Map.Cells[loc_3].Mov;
                    MapStatus[loc_3] = new CellInfo(0, false, false, loc_1 + loc_4, loc_2 + loc_4, mov);
                    loc_3++;
                    loc_4++;
                }
                loc_2 = loc_2 - 1;
                loc_5++;
            }
        }

        public short CoordToCellId(Point cellPosition)
        {
            return CoordToCellId(cellPosition.X, cellPosition.Y);
        }

        public short CoordToCellId(int cellX, int cellY)
        {
            int HighPart = cellX - cellY;
            int LowPart = (cellY + HighPart / 2);
            int resul = HighPart * 14 + LowPart;
            return (short)resul;
        }

        public Point CellIdToCoord(short cellId)
        {
            if (cellId < 0 || cellId >= MapStatus.Length)
                throw new ArgumentOutOfRangeException("Invalid cell id");
            return new Point(MapStatus[cellId].X,MapStatus[cellId].Y);
        }

        private void AddCell(short cell, CellInfo node)
        {
            if (cell > 559 || cell < 0)
                return;

            if (MapStatus[cell].Mov == true)
            {
                if (MapStatus[cell].Closed == true)
                {
                    MapStatus[cell].parent = CoordToCellId(new Point(node.X, node.Y));
                    finished = true;
                    return;
                }

                if (MapStatus[cell].OpenList == false && MapStatus[cell].ClosedList == false)
                {
                    MapStatus[cell].parent = CoordToCellId(new Point(node.X, node.Y));
                    MapStatus[cell].OpenList = true;
                    MapStatus[cell].Fixed(node, MapStatus[end]);
                    MapStatus[cell].G = node.G + 5;
                    MapStatus[cell].F = MapStatus[cell].Heuristic + MapStatus[cell].G;
                    openList.Add(MapStatus[cell]);
                }
            }
        }

        private void FindNeighboringCell(CellInfo node, bool diagonal = true)
        {
            AddCell(CoordToCellId(new Point(node.X, node.Y + 1)), node);
            AddCell(CoordToCellId(node.X - 1, node.Y), node);
            AddCell(CoordToCellId(node.X + 1, node.Y), node);
            AddCell(CoordToCellId(node.X, node.Y - 1), node);

            if (diagonal)
            {
                AddCell(CoordToCellId(node.X - 1, node.Y + 1), node);
                AddCell(CoordToCellId(node.X + 1, node.Y + 1), node);
                AddCell(CoordToCellId(node.X + 1, node.Y - 1), node);
                AddCell(CoordToCellId(node.X - 1, node.Y - 1), node);
            }

            Traitement();
        }

        private void Traitement()
        {
            CellInfo[] last = openList.ToArray();
            openList = last.OrderBy(info => info.F).ToList();
        }

        private List<short> GetCompressedPath(List<CellInfo> path)
        {
            LenghtPath = path.Count;
            for (int i = 0; i < path.Count - 1; i++)
            {
                path[i].Orientation = path[i].OrientationTo(path[i + 1], true);
            }

            path[path.Count - 1].Orientation = path[path.Count - 2].Orientation;

            List<short> cellsIds = new List<short>();
            int orientation = (int)path[0].Orientation;
            short result = (short)((orientation & 7) << 12 | path[0].CellId & 4095);
            cellsIds.Add(result);
            if (path.Count > 0)
            {
                int _loc1_ = path.Count - 1;
                while (_loc1_ > 0)
                {
                    if (path[_loc1_].Orientation == path[_loc1_ - 1].Orientation)
                    {
                        _loc1_--;
                    }
                    else
                    {
                        int _loc3_ = (int)path[_loc1_].Orientation;
                         result = (short)((_loc3_ & 7) << 12 | path[_loc1_].CellId & 4095);
                        cellsIds.Add(result);
                        _loc1_--;
                    }
                }
            }
            orientation = (int)path[path.Count - 1].Orientation;
            result = (short)((orientation & 7) << 12 | path[path.Count - 1].CellId & 4095);
            cellsIds.Add(result);
            return cellsIds;
        }

        public List<short> GetPath()
        {       
            CalculPath();
            return FinalPath();
        }
    }
}
