using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace IBiZ3
{
    internal static class Program
    {
        public static string CipherString(string text, string key){
            string ABC = "¿¡¬√ƒ≈®∆«»… ÀÃÕŒœ–—“”‘’÷◊ÿŸ€‹⁄›ﬁﬂ 0123456789";
            List<int> code = new List<int>();
            List<int> keycode = new List<int>();
            string final = "";
            foreach (char c in text)
            {
                code.Add(ABC.IndexOf(c));
            }
            foreach (char c in key)
            {
                keycode.Add(ABC.IndexOf(c));
            }
            int sum = 0;
            for (int i =0;  i < code.Count; i++)
            {
                sum = code[i] + keycode[i%keycode.Count];
                final += ABC[sum%ABC.Length];
            }
            return final;
        }

        public static string DecipherString(string text, string key)
        {
            string ABC = "¿¡¬√ƒ≈®∆«»… ÀÃÕŒœ–—“”‘’÷◊ÿŸ€‹⁄›ﬁﬂ 0123456789";
            List<int> code = new List<int>();
            List<int> keycode = new List<int>();
            string final = "";
            foreach (char c in text)
            {
                code.Add(ABC.IndexOf(c));
            }
            foreach (char c in key)
            {
                keycode.Add(ABC.IndexOf(c));
            }
            int sum = 0;
            for (int i = 0; i < code.Count; i++)
            {
                sum = (code[i] + ABC.Length - keycode[i % keycode.Count])%ABC.Length;
                final += ABC[sum];
            }
            return final;
        }
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}