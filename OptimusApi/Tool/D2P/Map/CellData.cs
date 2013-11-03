using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map
{
    public class CellData
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        ///   public var id:uint;

      public int Speed;

      public uint MapChangeData;

      public uint MoveZone;
      public bool Mov { get; private set; }

      private int _losmov = 3;

      private int _floor;

      private int _arrow = 0;

        private Map Map { get;  set; }

        public CellData(Map map, FastBigEndianReader reader)
        {
            Map = map;
            Read(reader);
        }

        private void Read(FastBigEndianReader reader)
        {
            this._floor = reader.ReadByte() * 10;
            if (this._floor == -1280)
            {
                return;
            }
            this._losmov = reader.ReadByte();
            this.Speed = reader.ReadByte();
            this.MapChangeData = reader.ReadByte();

            if (this.Map.Version > 5)
            {
                this.MoveZone = reader.ReadByte();
            }

            if (this.Map.Version > 7)
            {
                int tmpBits = reader.ReadByte();
                this._arrow = 15 & tmpBits;
            }

            this.Mov = (this._losmov & 1) == 1;
        }
    }
}
