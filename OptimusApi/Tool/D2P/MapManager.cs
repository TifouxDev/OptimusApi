using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P
{
    public class MapManager
    {
        private string path;
   //     private NLog.Logger log = Optimus.Common.Log.Logger.GetInstance("[D2PReader]");
        private List<PakProtocol2> entriesLink;
        public MapManager(string directory)
        {
            path = directory;
            entriesLink = new List<PakProtocol2>();
            if (Directory.Exists(directory)){
                Ini();
            }
            else{
           //     log.Fatal("Le chemin d'accès des d2p son incorrect!");
            }
        }

        private void Ini()
        {
            foreach(string file in Directory.GetFiles(path))
            {
                if (file.Contains("d2p"))
                {
                   entriesLink.Add(new PakProtocol2(file));
                }
            }
        }

        public Map.Map GetMap(int id)
        {
            foreach (PakProtocol2 file in entriesLink)
            {
               bool contains = file.ContainsMapId(id);
               if (contains)
                   return file.ReadMap(id);
            }
            return null;
        }
    }
}
