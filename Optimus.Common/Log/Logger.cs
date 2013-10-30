using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Common.Log
{
    public class Logger
    {
        private static bool Initialized = false;
        public static NLog.Logger GetInstance(string name = "")
        {
            if (!Initialized) {
                Ini(); }
           
            return LogManager.GetLogger(name);
     
        }

        private static void Ini()
        {
            if (File.Exists(@"\Logs\file.txt")){
                //File.Delete(@"\Logs\file.txt");
            }
            // Step 1. Create configuration object
            LoggingConfiguration config = new LoggingConfiguration();

            // Step 2. Create targets and add them to the configuration
            FileTarget fileTarget = new FileTarget();
            config.AddTarget("file", fileTarget);

            // Step 3. Set target properties
            fileTarget.FileName = "${basedir}/Logs/Log.txt";
            fileTarget.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}"; ;

            LoggingRule rule2 = new LoggingRule("*", LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(rule2);
            // Step 5. Activate the configuration
            LogManager.Configuration = config;
        }
    }
}
