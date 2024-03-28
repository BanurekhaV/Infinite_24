using System;
using System.Data;
using System.Xml;

namespace XMLOperations
{
    class Program
    {
        static DataSet ds = new DataSet("DS");
        static void Main(string[] args)
        {
            // XmlWriter();
            //XmlReader();
          //  XmlSchemaWriter();
            XmlSchemaReader();
            Console.Read();
        }

        static void creatingContent()
        {           
            ds.Namespace = "StdNameSpace";
            DataTable stdtable = new DataTable("Student");
            DataColumn col1 = new DataColumn("Name");
            DataColumn col2 = new DataColumn("Address");

            stdtable.Columns.Add(col1);
            stdtable.Columns.Add(col2);

            ds.Tables.Add(stdtable);

            DataRow dr = stdtable.NewRow();

            dr["Name"] = "Surya";
            dr["Address"] = "Bhopal";

            stdtable.Rows.Add(dr);

            dr = stdtable.NewRow();

            dr["Name"] = "Chitra";
            dr["Address"] = "Chennai";

            stdtable.Rows.Add(dr);

            dr = stdtable.NewRow();

            dr["Name"] = "Arpitha";
            dr["Address"] = "Ranchi";

            stdtable.Rows.Add(dr);

            dr = stdtable.NewRow();

            dr["Name"] = "Rakshitha";
            dr["Address"] = "Indore";

            stdtable.Rows.Add(dr);

            ds.AcceptChanges();
        }
        static void XmlWriter()
        {
            try
            {
                creatingContent();

                //create stream writer to write the dataset data
                System.IO.StreamWriter sw = new System.IO.StreamWriter("studentinfo.xml");
                ds.WriteXml(sw); // writes the dataset data in xml format
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }

        public static void XmlReader()
        {            
            DataSet ds = new DataSet();
            ds.ReadXml("studentinfo.xml"); //fills the dataset with data

            foreach(DataTable t in ds.Tables)
            {
                Console.WriteLine(t);
                for (int i = 0; i < t.Columns.Count; i++)
                {
                    Console.Write("\t" + "\t" + t.Columns[i].ColumnName);
                    //Console.WriteLine();
                   
                }
                
                    foreach(var row in t.AsEnumerable())
                    {
                        for(int j=0; j < t.Columns.Count;j++)
                        {
                            Console.Write("\t" + "\t" + row[j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
          
         public static void XmlSchemaWriter()
         {
            creatingContent();
            ds.WriteXmlSchema("studentSchema");

            //using xml text writer
           // XmlTextWriter writer = new XmlTextWriter(Console.Out);
           // ds.WriteXmlSchema(writer);
         }

         public static void XmlSchemaReader()
        {
            ds = new DataSet("Mydata");
            System.IO.StreamReader xmlreader = new System.IO.StreamReader("studentSchema");
            ds.ReadXmlSchema(xmlreader);

            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(writer);
        }
    }
    }

