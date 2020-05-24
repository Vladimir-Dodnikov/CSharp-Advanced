using System;
using System.IO;

namespace _05._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 4.0;
            var totalSize = new FileInfo(@"../../../sliceMe.txt").Length;
            var sizePerFile = (int)Math.Ceiling(totalSize / n);

            using (var r = new FileStream(@"../../../sliceMe.txt", FileMode.Open))
            {
                for (int i = 1; i <= n; i++)
                {
                    byte[] buffer = new byte[sizePerFile];

                    int readBytes = r.Read(buffer, 0, sizePerFile);

                    using (FileStream write = new FileStream ($@"../../../Part-{i}.txt", FileMode.OpenOrCreate))
                    {
                        write.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
