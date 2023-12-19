using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IOConfigurator
{
    internal class Utilities
    {
        public static bool StartApp(String path, ProcessWindowStyle style)
        {
            if (File.Exists(path))
            {
                Process ExternalProcess = new Process();
                ExternalProcess.StartInfo.FileName = path;
                ExternalProcess.StartInfo.WindowStyle = style;

                if (ExternalProcess.Start())
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }

        }

        public static void StartAndWait(String path, ProcessWindowStyle style)
        {
            if (File.Exists(path))
            {
                Process ExternalProcess = new Process();
                ExternalProcess.StartInfo.FileName = path;
                ExternalProcess.StartInfo.WindowStyle = style;
                ExternalProcess.Start();
                ExternalProcess.WaitForExit();
            }

        }

        public static bool KillApp(String name)
        {
            bool anyKilled = false;

            foreach (var process in Process.GetProcessesByName(name))
            {
                process.Kill();
                anyKilled = true;
            }

            return anyKilled;
        }

        public static bool EditText(String path, String find, String replace)
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                text = text.Replace(find, replace);
                File.WriteAllText(path, text);
                return true;
            }
            else return false;
        }

        public static String[] CheckIni()
        {
            String path = System.AppDomain.CurrentDomain.BaseDirectory + "config.ini";
            String[] paths = new String[6];

            bool fileExists = File.Exists(path);
            IniFile MyIni = new IniFile(@path);

            if (!fileExists)
            {
                MyIni.Write("fastioexe", "");
                MyIni.Write("jvsexe", "");
                MyIni.Write("j2kexe", "E:\\SYSTEM\\JOYTOKEY\\JOYTOKEY.EXE");
                MyIni.Write("j2kini", "E:\\SYSTEM\\JOYTOKEY\\JOYTOKEY.INI");
                MyIni.Write("bffexe", "");
                MyIni.Write("bffguiexe", "");
            }

            paths[0] = MyIni.Read("fastioexe", "IOConfigurator");
            paths[1] = MyIni.Read("jvsexe", "IOConfigurator");
            paths[2] = MyIni.Read("j2kexe", "IOConfigurator");
            paths[3] = MyIni.Read("j2kini", "IOConfigurator");
            paths[4] = MyIni.Read("bffexe", "IOConfigurator"); 
            paths[5] = MyIni.Read("bffguiexe", "IOConfigurator");

            return paths;
        }
    }
}
