using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using Movie_list;
using System.Collections.Generic;
using Telerik.WinControls.UI;
using Telerik.WinControls;



namespace Form1{

    public class Form1 : System.Windows.Forms.Form
    {
        
        LoadMovie lm = new LoadMovie();
        Form3 fm3 = new Form3();
        Form2 fm = new Form2();
        string movie, trailer; 
 
        
        
        
        // Windows Designer variables
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private MenuItem menuItem6;
        private MenuItem menuItem5;
        private MenuItem menuItem7;
        private MenuItem menuItem8;
        private TableLayoutPanel tableLayoutPanel1;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox pictureBox1;
        private MenuItem lMovieMenu;
        private MenuItem menuItem9;
        private MenuItem menuItemAddfilter;
        private RadListBoxItem radListBoxItem5;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button5;
        private Button button6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label13;
        private RadListBox listBox1;
        private MenuItem menuItem10;
        private RadThemeManager radThemeManager1;
        private MenuItem menuItemFullscreen;
        private System.ComponentModel.IContainer components;

        public Form1()
        {          
            InitializeComponent();
            prepopulateMovieList();
             
        }   


        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.ThemeSource themeSource1 = new Telerik.WinControls.ThemeSource();
            Telerik.WinControls.ThemeSource themeSource2 = new Telerik.WinControls.ThemeSource();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.lMovieMenu = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItemAddfilter = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItemFullscreen = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new Telerik.WinControls.UI.RadListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.radListBoxItem5 = new Telerik.WinControls.UI.RadListBoxItem();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem9,
            this.menuItem5,
            this.menuItem10});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.lMovieMenu});
            this.menuItem1.Text = "&Movie Lists";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Add Lists";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // lMovieMenu
            // 
            this.lMovieMenu.Index = 1;
            this.lMovieMenu.Text = "Load Movies";
            this.lMovieMenu.Click += new System.EventHandler(this.lMovieMenu_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAddfilter});
            this.menuItem9.Text = "&Filters";
            // 
            // menuItemAddfilter
            // 
            this.menuItemAddfilter.Index = 0;
            this.menuItemAddfilter.Text = "Add Filter";
            this.menuItemAddfilter.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8,
            this.menuItemFullscreen});
            this.menuItem5.Text = "&Show";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "FanArt Background";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "Trailer";
            // 
            // menuItemFullscreen
            // 
            this.menuItemFullscreen.Checked = true;
            this.menuItemFullscreen.Index = 2;
            this.menuItemFullscreen.Text = "Full Screen";
            this.menuItemFullscreen.Click += new System.EventHandler(this.menuItemFullscreen_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 3;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4,
            this.menuItem2});
            this.menuItem10.Text = "&Program";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Help";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "About";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "Exit";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 508);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 20;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.313812F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.287086F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.92826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.620539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.897242F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.605868F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65864F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.658545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.61749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.412533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 15, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 11, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.068731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.727844F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.318823F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.08499F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.330494F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.330494F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.330494F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.336759F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.474998F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.864631F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13427F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.977489F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.019979F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 508);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 20);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.202044F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.068483F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.28803F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.43133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.36285F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.66271F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.199555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.86152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.82025F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.10322F));
            this.tableLayoutPanel2.Controls.Add(this.button5, 8, 8);
            this.tableLayoutPanel2.Controls.Add(this.button6, 9, 8);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 5, 8);
            this.tableLayoutPanel2.Controls.Add(this.label5, 6, 8);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.label7, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.label13, 4, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 371);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.15831F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.12559F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.91199F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.91199F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.91199F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.91199F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.685027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.861838F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.723677F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.797579F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(789, 137);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(591, 120);
            this.button5.Name = "button5";
            this.tableLayoutPanel2.SetRowSpan(this.button5, 2);
            this.button5.Size = new System.Drawing.Size(85, 14);
            this.button5.TabIndex = 27;
            this.button5.Text = "Play &Movie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(682, 120);
            this.button6.Name = "button6";
            this.tableLayoutPanel2.SetRowSpan(this.button6, 2);
            this.button6.Size = new System.Drawing.Size(85, 14);
            this.button6.TabIndex = 28;
            this.button6.Text = "Play &Trailer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 8);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Name = "label3";
            this.tableLayoutPanel2.SetRowSpan(this.label3, 6);
            this.label3.Size = new System.Drawing.Size(750, 92);
            this.label3.TabIndex = 22;
            this.label3.Text = "Movie Description";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "mpaa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "runtime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Genera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(273, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "imdb stars";
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(585, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 7);
            this.pictureBox1.Size = new System.Drawing.Size(157, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.listBox1, 11);
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.tableLayoutPanel1.SetRowSpan(this.listBox1, 9);
            this.listBox1.ShowItemToolTips = false;
            this.listBox1.Size = new System.Drawing.Size(574, 371);
            this.listBox1.Sorted = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            ((Telerik.WinControls.UI.RadListBoxElement)(this.listBox1.GetChildAt(0))).SortItems = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.listBox1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label9, 9);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(577, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "MOVIE TITLE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 508);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // radListBoxItem5
            // 
            this.radListBoxItem5.Name = "radListBoxItem5";
            // 
            // radThemeManager1
            // 
            themeSource1.ThemeLocation = "movieliststylesheet.xml";

            themeSource2.ThemeLocation = "movieliststylesheet.xml";
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource1,
            themeSource2});
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 508);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie List  v.1";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());

        }

        // Events
        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void menuItem4_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Movie List  v.1");
        }



        private void button1_Click(object sender, EventArgs e)
        {    
            if (movie != "")
                Process.Start(movie);            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (trailer != "")
                Process.Start(trailer);
        }


        public void lMovieMenu_Click(object sender, EventArgs e)
        {            
            lm.ShowDialog();

            //populate the listbox with movies
            foreach (KeyValuePair<string, string> movie in lm.movieCollection)
            {
                RadListBoxItem RadItm = new RadListBoxItem();
                RadItm.Text = movie.Key;
                listBox1.Items.Add(RadItm);
                
                                           
            }
        }

        public void prepopulateMovieList()
        {
            try
            {
                StreamReader sr = new StreamReader("MovieLists.txt");
                string moviepath = sr.ReadLine();

                lm.WalkDirectoryTree(moviepath);

                //populate the listbox with movies
                foreach (KeyValuePair<string, string> movie in lm.movieCollection)
                {
                    RadListBoxItem RadItm = new RadListBoxItem();
                    RadItm.Text = movie.Key;
                    listBox1.Items.Add(RadItm);
                                           
                }
            }
            catch
            { }
        }




        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            
           //// This needs some work has bugs (doesn't work if list is 1)
           //// if (fm.movieCollection.Count == 0) 
           //     if ((listBox1.Items.Count == 0)) //|| (listBox1.Text == "No Movies found for Filter"))
           // { 
           //     // this is not working "no movies" doesn't show
           //     RadListBoxItem RadItm = new RadListBoxItem();
           //     RadItm.Text = "No Movies found for Filter";
           //     listBox1.Items.Add(RadItm); 
           // }
           // else
           try
            { {
                //sets the moviename            
                RadListBoxItem item = listBox1.SelectedItem as RadListBoxItem;

                string movieName = item.Text;
                string path = lm.movieCollection[movieName];

                movie = path + "\\" + movieName;
                string fanart = path + "\\fanart.jpg";
                string poster = path + "\\folder.jpg";
                string XMLfile = path + "\\movie.nfo";

                System.IO.FileInfo[] files = null;
                System.IO.DirectoryInfo directory = new DirectoryInfo(path);

                files = directory.GetFiles("*.*");

                //grab trailer
                foreach (System.IO.FileInfo file in files)
                {
                    if (file.Name.Contains("-trailer"))
                    {
                        trailer = path + "\\" + file.Name;
                    }
                }

                //display fanart and poster
                if (File.Exists(fanart))
                panel1.BackgroundImage = Image.FromFile(fanart);
                else { panel1.BackgroundImage = null; }

                if (File.Exists(poster))
                    pictureBox1.Image = Image.FromFile(poster);
                else { pictureBox1.Image = null; }

                //parse XML
                // read movie.nfo into lables
                string zPath = path + "\\movie.nfo";
                if (File.Exists(zPath))
                {
                    StreamReader sr = new StreamReader(zPath);
                    string movieNfo = sr.ReadToEnd();

                    Match match = Regex.Match(movieNfo, "(?<=<plot>).*(?=</)");
                    label3.Text = match.Groups[0].Value;
                    //strString = match.Groups[0].Value;
                    //timer1.Enabled = true;

                    match = Regex.Match(movieNfo, "(?<=<title>).*(?=</)");
                    label9.Text = match.Groups[0].Value;

                    match = Regex.Match(movieNfo, "(?<=<mpaa>).*(?=</)");
                    label4.Text = match.Groups[0].Value;

                    match = Regex.Match(movieNfo, "(?<=<rating>).*(?=</)");
                    label13.Text = match.Groups[0].Value;

                    match = Regex.Match(movieNfo, "(?<=<year>).*(?=</)");
                    label7.Text = match.Groups[0].Value;

                    match = Regex.Match(movieNfo, "(?<=<runtime>).*(?=</)");
                    label5.Text = match.Groups[0].Value;

                    match = Regex.Match(movieNfo, "(?<=<genre>).*(?=</)");
                    label6.Text = match.Groups[0].Value;

                }
                else
                {
                    label3.Text = null;
                    label4.Text = null;
                    label5.Text = null;
                    label6.Text = null;
                    label7.Text = null;
                    label9.Text = null;
                    label13.Text = null;

                }
            }
        
             }
            catch
            { }
}
       
        private void menuItem10_Click(object sender, EventArgs e)
        {

            fm.ShowDialog();

            //clear listBox1
            listBox1.Items.Clear();

            //populate the listbox with movies
            foreach (KeyValuePair<string, string> movie in fm.movieCollection)
            {
                RadListBoxItem RadItm = new RadListBoxItem();
                RadItm.Text = movie.Key;
                listBox1.Items.Add(RadItm);
            }
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (movie != "")
                Process.Start(movie); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (trailer != "")
                Process.Start(trailer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            fm3.ShowDialog();
        }

        private void menuItemFullscreen_Click(object sender, EventArgs e)
        {
            menuItemFullscreen.Checked = !menuItemFullscreen.Checked;
            if (menuItemFullscreen.Checked) { FormBorderStyle = FormBorderStyle.Sizable; } else { FormBorderStyle = FormBorderStyle.None; }
       
        }

      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {   // sets the page up / page down keys
                
                 if (e.KeyCode == Keys.PageDown)
                    if (listBox1.SelectedIndex > (listBox1.Items.Count - 20)) { listBox1.SelectedIndex = (20 - (listBox1.Items.Count - listBox1.SelectedIndex)); }
                    else { listBox1.SelectedIndex = (listBox1.SelectedIndex + 20); }
                
                if (e.KeyCode == Keys.PageUp)
                   if (listBox1.SelectedIndex < 20) { listBox1.SelectedIndex = (listBox1.Items.Count - (20 - listBox1.SelectedIndex)); }
                   else { listBox1.SelectedIndex = (listBox1.SelectedIndex - 20); }
                
                listBox1.Refresh();
            } catch {}
        }


    }
}