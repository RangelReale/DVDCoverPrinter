namespace DVDCoverPrinter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textnumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.size1 = new System.Windows.Forms.TextBox();
            this.size2 = new System.Windows.Forms.TextBox();
            this.size3 = new System.Windows.Forms.TextBox();
            this.size4 = new System.Windows.Forms.TextBox();
            this.sizenumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text 1";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(121, 16);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(300, 20);
            this.text1.TabIndex = 0;
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(121, 94);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(300, 20);
            this.text4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Text 4";
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(121, 68);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(300, 20);
            this.text3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text 3";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(121, 42);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(300, 20);
            this.text2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Text 2";
            // 
            // textnumber
            // 
            this.textnumber.Location = new System.Drawing.Point(121, 120);
            this.textnumber.Name = "textnumber";
            this.textnumber.Size = new System.Drawing.Size(300, 20);
            this.textnumber.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Number";
            // 
            // size1
            // 
            this.size1.Location = new System.Drawing.Point(434, 16);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(100, 20);
            this.size1.TabIndex = 5;
            this.size1.Text = "9";
            // 
            // size2
            // 
            this.size2.Location = new System.Drawing.Point(434, 42);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(100, 20);
            this.size2.TabIndex = 6;
            this.size2.Text = "9";
            // 
            // size3
            // 
            this.size3.Location = new System.Drawing.Point(434, 68);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(100, 20);
            this.size3.TabIndex = 7;
            this.size3.Text = "9";
            // 
            // size4
            // 
            this.size4.Location = new System.Drawing.Point(434, 94);
            this.size4.Name = "size4";
            this.size4.Size = new System.Drawing.Size(100, 20);
            this.size4.TabIndex = 8;
            this.size4.Text = "9";
            // 
            // sizenumber
            // 
            this.sizenumber.Location = new System.Drawing.Point(434, 120);
            this.sizenumber.Name = "sizenumber";
            this.sizenumber.Size = new System.Drawing.Size(100, 20);
            this.sizenumber.TabIndex = 9;
            this.sizenumber.Text = "9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 397);
            this.Controls.Add(this.sizenumber);
            this.Controls.Add(this.size4);
            this.Controls.Add(this.size3);
            this.Controls.Add(this.size2);
            this.Controls.Add(this.size1);
            this.Controls.Add(this.textnumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "DVDCoverPrinter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textnumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox size1;
        private System.Windows.Forms.TextBox size2;
        private System.Windows.Forms.TextBox size3;
        private System.Windows.Forms.TextBox size4;
        private System.Windows.Forms.TextBox sizenumber;
    }
}

