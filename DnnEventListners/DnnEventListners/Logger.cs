using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnnEventListners
{
    public static class Logger
    {
        public static void Log(string data)
        {
            var fileNae = Path.Combine(DotNetNuke.Common.Globals.ApplicationMapPath, "App_Data/events.txt");
            File.AppendAllText(fileNae, DateTime.Now + " " + data + Environment.NewLine);
        }
    }
}
