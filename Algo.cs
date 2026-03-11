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
        public static void AddPoint(bool Close)
        {
            Data.Supplement.Clear();
            int n = Data.DATAS.Count;
            if (Close)
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
            else
            {
                Point B = new Point()
                {
                    ID = "B",
                    X = Math.Abs(Data.DATAS[2].X - Data.DATAS[1].X) - Math.Abs(Data.DATAS[1].X - Data.DATAS[0].X),
                    Y = Math.Abs(Data.DATAS[2].Y - Data.DATAS[1].Y) - Math.Abs(Data.DATAS[1].Y - Data.DATAS[0].Y)
                };
                Point A = new Point()
                {
                    ID = "A",
                    X = Math.Abs(Data.DATAS[1].X - Data.DATAS[0].X) - Math.Abs(Data.DATAS[0].X - B.X),
                    Y = Math.Abs(Data.DATAS[1].Y - Data.DATAS[0].Y) - Math.Abs(Data.DATAS[0].Y - B.Y)
                };
                Data.Supplement.Add(A);
                Data.Supplement.Add(B);
                for(int i = 0; i < n; i++)
                {
                    Point p = new Point() { ID = Data.DATAS[i].ID, X = Data.DATAS[i].X, Y = Data.DATAS[i].Y };
                    Data.Supplement.Add(p);
                }
                Point C = new Point()
                {
                    ID = "C",
                    X = Math.Abs(Data.DATAS[n - 3].X - Data.DATAS[n - 2].X) - Math.Abs(Data.DATAS[n - 2].X - Data.DATAS[n - 1].X),
                    Y = Math.Abs(Data.DATAS[n - 3].Y - Data.DATAS[n - 2].Y) - Math.Abs(Data.DATAS[n - 2].Y - Data.DATAS[n - 1].Y)
                };
                Point D = new Point()
                {
                    ID = "D",
                    X = Math.Abs(Data.DATAS[n - 2].X - Data.DATAS[n - 1].X) - Math.Abs(Data.DATAS[n - 1].X - C.X),
                    Y = Math.Abs(Data.DATAS[n - 2].Y - Data.DATAS[n - 1].Y) - Math.Abs(Data.DATAS[n - 1].Y - C.Y)
                };
                Data.Supplement.Add(C);
                Data.Supplement.Add(D);
            }

            //补充点集测试
            //for(int i = 0; i < Data.Supplement.Count; i++)
            //    Debug.WriteLine(Data.Supplement[i].ID + " " + Data.Supplement[i].X + " " + Data.Supplement[i].Y);
        }
    }
}
