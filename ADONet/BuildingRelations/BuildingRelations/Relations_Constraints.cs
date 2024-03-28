using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BuildingRelations
{
    class Relations_Constraints
    {
        public static void Main()
        {
            DataSet ds = new DataSet();

            DataTable ClassTable = ds.Tables.Add("OurClass");
            ClassTable.Columns.Add("CID", typeof(int));
            ClassTable.Columns.Add("ClassName", typeof(string));

            DataTable StudentTable = ds.Tables.Add("Students");
            StudentTable.Columns.Add("ClassID", typeof(int));
            StudentTable.Columns.Add("SID", typeof(int));
            StudentTable.Columns.Add("SName", typeof(string));

            //initialize pk constraint
            ClassTable.PrimaryKey = new DataColumn[] { ClassTable.Columns["CID"] };
            ds.Relations.Add("classstudent", ClassTable.Columns["CID"], StudentTable.Columns["ClassID"]);

            DataColumn dcclassid = ds.Tables["OurClass"].Columns["CID"];
            DataColumn dcstudentid = ds.Tables["Students"].Columns["ClassID"];

            ForeignKeyConstraint fkc = new ForeignKeyConstraint("csfk", dcclassid, dcstudentid);

            //set the rule of constraint
            fkc.DeleteRule = Rule.SetNull;
            fkc.UpdateRule = Rule.Cascade;

            //add a unique constraint
            UniqueConstraint nameconst = new UniqueConstraint(new DataColumn[] { ClassTable.Columns["ClassName"] });
                
            //  ,StudentTable.Columns["SName"]});

            ds.Tables["OurClass"].Constraints.Add(nameconst);

            DataRow dr1 = ds.Tables["OurClass"].NewRow();

            dr1["CID"] = 1;
            dr1["ClassName"] = "Fifth";

            ClassTable.Rows.Add(dr1);

            dr1 = ds.Tables["OurClass"].NewRow();

            dr1["CID"] = 4;
            dr1["ClassName"] = null;

            ClassTable.Rows.Add(dr1);

            dr1 = ds.Tables["OurClass"].NewRow();

            dr1["CID"] = 1;    //primary key violation
            dr1["ClassName"] = null;  //unique constraint violation

            ClassTable.Rows.Add(dr1);


            DataRow dr2 = ds.Tables["Students"].NewRow();

            dr2["ClassID"] = 3;   //foreign key violation
            dr2["SID"] = 1;
            dr2["SName"] = "Infinite";

            StudentTable.Rows.Add(dr2);

            Console.Read();
        }
    }
}
