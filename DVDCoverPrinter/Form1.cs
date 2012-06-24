using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DVDCoverPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = new CoverPrint();
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = new CoverPrint();
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDialog1.Document.Print();
                
        }
    }
}
