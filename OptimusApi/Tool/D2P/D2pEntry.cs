using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P
{
    public class D2pEntry
    {
        public int Index { get; private set; }
        public int Size { get; private set; }
        public int BaseOffset { get; private set; }
        public D2pEntry(int index, int size, int baseOffset)
        {
            this.Index = index;
            this.Size = size;
            this.BaseOffset = baseOffset;
        }
    }
}
