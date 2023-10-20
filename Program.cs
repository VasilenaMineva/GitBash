using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_bash
{
    internal class Program
    {
        public const string FILE_NAME = "example.bin";
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < 11; i++)
            {
                bw.Write(1);
            }
            bw.Close();
            fs.Close();
            using (fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                for (int i = 0; i<11; i ++)
                {
                    Console.WriteLine(br.ReadInt32());
                }

            }
            fs.Close();
        }
    }
}
