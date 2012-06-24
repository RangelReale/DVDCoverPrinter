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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
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
            this.button2.TabIndex = 1;
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
            this.text1.Size = new System.Drawing.Size(413, 20);
            this.text1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 20);
            this.textBox1.TabIndex = 5;
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Location = new System.Drawing.Point(36, 97);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(37, 13);
            this.text4.TabIndex = 4;
            this.text4.Text = "Text 4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(413, 20);
            this.textBox2.TabIndex = 7;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Location = new System.Drawing.Point(36, 71);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(37, 13);
            this.text3.TabIndex = 6;
            this.text3.Text = "Text 3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(413, 20);
            this.textBox3.TabIndex = 9;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(36, 45);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(37, 13);
            this.text2.TabIndex = 8;
            this.text2.Text = "Text 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 397);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label text2;
    }
}

