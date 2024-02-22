using System;


namespace FirstConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!..Welcome to C#");
            Console.WriteLine("Enter Your First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Your FirstName is : " + fname + "and your LastName is : " + lname); //concatenation
            Console.WriteLine("Your FirstName is :{0} and your LastName is :{1}", fname, lname); //place holders

            //create an object of the Program class and call its function
            Program program=new Program();
            program.type_Conversions();
            Console.Read();
        }

        //lets write another function to understand data conversions
        public void type_Conversions()
        {
            int i = 100;
            float f;
            Console.WriteLine(i);
            f = i;  //implicit conversion
            Console.WriteLine(f);
            f = 12345.56f;
            int x =(int) f; //explicit using cast operator
            Console.WriteLine(x);
           // x = Convert.ToInt32(f); //using conversion function
           Console.WriteLine(x);

            //if we change the value of f to a bigger number, then we see that 
            //casting operator displays the max capacity of an integer data type
            //where as the conversion function throws an exception of overflow

            //now let us use parse and tryparse() to understand string conversions

            string str = "100gms";
            x = int.Parse(str);
            Console.WriteLine("Value of X after parsing is " + x);

        }
    }
}
