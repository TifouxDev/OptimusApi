using Optimus.Common.Enums;
using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map.Elements
{
    public class BasicElement
    {
        public static IElement GetElementFromType(Map map, FastBigEndianReader reader, byte type)
        {
            IElement element = null;
            switch (type)
            {
                case (byte)ElementTypesEnum.GRAPHICAL:
                    element = new GraphicalElement(map, reader);
                    break;

                case (byte)ElementTypesEnum.SOUND:
                    element = new SoundElement(map, reader);
                    break;
            }
            return element;
        }
    }
}
