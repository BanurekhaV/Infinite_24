using System;
using System.IO;
using System.Xml.Serialization;

namespace Dotnet_Day11
{
    [Serializable]
    public class Books
    {
        public string authorName;
        public string bookName;
        public int yearPublished;

        public Books() { }
        public Books(string aname,string bname, int yp)
        {
            this.authorName = aname;
            this.bookName = bname;
            this.yearPublished = yp;
        }
    }
    class XmlSerialization
    {
        static void Main()
        {
            Books book = new Books("Amish Tripathi", "Seetha- the warrior of Mithila", 2010);

            //serialize to an xml document

            XmlSerializer xmlszr = new XmlSerializer(typeof(Books));

            StreamWriter writer = new StreamWriter("Books.xml");

            xmlszr.Serialize(writer.BaseStream, book);
            writer.Close();

            //deserializing
            Books b1 = new Books();
            XmlSerializer xl = new XmlSerializer(typeof(Books));
            StreamReader reader = new StreamReader("Books.xml");
            b1= (Books)xl.Deserialize(reader.BaseStream);
            reader.Close();
            Console.WriteLine($"{b1.authorName}, {b1.bookName}, {b1.yearPublished}");
            Console.Read();
        }
    }
}
