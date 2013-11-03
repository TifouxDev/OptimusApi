using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P
{
    public class PakProtocol2
    {
      //  private NLog.Logger log = Optimus.Common.Log.Logger.GetInstance("[D2PReader]");
        public PakProtocol2(string path)
        {
            if (File.Exists(path))
            {
                Read(path);
            }
        }
        private Dictionary<string, string> _loc5_;
        private Dictionary<int, D2pEntry> d2pEntries;
        private byte[] dataFile;
        private void Read(string path)
        {
            d2pEntries = new Dictionary<int, D2pEntry>();
            dataFile = File.ReadAllBytes(path);
            FastBigEndianReader reader = new FastBigEndianReader(dataFile);
            if (!(reader.ReadByte() == 2) || !(reader.ReadByte() == 1))
            {
             //   log.Fatal("Erreur lecture map!");
            }
            else
            {
                reader.Seek(-24, SeekOrigin.End);

                var baseOffset = reader.ReadInt();
                var size = reader.ReadInt();
                var mapsOffet = reader.ReadInt();
                var mapsCount = reader.ReadInt();
                var fileOffset = reader.ReadInt();
                var lenghtFile = reader.ReadInt();

                reader.Seek(fileOffset, SeekOrigin.Begin);
                for (int i = 0; i < lenghtFile; i++)
                {
                    string _loc15_ = reader.ReadUTF();
                    string _loc16_ = reader.ReadUTF();
                  //  _loc5_[_loc15_] = _loc16_;
                }

                reader.Seek(mapsOffet, SeekOrigin.Begin);
                for (int i = 0; i < mapsCount; i++)
                {
                    var mapId = int.Parse(reader.ReadUTF().Remove(0, 2).Replace(".dlm", ""));
                    var index = reader.ReadInt();
                    var sizeMap = reader.ReadInt();
                    d2pEntries[mapId] = new D2pEntry(index, sizeMap, baseOffset);
                }
            }
        }

        public bool ContainsMapId(int id)
        {
            if (d2pEntries.ContainsKey(id))
            {
                return true;
            }

            return false;
        }

        public Map.Map ReadMap(int mapId)
        {
            D2pEntry entry = d2pEntries[mapId];
            FastBigEndianReader reader = new FastBigEndianReader(dataFile);
            reader.Seek(entry.BaseOffset + entry.Index, SeekOrigin.Begin);
            byte[] data = reader.ReadBytes(entry.Size);
            Map.Map map = new Map.Map(new FastBigEndianReader(data));
            return map;
        }
    }
}
