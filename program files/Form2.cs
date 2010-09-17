using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Movie_list;
using Form1;
using Telerik.WinControls.UI;
using Telerik.WinControls;



namespace Movie_list
{
    public partial class Form2 : Form
    {
        public string lb15, lb16, genrz = "";        
        public string moviestoload;
        public Dictionary<string, string> movieCollection = new Dictionary<string, string>();
        System.IO.FileInfo[] filez = null;
        public string dirPatz;
        public int Yearz = 0;
        public int selectedYearz = 0;
        public int Runtimez = 0;
        public string yearz = "";




        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //clear dictionary
                movieCollection.Clear();
                //clear listBox1
                //listBox2.Items.Clear();

                StreamReader sr = new StreamReader("MovieLists.txt");
                string moviepath = sr.ReadLine();

                WalkDirectoryTree(moviepath);

                                //populate the listbox with movies
                //foreach (KeyValuePair<string, string> movie in movieCollection)
                //{
                //    RadListBoxItem RadItm = new RadListBoxItem();
                //    RadItm.Text = movie.Key;
                //    listBox2.Items.Add(RadItm);                    
                //}
            }
            catch
            { }

             this.Hide();
        }

        public void AddtoDict()
        {

            foreach (System.IO.FileInfo file in filez)
            {
                //check to see if movie file, then add to movielist                    
                if (file.Length > 400000000 && !movieCollection.ContainsKey(file.Name))
                {
                    //add movie filename to dictionary? 
                    movieCollection.Add(file.Name, file.DirectoryName);
                }
            }
        }

        public void ParseXmlnfo()
        {
            ////parse XML in this directory
            //// read movie.nfo into labels
            String movieNfo = "";
            String iPath = "";
            label15.Text = "";
            string label16 = "";
            genrz = "";
            lb15 = "";
            lb16 = "0";
            string yearz = "";
            Yearz = 0;
            string runtimez = "";
            Runtimez = 0;
            

            iPath = (dirPatz) + "\\movie.nfo";
            if (File.Exists(iPath))
            {
                StreamReader sr = new StreamReader(iPath);
                movieNfo = sr.ReadToEnd();

                Match match = Regex.Match(movieNfo, "(?<=<mpaa>).*(?=</)");
                label15.Text = match.Groups[0].Value;
                lb15 = label15.Text;

                ////strString = match.Groups[0].Value;
                ////timer1.Enabled = true;

                //match = Regex.Match(movieNfo, "(?<=<title>).*(?=</)");
                //label9.Text = match.Groups[0].Value;

                //match = Regex.Match(movieNfo, "(?<=<plot>).*(?=</)");
                //label3.Text = match.Groups[0].Value;

                match = Regex.Match(movieNfo, "(?<=<rating>).*(?=</)");
                label16 = match.Groups[0].Value;
                lb16 = label16;

                match = Regex.Match(movieNfo, "(?<=<year>).*(?=</)");
                yearz = match.Groups[0].Value;
                try { Yearz = Convert.ToInt32(yearz); } catch {}

                match = Regex.Match(movieNfo, "(?<=<runtime>).*(?=</)");
                runtimez = match.Groups[0].Value;
                try { Runtimez = Convert.ToInt32(runtimez); } catch { }

                match = Regex.Match(movieNfo, "(?<=<genre>).*(?=</)");
                genrz = match.Groups[0].Value;
                if (genrz == "") {genrz = "blank";}

                sr.Close();
                sr.Dispose();

                //(run) filter - check movie details against checked filters
                FilterList();

            }



        }

        public void FilterList()
        {
            // filter - check movie details against checked filters
            int mpaack = 0;
            int imdbck = 0;
            int genreck = 0;
            int yearsck = 0;
            

            // check movie mpaa 
            if (buttonAllmpaa.Checked) { mpaack = 1; }
            else if (lb15 == "G") { if (buttonG.Checked) { mpaack = 1; } }
            else if (lb15 == "PG") { if (buttonPg.Checked) { mpaack = 1; } }
            else if (lb15 == "PG-13") { if (buttonPg13.Checked) { mpaack = 1; } }
            else if (lb15 == "R") { if (buttonR.Checked) { mpaack = 1; } }
            else if (lb15 == "NC-17") { if (buttonNc17.Checked) { mpaack = 1; } }
            else if (lb15 == "NR") { if (buttonNr.Checked) { mpaack = 1; } }
            else if (lb15 == "") { if (buttonUnknownmpaa.Checked) { mpaack = 1; } }
            
            // check movie imdb
            if (buttonAllimdb.Checked) { imdbck = 1; }
            else if (lb16.Contains("1.") || lb16.Contains("2.") || lb16.Contains("3.")) { if (buttonImdb3.Checked) { imdbck = 1; } }
            else if (lb16.Contains("4.") || lb16.Contains("5.")) { if (buttonImdb5.Checked) { imdbck = 1; } }
            else if (lb16.Contains("6.")) { if (buttonImdb6.Checked) { imdbck = 1; } }
            else if (lb16.Contains("7.")) { if (buttonImdb7.Checked) { imdbck = 1; } }
            else if (lb16.Contains("8.")) { if (buttonImdb8.Checked) { imdbck = 1; } }
            else if (lb16.Contains("9.")) { if (buttonImdb9.Checked) { imdbck = 1; } }
            else if (lb16.Contains("10.")) { if (buttonImdb10.Checked) { imdbck = 1; } }
            else if (lb16.Equals("")) { if (buttonUnknownimdb.Checked) {imdbck = 1; }}
            
            // check movie genre
            if (comboBox2.Text == "Unknown") { comboBox2.Text = "blank"; }
            if (comboBox3.Text == "Unknown") { comboBox3.Text = "blank"; }
            if (comboBox4.Text == "Unknown") { comboBox4.Text = "blank"; }
            if ((comboBox2.SelectedItem == null) && (comboBox3.SelectedItem == null ) && (comboBox4.SelectedItem == null) ) { genreck = 1; }
            if (genrz == comboBox2.Text || genrz == comboBox3.Text || genrz == comboBox4.Text) { genreck = 1; }
            if (comboBox2.Text == "Others" || comboBox3.Text == "Others" || comboBox4.Text == "Others") {if ((genrz != "blank") && (genrz != "Comedy") && (genrz != "Drama") && (genrz != "Action") && (genrz != "Adventure") && (genrz != "Animation") && (genrz != "Biography") && (genrz != "Crime") && (genrz != "Mystery") && (genrz != "Western")) { genreck = 1; }}
            
            // check movie year
            try { selectedYearz = Convert.ToInt32(textBox5.Text); } catch {}
            if (Yearz == selectedYearz) { yearsck = 1; }
            string cmb1t = comboBox1.Text;
            if (yearz.Contains(cmb1t)) { yearsck = 1; }
            
            
            //add movies that meet filter selections
            if (mpaack == 1 && imdbck == 1 && genreck == 1 && yearsck == 1 ) { AddtoDict(); } 

        }

        public void WalkDirectoryTree(string dirPath)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;
            System.IO.DirectoryInfo directory = new DirectoryInfo(dirPath);

            // First, process all the files directly under this folder           
            files = directory.GetFiles("*.*");
            filez = files;
            dirPatz = dirPath;


            if (files != null)
            {
                //(run) parse XML in this directory
                ParseXmlnfo();
                
            }
            // Now find all the subdirectories under this directory.
            subDirs = directory.GetDirectories();

            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                // Resursive call for each subdirectory.
                WalkDirectoryTree(dirInfo.FullName);
            }
        }




        private void buttonImdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonImdb3.Checked) { buttonAllimdb.Checked = false; }
            else if ((buttonImdb5.Checked == false) && (buttonImdb6.Checked == false) && (buttonImdb7.Checked == false) && (buttonImdb8.Checked == false) && (buttonImdb9.Checked == false) && (buttonImdb10.Checked == false) && (buttonUnknownimdb.Checked == false)) { buttonAllimdb.Checked = true; }
        }

        private void buttonImdb5_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonImdb5.Checked) { buttonAllimdb.Checked = false; }
            else if ((buttonImdb3.Checked == false) && (buttonImdb6.Checked == false) && (buttonImdb7.Checked == false) && (buttonImdb8.Checked == false) && (buttonImdb9.Checked == false) && (buttonImdb10.Checked == false) && (buttonUnknownimdb.Checked == false)) { buttonAllimdb.Checked = true; }
       
        }

        private void buttonImdb6_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonImdb6.Checked) { buttonAllimdb.Checked = false; }
            else if ((buttonImdb3.Checked == false) && (buttonImdb5.Checked == false) && (buttonImdb7.Checked == false) && (buttonImdb8.Checked == false) && (buttonImdb9.Checked == false) && (buttonImdb10.Checked == false) && (buttonUnknownimdb.Checked == false)) { buttonAllimdb.Checked = true; }
       
        }

        private void buttonImdb7_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonImdb7.Checked) { buttonAllimdb.Checked = false; }
            else if ((buttonImdb5.Checked == false) && (buttonImdb6.Checked == false) && (buttonImdb3.Checked == false) && (buttonImdb8.Checked == false) && (buttonImdb9.Checked == false) && (buttonImdb10.Checked == false) && (buttonUnknownimdb.Checked == false)) { buttonAllimdb.Checked = true; }
       
        }

        private void buttonImdb8_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonImdb8.Checked) { buttonAllimdb.Checked = false; }
            else if ((buttonImdb5.Checked == false) && (buttonImdb6.Checked == false) && (buttonImdb7.Checked == false) && (buttonImdb3.Checked == false) && (buttonImdb9.Checked == false) && (buttonImdb10.Checked == false) && (buttonUnknownimdb.Checked == false)) { buttonAllimdb.Checked = true; }
       
        }

        private void buttonImdb9_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonImdb9.Checked) { buttonAllimdb.Checked = false; }
            else if ((buttonImdb5.Checked == false) && (buttonImdb6.Checked == false) && (buttonImdb7.Checked == false) && (buttonImdb8.Checked == false) && (buttonImdb3.Checked == false) && (buttonImdb10.Checked == false) && (buttonUnknownimdb.Checked == false)) { buttonAllimdb.Checked = true; }
       
        }

        private void buttonImdb10_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonImdb10.Checked) { buttonAllimdb.Checked = false; }
            else if ((buttonImdb5.Checked == false) && (buttonImdb6.Checked == false) && (buttonImdb7.Checked == false) && (buttonImdb8.Checked == false) && (buttonImdb9.Checked == false) && (buttonImdb3.Checked == false) && (buttonUnknownimdb.Checked == false)) { buttonAllimdb.Checked = true; }
       
        }

        private void buttonUnknownimdb_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonUnknownimdb.Checked) { buttonAllimdb.Checked = false; }
            else if ((buttonImdb5.Checked == false) && (buttonImdb6.Checked == false) && (buttonImdb7.Checked == false) && (buttonImdb8.Checked == false) && (buttonImdb9.Checked == false) && (buttonImdb3.Checked == false) && (buttonImdb10.Checked == false)) { buttonAllimdb.Checked = true; }
       
        }

        private void buttonAllimdb_MouseDown(object sender, MouseEventArgs e)
        {

            if (buttonAllimdb.Checked) { buttonAllimdb.Checked = false; }
       
        }
       
        private void buttonAllimdb_CheckedChanged(object sender, EventArgs e)
        {

            if (buttonAllimdb.Checked) { buttonImdb3.Checked = false; buttonImdb5.Checked = false; buttonImdb6.Checked = false; buttonImdb7.Checked = false; buttonImdb8.Checked = false; buttonImdb9.Checked = false; buttonImdb10.Checked = false; buttonUnknownimdb.Checked = false; }
            
        }


        private void buttonAllmpaa_MouseDown(object sender, MouseEventArgs e)
        {
            if (buttonAllmpaa.Checked) { buttonAllmpaa.Checked = false; }
        }

        private void buttonAllmpaa_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonAllmpaa.Checked) { buttonG.Checked = false; buttonPg.Checked = false; buttonPg13.Checked = false; buttonR.Checked = false; buttonNc17.Checked = false; buttonNr.Checked = false; buttonUnknownmpaa.Checked = false; }
            
        }

        private void buttonG_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonG.Checked) { buttonAllmpaa.Checked = false; }
            else if ((buttonPg.Checked == false) && (buttonPg13.Checked == false) && (buttonR.Checked == false) && (buttonNc17.Checked == false) && (buttonNr.Checked == false) && (buttonUnknownmpaa.Checked == false)) { buttonAllmpaa.Checked = true; }
        
        }

        private void buttonPg_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonPg.Checked) { buttonAllmpaa.Checked = false; }
            else if ((buttonG.Checked == false) && (buttonPg13.Checked == false) && (buttonR.Checked == false) && (buttonNc17.Checked == false) && (buttonNr.Checked == false) && (buttonUnknownmpaa.Checked == false)) { buttonAllmpaa.Checked = true; }
        
        }

        private void buttonPg13_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonPg13.Checked) { buttonAllmpaa.Checked = false; }
            else if ((buttonPg.Checked == false) && (buttonG.Checked == false) && (buttonR.Checked == false) && (buttonNc17.Checked == false) && (buttonNr.Checked == false) && (buttonUnknownmpaa.Checked == false)) { buttonAllmpaa.Checked = true; }
        
        }

        private void buttonR_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonR.Checked) { buttonAllmpaa.Checked = false; }
            else if ((buttonPg.Checked == false) && (buttonPg13.Checked == false) && (buttonG.Checked == false) && (buttonNc17.Checked == false) && (buttonNr.Checked == false) && (buttonUnknownmpaa.Checked == false)) { buttonAllmpaa.Checked = true; }
        
        }

        private void buttonNc17_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonNc17.Checked) { buttonAllmpaa.Checked = false; }
            else if ((buttonPg.Checked == false) && (buttonPg13.Checked == false) && (buttonR.Checked == false) && (buttonG.Checked == false) && (buttonNr.Checked == false) && (buttonUnknownmpaa.Checked == false)) { buttonAllmpaa.Checked = true; }
        
        }

        private void buttonNr_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonNr.Checked) { buttonAllmpaa.Checked = false; }
            else if ((buttonPg.Checked == false) && (buttonPg13.Checked == false) && (buttonR.Checked == false) && (buttonNc17.Checked == false) && (buttonG.Checked == false) && (buttonUnknownmpaa.Checked == false)) { buttonAllmpaa.Checked = true; }
        
        }

        private void buttonUnknown_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonUnknownmpaa.Checked) { buttonAllmpaa.Checked = false; }
            else if ((buttonPg.Checked == false) && (buttonPg13.Checked == false) && (buttonR.Checked == false) && (buttonNc17.Checked == false) && (buttonNr.Checked == false) && (buttonG.Checked == false)) { buttonAllmpaa.Checked = true; }
        
        }


        private void buttonAllgenres_MouseDown(object sender, MouseEventArgs e)
        {
            if (buttonAllgenres.Checked) { buttonAllgenres.Checked = false; }
        }

        private void buttonAllgenres_CheckedChanged(object sender, EventArgs e)
        {
             if (buttonAllgenres.Checked) { comboBox2.SelectedItem = null; comboBox3.SelectedItem = null; comboBox4.SelectedItem = null; }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > 0) { buttonAllgenres.Checked = false; }
            else if ((comboBox3.SelectedIndex < 1) && (comboBox4.SelectedIndex < 1)) { buttonAllgenres.Checked = true; }
        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > 0) { buttonAllgenres.Checked = false; }
            else if ((comboBox2.SelectedIndex < 1) && (comboBox4.SelectedIndex < 1)) { buttonAllgenres.Checked = true; }
        
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex > 0) { buttonAllgenres.Checked = false; }
            else if ((comboBox2.SelectedIndex < 1) && (comboBox3.SelectedIndex < 1)) { buttonAllgenres.Checked = true; }
        
        }

        

        

        }





    }


