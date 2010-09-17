using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movie_list
{
    public partial class Form3 : Form
    {
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ImageList imageList1;
        private ListBox listBox1;
        private IContainer components;
        public Form3()
        {
            InitializeComponent();
        }

             

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = folderBrowserDialog1.SelectedPath;
            }


        }

               private void button7_Click_1(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("MovieLists.txt");

            foreach (object item in listBox1.Items)

                sw.WriteLine(item.ToString());

            sw.Close();

            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            while (listBox1.SelectedIndices.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
