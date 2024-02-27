using System;


namespace Dotnet_Day4
{
    public class Access_Specifier_Eg
    {
       private int privatedata;  // private by default
       public int publicdata;
        internal int internaldata;
        protected int protecteddata;

        internal protected int intprocdata;
      // or   protected internal int procinterdata;
        public void testprivate()
        {
            privatedata = 5;
        }
    }

    class Driver : Access_Specifier_Eg
    {
        public void TestingAccess()
        {
            Access_Specifier_Eg ase = new Access_Specifier_Eg();
            ase.publicdata = 5;
            ase.testprivate();
            ase.internaldata = 20;
            ase.intprocdata = 30;

            Driver d = new Driver();
            d.publicdata = 1;
            d.internaldata = 2;
            d.protecteddata = 3;
            d.intprocdata = 4;
        }
    }

    class Test
    {
        public void tester()
        {
            Access_Specifier_Eg a1 = new Access_Specifier_Eg();
            a1.internaldata = 11;
            a1.intprocdata = 12;
                }
    }
}
