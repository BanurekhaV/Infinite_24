using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Welcome to parallel programming.");
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader= new StreamReader("LargeFile.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        //run the below event synchronously
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    label1.Text = textBox1.Text;
            
        //    label1.Visible = true;
        //    label1.Enabled = false;
        //    int z = CountCharacters();
        //    label1.Text = "Processing the file and counting, Please wait....";
        //    label1.Text = z.ToString()+ " "+ "Characters Found in the file";
        //}

        //run the below asynchronously
        private async void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;

            label1.Visible = true;
            label1.Enabled = false;
            Task<int> counttask = new Task<int>(CountCharacters);
            counttask.Start();  // task starts running the function
            label1.Text = "Processing the file and counting, Please wait....";
            textBox1.Text = "Waiting for the Task to complete.";
            int z = await counttask;
            label1.Text = z.ToString() + " " + "Characters Found in the file";
        }

    }
}
