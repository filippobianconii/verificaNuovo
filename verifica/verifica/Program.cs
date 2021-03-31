using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace verifica
{
    class Program
    {
        static int sub1;
        static int sub2;
        static int sottrazione;

        static void Main(string[] args)
        {

            Thread t1 = new Thread(new ThreadStart(Sottrazione));
           // Thread t2 = new Thread(new ThreadStart());
           // Thread t3 = new Thread(new ThreadStart());

            sub1 = 10;
            sub2 = 5;
            sottrazione = 0;

            t1.Start();
            t1.Join();

            int i = 0;
            while(i < 5)
            {
                Console.WriteLine(sottrazione);
                i++;
            }

            
        }

        public static void Sottrazione()
        {
            sottrazione = sub1 - sub2;
        }

    }
}
