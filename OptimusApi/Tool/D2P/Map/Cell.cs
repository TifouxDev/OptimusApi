using Optimus.Common.IO;
using OptimusApi.Tool.D2P.Map.Elements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map
{
   public class Cell
    {
       // Constructeur
       public int CellId { get; private set; }
       public int ElementsCount { get; private set; }
       public ReadOnlyCollection<IElement> Elements { get; private set; }

       private Map Map { get; set; }
       
       public Cell(Map map, FastBigEndianReader reader)
       {
           Map = map;
           Read(reader);
       }

       private void Read(FastBigEndianReader reader)
       {
           List<IElement> allElements = new List<IElement>();
           this.CellId = reader.ReadShort();
           this.ElementsCount = reader.ReadShort();
           for (int i = 0; i < ElementsCount; i++)
           {
               IElement be = BasicElement.GetElementFromType(Map, reader, reader.ReadByte());
               allElements.Add(be);
           }
           Elements = allElements.AsReadOnly();
       }
    }
}
