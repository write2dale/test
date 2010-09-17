using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Form1;

namespace Movie_list
{
    public partial class LoadMovie : Form
    {        
        public string moviestoload;
        public Dictionary<string, string> movieCollection = new Dictionary<string, string>();       
        
        public LoadMovie()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                moviestoload = textBox1.Text;
            }                    
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //save movie location to a file for future use.
            if (textBox1.Text != "")
            {
                StreamWriter sr = new StreamWriter("movieDBsettings.txt");
                sr.Write(textBox1.Text);
                sr.Close();

                //run through directories looking for movies
                WalkDirectoryTree(textBox1.Text);                
                
                this.Hide();
            }            
        }

        public void WalkDirectoryTree(string dirPath)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;
            System.IO.DirectoryInfo directory = new DirectoryInfo(dirPath);

            // First, process all the files directly under this folder           
            files = directory.GetFiles("*.*");            
           
            if (files != null)
            {
                foreach (System.IO.FileInfo file in files)
                {
                    //check to see if movie file, then add to movielist                    
                    if (file.Length > 400000000 && !movieCollection.ContainsKey(file.Name)) 
                    {
                        movieCollection.Add(file.Name, file.DirectoryName);
                    }                                    

                }

                // Now find all the subdirectories under this directory.
                subDirs = directory.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTree(dirInfo.FullName);
                }
            }
        }

        private void LoadMovie_Load(object sender, EventArgs e)
        {

        }

            

        
    }
}
