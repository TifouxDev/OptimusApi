using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map
{
    public class Layer
    {
        //Constructeur
        public int LayerId{get; private set;}
        public int RefCell{get; private set;}
        public int CellsCount{get; private set;}
        public ReadOnlyCollection<Cell> Cells { get; private set; }
 //     public var cells:Array;

        private Map Map {get;  set;}
        public Layer(Map map, FastBigEndianReader reader)
        {
            Map = map;
            Read(reader);
        }

        private void Read(FastBigEndianReader reader)
        {
            List<Cell> _cells = new List<Cell>();
            this.LayerId = reader.ReadInt();
            this.CellsCount = reader.ReadShort();
            for (int i = 0; i < CellsCount; i++)
            {
                Cell c = new Cell(Map, reader);
                _cells.Add(c);
            }
            Cells = _cells.AsReadOnly();
        }
    }
}
