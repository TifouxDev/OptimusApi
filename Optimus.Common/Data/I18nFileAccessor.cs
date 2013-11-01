using Optimus.Common.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Common.Data
{
    public class I18nFileAccessor
    {
        //Constructeur
        private FastBigEndianReader stream;
        private Dictionary<int, int> indexes = new Dictionary<int,int>();
        private Dictionary<int, int> unDiacriticalIndex = new Dictionary<int, int>();
        private Dictionary<string, int> textIndexes = new Dictionary<string, int>();
        private Dictionary<int, int> textIndexesOverride = new Dictionary<int, int>();
        private Dictionary<int, int> textSortIndex = new Dictionary<int, int>();
        private uint startTextIndex = 4;
        private int textCount = 0;
        private string path;
        private bool Initialize = false;
        private byte[] buffer;


        private static bool Loaded = false;
        private static I18nFileAccessor I18n;

        public I18nFileAccessor(string I18nPath)
        {
            if(File.Exists(I18nPath))
            path = I18nPath;
            Ini();
        }

        private void Ini()
        {
            stream = new FastBigEndianReader(File.ReadAllBytes(path));
            int pos = stream.ReadInt();
            stream.Seek(pos, SeekOrigin.Begin);

            int lenghtIndexes = stream.ReadInt();
            for (int i = 0; i < lenghtIndexes; i += 9)
            {
                int key = stream.ReadInt();
                bool criticalBool = stream.ReadBoolean();
                int value = stream.ReadInt();
                this.indexes[key] = value;
                if (criticalBool)
                {
                    i = i + 4;
                    this.unDiacriticalIndex[key] = stream.ReadInt();
                }
                else
                {
                    this.unDiacriticalIndex[key] = value;
                }
            }

            int lenghtTextIndexes = stream.ReadInt();
            while (lenghtTextIndexes > 0)
            {
                int position = (int)stream.Position;
                string text = stream.ReadUTF();
                int val = stream.ReadInt();
                textCount++;
                this.textIndexes[text] = val;
                lenghtTextIndexes = (int)(lenghtTextIndexes - (stream.Position - position));
            }

            int textSortLenght = stream.ReadInt();
            int actuelValue = 0;
            while (textSortLenght > 0)
            {
                int currentPos = (int)stream.Position;
                this.textSortIndex[stream.ReadInt()] = ++actuelValue;
                textSortLenght = (int)(textSortLenght - (stream.Position - currentPos));
            }

        }

        public string GetText(int index)
        {
            if (indexes == null){
                return "";
            }
            int pos = this.indexes[index];
            if (pos == null) {
                return "";
            }
            stream.Seek(pos, SeekOrigin.Begin);
            return stream.ReadUTF();
        }

        public static I18nFileAccessor GetInstance(string path)
        {
            if (!Loaded)
            {
                I18n = new I18nFileAccessor(path);
                Loaded = true;
            }
            return I18n;
        }
    }
}
