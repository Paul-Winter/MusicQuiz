using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicQuiz
{
    static class Quiz
    {
        public static List<string> list = new List<string>();
        public static int gameDuration = 30;
        public static int musicDuration = 10;
        public static bool randomStart = false;
        public static string lastFolder = "";
        public static bool allDirectories = false;

        public static void ReadMusic()
        {
            try
            {
                string[] musicFiles = Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(musicFiles);
            }
            catch { }
        }

        static string regKeyName = "Software\\Home Games\\MusicQuiz";

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null)
                    return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
            }            
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");                    
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories", false));
                }
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }
    }
}
