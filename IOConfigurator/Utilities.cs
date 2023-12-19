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
        public static void StartApp(String path, ProcessWindowStyle style, bool wait)
        {
            if (File.Exists(path))
            {
                Process ExternalProcess = new Process();
                ExternalProcess.StartInfo.FileName = path;
                ExternalProcess.StartInfo.WindowStyle = style;
                ExternalProcess.Start();
                if (wait)
                {
                    ExternalProcess.WaitForExit();
                }
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
            bool fileExists = File.Exists(path); // Check before you create it
            IniFile MyIni = new IniFile(@path);

            if (!fileExists)
            {
                MyIni.Write("fastio2kb_enabled", "false", "FASTIO");
                MyIni.Write("fastio2kb_exe", "E:\\SYSTEM\\IO\\FASTIO\\FASTIO2KB.EXE\n", "FASTIO");

                MyIni.Write("jvs2kb_enabled", "false", "JVS");
                MyIni.Write("jvs2kb_exe", "E:\\SYSTEM\\IO\\JVS\\JVS2KB.EXE\n", "JVS");

                MyIni.Write("joytokey_enabled", "false", "JOYTOKEY");
                MyIni.Write("joytokey_exe", "E:\\SYSTEM\\IO\\JOYTOKEY\\JOYTOKEY.EXE", "JOYTOKEY");
                MyIni.Write("joytokey_ini", "E:\\SYSTEM\\IO\\JOYTOKEY\\JOYTOKEY.INI\n", "JOYTOKEY");

                MyIni.Write("backforcefeeder_enabled", "false", "BACKFORCEFEEDER");
                MyIni.Write("backforcefeeder_exe", "E:\\SYSTEM\\IO\\BFF\\BACKFORCEFEEDER.EXE", "BACKFORCEFEEDER");
                MyIni.Write("backforcefeedergui_exe", "E:\\SYSTEM\\IO\\BFF\\BACKFORCEFEEDERGUI.EXE\n", "BACKFORCEFEEDER");
            }

            String[] values = new String[10];

            values[0] = MyIni.Read("fastio2kb_enabled", "FASTIO");
            values[1] = MyIni.Read("fastio2kb_exe", "FASTIO");

            values[2] = MyIni.Read("jvs2kb_enabled", "JVS");
            values[3] = MyIni.Read("jvs2kb_exe", "JVS");

            values[4] = MyIni.Read("joytokey_enabled", "JOYTOKEY"); ;
            values[5] = MyIni.Read("joytokey_exe", "JOYTOKEY");
            values[6] = MyIni.Read("joytokey_ini", "JOYTOKEY");

            values[7] = MyIni.Read("backforcefeeder_enabled", "BACKFORCEFEEDER");
            values[8] = MyIni.Read("backforcefeeder_exe", "BACKFORCEFEEDER");
            values[9] = MyIni.Read("backforcefeedergui_exe", "BACKFORCEFEEDER");

            return values;
        }

        public static void UpdateIni(String[] iniValues)
        {
            String path = System.AppDomain.CurrentDomain.BaseDirectory + "config.ini";
            if (File.Exists(path))
            {
                IniFile MyIni = new IniFile(@path);

                MyIni.Write("fastio2kb_enabled", iniValues[0], "FASTIO");

                MyIni.Write("jvs2kb_enabled", iniValues[2], "JVS");

                MyIni.Write("joytokey_enabled", iniValues[4], "JOYTOKEY");

                MyIni.Write("backforcefeeder_enabled", iniValues[7], "BACKFORCEFEEDER");
            }
        }

    }
}
