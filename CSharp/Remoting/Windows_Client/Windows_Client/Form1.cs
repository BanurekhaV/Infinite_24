using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remote_Objects;

namespace Windows_Client
{
    public partial class Form1 : Form
    {
        Service remoteobj = new Service();
        public Form1()
        {
            InitializeComponent();
            //channel and services registration
            remoteobj = (Service)Activator.GetObject(typeof(Service),
                "http://localhost:87/RServices");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text=remoteobj.SayHello(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            label3.Text = remoteobj.HighestNumber(n1, n2).ToString();
        }
    }
}
