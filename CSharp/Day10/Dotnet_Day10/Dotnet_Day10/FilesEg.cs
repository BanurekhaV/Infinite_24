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
            FileStream fs = new FileStream("ourfirstfile.txt", FileMode.Open,
                FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            //position the file pointer at the beginning of the file
            sr.BaseStream.Seek(20, SeekOrigin.Begin);

            //read till the end of file
            string str = sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine("{0}", str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public static void Main()
        {
            // WriteBinary();
            // ReadBinary();
            // WriteData();
            // ReadData();
            DirectoriesnFiles.CheckDirectoriesnFiles();
            Console.Read();
        }
    }

    class DirectoriesnFiles
    {
        public static void CheckDirectoriesnFiles()
        {
            //to create a new directory
            DirectoryInfo di = new DirectoryInfo(@"C:\Banu\Infinite\B3\SampleDir");

            if(di.Exists)
            {
                Console.WriteLine("Directory already exists..");
            }
            else
            {
                di.Create();
                Console.WriteLine("New Directory Created..");
            }

            //this is to iterate the existing directory and get all subdirectories
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Banu\Infinite\B3");
            if(dinfo.Exists)
            {
                DirectoryInfo[] dirs = dinfo.GetDirectories();
                foreach(object o in dirs)
                {
                    Console.WriteLine(o.ToString());
                }
            }
            else
            {
                Console.WriteLine("The given directory does not exists");
            }

            //getting the files in the directory, their names and size using FileInfo class
            FileInfo[] f = dinfo.GetFiles();

            foreach(FileInfo fi in f)
            {
                Console.WriteLine($"File Name : {fi.Name}, Size is {fi.Length}");
            }
        }
    }
}
