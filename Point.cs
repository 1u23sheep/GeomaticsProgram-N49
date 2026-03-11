using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N49
{
    internal class Point
    {
        public string ID;
        public double X;
        public double Y;
        public Point()
        {
            ID = "NULL";
            X = 0;
            Y = 0;
        }
        public void Read(Point p,string line)
        {
            var part = line.Split(',');
            p.ID = part[0];
            p.X = double.Parse(part[1]);
            p.Y = double.Parse(part[2]);
        }
    }
}
