namespace Movie_list
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
       // private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(354, 121);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 22;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(373, 137);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 26);
            this.button7.TabIndex = 21;
            this.button7.Text = "Done";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(373, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 41);
            this.button6.TabIndex = 20;
            this.button6.Text = "Set as Default";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(373, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 40);
            this.button5.TabIndex = 19;
            this.button5.Text = "Remove from List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Add to List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "c:\\movies";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 179);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.ListBox listBox1;
        //private System.Windows.Forms.Button button7;
        //private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        //private System.Windows.Forms.Button button6;
        //private System.Windows.Forms.Button button5;
        //private System.Windows.Forms.ImageList imageList1;
        //private System.Windows.Forms.Button button4;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.TextBox textBox1;
    }
}