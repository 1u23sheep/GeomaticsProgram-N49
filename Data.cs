using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N49
{
    internal class Data
    {
        public static List<Point> DATAS = new List<Point>();
        public static List<Point> Supplement = new List<Point>();
        public static void Read(StreamReader sr)
        {
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                Point p = new Point();
                p.Read(p, line);
                DATAS.Add(p);
            }
            sr.Close();
        }
    }
}
