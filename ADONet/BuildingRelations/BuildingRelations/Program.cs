using System;
using System.Data;

namespace BuildingRelations
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. create an in-memory cache(dataset)
            DataSet dsEmployment = new DataSet("Employment");

            //2. add first data table

            DataTable dtEmployees = new DataTable("Employees");

            //3. define columns to the datatable
            DataColumn[] dcEmployees = new DataColumn[4];
            //assign data types and size to the columns
            dcEmployees[0] = new DataColumn("EmpCode", System.Type.GetType("System.Int32"));
            dcEmployees[1] = new DataColumn("EmpName", System.Type.GetType("System.String"));
            dcEmployees[2] = new DataColumn("EmpDept", System.Type.GetType("System.String"));
            dcEmployees[3] = new DataColumn("EmpStatusID", System.Type.GetType("System.Int32"));

            //4. Add the above columns to the datatable
            dtEmployees.Columns.Add(dcEmployees[0]);
            dtEmployees.Columns.Add(dcEmployees[1]);
            dtEmployees.Columns.Add(dcEmployees[2]);
            dtEmployees.Columns.Add(dcEmployees[3]);

            //5. now let us add a row with data
            DataRow drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "1";
            drEmpRows["EmpName"] = "Aishwarya";
            drEmpRows["EmpDept"] = "IT";
            drEmpRows["EmpStatusID"] = "1";

            //6. add the above row to rows collection of the table
            dtEmployees.Rows.Add(drEmpRows);

            //repeat steps 5 and 6 for as many rows we want to add
            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "2";
            drEmpRows["EmpName"] = "Trisha";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusID"] = "3";
            
            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "3";
            drEmpRows["EmpName"] = "Vikram";
            drEmpRows["EmpDept"] = "Accounts";
            drEmpRows["EmpStatusID"] = "1";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "4";
            drEmpRows["EmpName"] = "Karthik";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusID"] = "3";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "5";
            drEmpRows["EmpName"] = "Ravi";
            drEmpRows["EmpDept"] = "Operations";
            drEmpRows["EmpStatusID"] = "4";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "6";
            drEmpRows["EmpName"] = "Shoba";
            drEmpRows["EmpDept"] = "Admin";
            drEmpRows["EmpStatusID"] = "4";

            dtEmployees.Rows.Add(drEmpRows);

            //7. Create another table in the dataset

            DataTable dtEmpStatus = new DataTable("EmployeeStatus");

            //8. columns for table 2
            DataColumn[] dcStatus = new DataColumn[2];
            dcStatus[0] = new DataColumn("EmpStatusID", System.Type.GetType("System.Int32"));
            dcStatus[1] = new DataColumn("EmpStatus", System.Type.GetType("System.String"));

            dtEmpStatus.Columns.Add(dcStatus[0]);
            dtEmpStatus.Columns.Add(dcStatus[1]);

            //9. rows for table 2

            DataRow drstatus = dtEmpStatus.NewRow();

            drstatus["EmpStatusID"] = "1";
            drstatus["EmpStatus"] = "Full Time";

            dtEmpStatus.Rows.Add(drstatus);

            drstatus = dtEmpStatus.NewRow();

            drstatus["EmpStatusID"] = "2";
            drstatus["EmpStatus"] = "Part Time";

            dtEmpStatus.Rows.Add(drstatus);

            drstatus = dtEmpStatus.NewRow();

            drstatus["EmpStatusID"] = "3";
            drstatus["EmpStatus"] = "Contract";

            dtEmpStatus.Rows.Add(drstatus);

            drstatus = dtEmpStatus.NewRow();

            drstatus["EmpStatusID"] = "4";
            drstatus["EmpStatus"] = "Intern";

            dtEmpStatus.Rows.Add(drstatus);

            //10. add both datatables to the dataset

            dsEmployment.Tables.Add(dtEmployees);
            dsEmployment.Tables.Add(dtEmpStatus);

            //11. set up the relationsip between 2 data tables in the dataset
            // 11.1 by creating primary key foreign key
            DataColumn parent = dsEmployment.Tables["EmployeeStatus"].Columns["EmpStatusID"];
            DataColumn child = dsEmployment.Tables["Employees"].Columns["EmpStatusID"];
            
            //11.2 setting the realtion between parent and child
            DataRelation emprel = new DataRelation("EmpStatusRelation", parent, child);

            //11.3 adding the relation to the dataset
            dsEmployment.Relations.Add(emprel);


            //12. display data as per the relationship
            Console.WriteLine("==================================================");
            Console.WriteLine("Status ID         |      Employee Status  ");
            Console.WriteLine("------------------------------------------------------------------");

            foreach(DataRow row in dsEmployment.Tables["EmployeeStatus"].Rows)

            Console.WriteLine("{0}      |      {1}", row["EmpStatusID"], row["EmpStatus"]);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("EmpCode \t    |   EmpName\t     | Department\t     | Employee Status");
            Console.WriteLine("------------------------------------------------------------------");
             
            foreach(DataRow row in dsEmployment.Tables["Employees"].Rows)
            {
                   Console.WriteLine("{0}  \t    |   {1}  \t     |   {2} \t     |   {3}", row["EmpCode"],
                    row["EmpName"], row["EmpDept"], row["EmpStatusID"]); // currentrow["EmpStatus"]);   //row["EmpStatusID"]);

                //if we want the types of employment we can use as below

                //Console.WriteLine("------------using the Staus Name rather Than ID---------");
                // int irow = int.Parse(row["EmpStatusID"].ToString());

                // DataRow currentrow = dsEmployment.Tables["EmployeeStatus"].Rows[irow - 1];
                //Console.WriteLine("{0}  \t    |   {1}  \t     |   {2} \t     |   {3}", row["EmpCode"],
                //    row["EmpName"], row["EmpDept"], currentrow["EmpStatus"]);   
            }

            Console.WriteLine("======================================================");
            Console.Read();
        }
    }
}
