using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod3_1302204026
{
    class KodePos
    {
        public static void getKodePos(string kelurahan, string kodePos)
        {
            Console.WriteLine(kelurahan + " " + kodePos);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            KodePos.getKodePos("Batununggal", "40266");
            KodePos.getKodePos("Kujangsari", "40287");
            KodePos.getKodePos("Mengger", "40267");
            KodePos.getKodePos("Wates", "40256");
            KodePos.getKodePos("Cijaura", "40287");
            KodePos.getKodePos("Jatisari", "40286");
            KodePos.getKodePos("Margasari", "40286");
            KodePos.getKodePos("Sekejati", "40286");
            KodePos.getKodePos("Kebonwaru", "40272");
            KodePos.getKodePos("Maleer", "40274");
            KodePos.getKodePos("Samoja", "40273");

            Console.WriteLine();

        }
    }
}
