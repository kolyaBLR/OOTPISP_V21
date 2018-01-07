using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPISP_V21
{
    class Vector: AbstractVector
    {
        public Vector()
        {
            Vector = new List<int>();
        }

        public Vector(List<int> list)
        {
            Vector = list;
        }

        public Vector(ref Vector copy)
        {
            Vector outObj = new Vector();
            foreach (var item in copy.Vector)
                outObj.Vector.Add(item);
        }

        ~Vector()
        {
            System.Console.WriteLine("destruction");
        }
        public override void Sort()
        {
            if (Vector.Count == 0 || Vector.Count == 1)
                return;
            int max1 = Vector[0] > Vector[1] ? Vector[0] : Vector[1];
            int max2 = Vector[0] < Vector[1] ? Vector[0] : Vector[1];
            int indexMax1 = Vector[0] > Vector[1] ? 0 : 1;
            int indexMax2 = Vector[0] < Vector[1] ? 0 : 1;
            for (int i = 0; i < Vector.Count; i++)
            {
                if (Vector[i] > max1)
                {
                    max2 = max1;
                    indexMax2 = indexMax1;
                    max1 = Vector[i];
                    indexMax1 = i;
                }
            }
            Vector[indexMax1] = max2;
            Vector[indexMax2] = max1;
        }

        public void Print(string message)
        {
            Console.Write("{0}:", message);
            for (int i = 0; i < Vector.Count; i++)
                Console.Write(" {0}", Vector[i]);
            Console.WriteLine();
        }
    }
}
