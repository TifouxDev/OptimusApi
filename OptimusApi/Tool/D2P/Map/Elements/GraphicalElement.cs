using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map.Elements
{
   public class GraphicalElement : IElement
    {
       // Constructeur
       public int ElementId { get; private set; }
       public Color Hue { get; private set; }
       public Color Shadow { get; private set; }
       public Color FinalTeint { get; private set; }
       public Point Offset { get; private set; }
       public Point PixelOffset { get; private set; }
       public int Altitude { get; private set; }
       public uint Identifier { get; private set; }

       public const float CELL_HALF_WIDTH = 43;
       public const float CELL_HALF_HEIGHT = 21.5f;

       private Map Map { get;  set; }
       public GraphicalElement(Map map, FastBigEndianReader reader)
       {
           Map = map;
           Read(reader);
       }

       private void Read(FastBigEndianReader reader)
       {
           this.ElementId = reader.ReadInt();
           this.Hue = Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
           this.Shadow = Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte());

           if (Map.Version <= 4)
           {
               this.Offset = new Point(reader.ReadByte(), reader.ReadByte());
               this.PixelOffset = new Point((int)(this.Offset.X * CELL_HALF_WIDTH), (int)(this.Offset.Y * CELL_HALF_HEIGHT));
           }
           else
           {
               this.PixelOffset = new Point(reader.ReadShort(), reader.ReadShort());
               this.Offset = new Point((int)(this.PixelOffset.X / CELL_HALF_WIDTH), (int)(this.PixelOffset.Y / CELL_HALF_HEIGHT));
           }

           this.Altitude = reader.ReadByte();
           this.Identifier = (uint)reader.ReadInt();
       }

       public Optimus.Common.Enums.ElementTypesEnum ElementType
       {
           get { return Optimus.Common.Enums.ElementTypesEnum.GRAPHICAL; }
       }
    }
}
