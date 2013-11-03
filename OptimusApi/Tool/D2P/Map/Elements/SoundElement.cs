using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map.Elements
{
   public class SoundElement : IElement
    {
  /// <summary>
  /// constructeur
  /// </summary>
  
       public int SoundId;
       public int MinDelayBetweenLoops;
       public int MaxDelayBetweenLoops;
       public int BaseVolume;
       public int FullVolumeDistance;
       public int NullVolumeDistance;

       private Map Map { get;  set; }

       public SoundElement(Map map, FastBigEndianReader reader)
       {
           Map = map;
           Read(reader);
       }

       public void Read(FastBigEndianReader reader)
       {
           this.SoundId = reader.ReadInt();
           this.BaseVolume = reader.ReadShort();
           this.FullVolumeDistance =  reader.ReadInt();
           this.NullVolumeDistance = reader.ReadInt();
           this.MinDelayBetweenLoops = reader.ReadShort();
           this.MaxDelayBetweenLoops = reader.ReadShort();
       }

       public Optimus.Common.Enums.ElementTypesEnum ElementType
       {
           get { return Optimus.Common.Enums.ElementTypesEnum.SOUND; }
       }
    }
}
