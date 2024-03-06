using System;
using System.IO;

namespace Dotnet_Day10
{
    class FilesEg
    {
        public static void WriteBinary()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("C:\\Banu\\Infinite\\B3\\ourbinaryfile.bin",
                FileMode.Create)))
            {
                writer.Write("0x80234xcc400");
                writer.Write("This is a Binary File");
                writer.Write(true);
            }
        }

        public static void ReadBinary()
        {
            using(BinaryReader reader = new BinaryReader(File.Open("C:\\Banu\\Infinite\\B3\\ourbinaryfile.bin",
                FileMode.Open)))
            {
                Console.WriteLine("Address Code :" + reader.ReadString());
                Console.WriteLine("Information :" + reader.ReadString());
                Console.WriteLine("Data :" +  reader.ReadBoolean());
            }

        }
        //using streamreader and writer classes
        public static void WriteData()
        {
            FileStream fs = new FileStream("ourfirstfile.txt", FileMode.Append,
                FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Enter a String :");

            string str = Console.ReadLine();
            sw.Write(str); // writes the string content into the file poinetd by fs using the pen sw
            sw.Flush();
            sw.Close();

            fs.Close();

        }

        public static void ReadData()
        {

        }
        public static void Main()
        {
            // WriteBinary();
            // ReadBinary();
            WriteData();
            Console.Read();
        }
    }
}
