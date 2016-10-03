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
        public static Int32 getFnR(Int32 n) {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return getFn(n - 1) + getFn(n - 2);
        }

        // version no recursive
        public static Int32 getFn(Int32 n)
        {

            // fn_2 : numero pour n-2
            // fn_1 : numero pour n-1
            // fn : numero pour n
            Int32 fn_2 = 0, fn_1 = 1, fn = 1;
            for (int i = 2; i <= n; i++)
            {

                fn = fn_2 + fn_1;

                fn_2 = fn_1;
                fn_1 = fn;


            }
            if (n == 0) return 0;
            if (n == 1) return 1;
            return fn;
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
