using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map
{
    public class Fixture
    {      
        public int FixtureId{get; private set;}
        public  Point Offset{get; private set;}
        public int Hue{get; private set;}
        public Color Color{get; private set;}
        public uint Alpha{get; private set;}
        public Point Scale{get; private set;}   
        public int Rotation{get; private set;}

        private Map Map {  get;  set; }

        public Fixture(Map map, FastBigEndianReader reader)
        {
            Map = map;
            Read(reader);
        }

        private void Read(FastBigEndianReader reader)
        {
            this.FixtureId = reader.ReadInt();
            this.Offset = new Point(reader.ReadShort(), reader.ReadShort());
            this.Rotation = reader.ReadShort();
            this.Scale = new Point(reader.ReadShort(), reader.ReadShort());
            this.Color = Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
            this.Hue = Color.R | Color.G | Color.B;
            this.Alpha = reader.ReadByte();
        }
    }
}
