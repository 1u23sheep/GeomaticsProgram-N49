using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N49
{
    internal class Algo
    {
        //补充点
        public static void AddPoint(int Type)
        {
            Data.Supplement.Clear();
            int n = Data.DATAS.Count;
            //闭合
            if (Type == 0)
            {
                Data.Supplement.Add(new Point() { ID = "A", X = Data.DATAS[n - 2].X, Y = Data.DATAS[n - 2].Y });
                Data.Supplement.Add(new Point() { ID = "B", X = Data.DATAS[n - 1].X, Y = Data.DATAS[n - 1].Y });
                for (int i = 0; i < n; i++)
                {
                    Point p = new Point() { ID = Data.DATAS[i].ID, X = Data.DATAS[i].X, Y = Data.DATAS[i].Y };
                    Data.Supplement.Add(p);
                }
                Data.Supplement.Add(new Point() { ID = "C", X = Data.DATAS[0].X, Y = Data.DATAS[0].Y });
                Data.Supplement.Add(new Point() { ID = "D", X = Data.DATAS[1].X, Y = Data.DATAS[1].Y });
            }
        }
    }
}
