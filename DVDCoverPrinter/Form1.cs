using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

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
            printPreviewDialog1.Document = createDocument();
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = createDocument();
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDialog1.Document.Print();
                
        }

        private PrintDocument createDocument()
        {
            CoverPrint result = new CoverPrint();
            if (text4.Text != "") { result.text4 = text4.Text; result.size4 = float.Parse(size4.Text); result.numbercolor = 3; }
            if (text3.Text != "") { result.text3 = text3.Text; result.size3 = float.Parse(size3.Text); result.numbercolor = 2; }
            if (text2.Text != "") { result.text2 = text2.Text; result.size2 = float.Parse(size2.Text); result.numbercolor = 1; }
            if (text1.Text != "") { result.text1 = text1.Text; result.size1 = float.Parse(size1.Text); result.numbercolor = 0; }
            if (textnumber.Text != "") { result.textnumber = textnumber.Text; result.sizenumber = float.Parse(sizenumber.Text); }
            return result;
        }
    }
}
