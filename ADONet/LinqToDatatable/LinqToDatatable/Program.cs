using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDatatable
{
    class DatatablesEg
    {
        public static DataTable GetTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Product", typeof(string));
            dt.Rows.Add(1, "Sports Shoes");
            dt.Rows.Add(2, "Memory Stick");
            dt.Rows.Add(3, "Gucci bag");
            dt.Rows.Add(4, "Perfumes");
            return dt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtreturn = DatatablesEg.GetTable();

            //method syntax
            var result = dtreturn.AsEnumerable().Where(x => x.Field<int>("Id") == 2).FirstOrDefault();
           if(result!=null)
            Console.WriteLine(result["Product"]);
           else
                Console.WriteLine("No product found");

            //query syntax
            Console.WriteLine("-----Query Expression-----");
            var datarow = (from prod in dtreturn.AsEnumerable()
                           where prod.Field<int>("Id") == 3
                           select prod).FirstOrDefault();

            if(datarow!=null)
            Console.WriteLine(datarow["Id"]+ " "+ datarow["Product"]);
            else
                Console.WriteLine("No matching data found");

            Console.WriteLine("-------data back from a table------");
            //to convert the IEnumerable<DataRow> to a data table

            var dt = dtreturn.AsEnumerable().Where(x => x.Field<int>("Id") > 1);
            DataTable tableagain = dt.CopyToDataTable<DataRow>();

            foreach(DataRow dr in tableagain.Rows)
            {
                foreach(DataColumn dc in tableagain.Columns)
                {
                    Console.Write(dr[dc]+ " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
