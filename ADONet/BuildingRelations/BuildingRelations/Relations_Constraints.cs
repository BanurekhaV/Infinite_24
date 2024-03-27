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
            ds.Relations.Add("classstudent", StudentTable.Columns["ClassID"], ClassTable.Columns["CID"]);

            DataColumn dcclassid = ds.Tables["OurClass"].Columns["CID"];
            DataColumn dcstudentid = ds.Tables["Students"].Columns["SID"];

            ForeignKeyConstraint fkc = new ForeignKeyConstraint("csfk", dcclassid, dcstudentid);

            //set the rule of constraint
            fkc.DeleteRule = Rule.SetNull;
            fkc.UpdateRule = Rule.Cascade;

            //add a unique constraint
            UniqueConstraint nameconst = new UniqueConstraint(new DataColumn[] {ClassTable.Columns["ClassName"],
            StudentTable.Columns["SName"]});

            ds.Tables["OurClass"].Constraints.Add(nameconst);
        }
    }
}
