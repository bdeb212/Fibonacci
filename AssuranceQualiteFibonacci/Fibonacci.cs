using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssuranceQualiteFibonacci
{
    class Fibonacci
    {
        // retourner le Nieme numero de Fibonacci
        public static Int32 getFn(Int32 n) {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return getFn(n - 1) + getFn(n - 2);
        }
        // retourner le sequence de Fibonacci just'a n
        public static List<Int32> getFlist(Int32 n)
        {
            List<Int32> flist = new List<Int32>();
            for(int i=0; i<=n; i++)
            {
                flist.Add(getFn(i));
            }
            return flist;
        }
    }
}
