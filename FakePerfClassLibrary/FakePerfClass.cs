using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace FakePerfClassLibrary
{
    public static class FakePerfClass
    {
        public static void MysteryMethod1(string s)
        {
        }

        public static void MysteryMethod2(string s)
        {
            Random r1 = new Random();
            int i = r1.Next(0, 100);
            if (i % 5 == 0)
            {
                Random r2 = new Random();
                int j = r2.Next(1000, 5000);
                Thread.Sleep(j);
            }
        }

        public static void MysteryMethod3(string s)
        {
        }

        public async static Task<int> MysteryMethod4(string s)
        {
            Random r1 = new Random();
            int i = r1.Next(0, 100);
            int j = 0;
            if (i % 5 == 0)
            {
                Random r2 = new Random();
                j = r2.Next(1000, 5000);
                await Task.Delay(j);
            }
            return j;
        }

    }
}
