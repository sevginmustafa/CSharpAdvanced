using System;
using System.IO;

namespace _05.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                int pieceCount = 4;

                long size = reader.Length / pieceCount;

                for (int i = 0; i < pieceCount; i++)
                {
                    using (FileStream writer = new FileStream($"../../../part-{i + 1}.txt", FileMode.Create))
                    {
                        byte[] buffer = new byte[1];

                        int count = 0;

                        while (count < size)
                        {
                            reader.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, buffer.Length);
                            count += buffer.Length;
                        }
                    }
                }
            }
        }
    }
}
