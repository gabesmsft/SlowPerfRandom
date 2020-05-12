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
                int j = r2.Next(2000, 20000);
                string path = @"d:\temp\wakawaka\MyTest.txt";
                for (int k = 0; k < j; k++)
                {
                    try
                    {
                        // Create the file, or overwrite if the file exists.
                        using (FileStream fs = File.Create(path))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                        }

                        // Open the stream and read it back.
                        using (StreamReader sr = File.OpenText(path))
                        {
                        }
                    }

                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        public static void MysteryMethod3(string s)
        {
        }

    }
}
