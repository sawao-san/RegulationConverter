using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using ExcelIO;
using regulationConverter;

namespace ExcelIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ExcelTestButton_Click(object sender, EventArgs e)
        {
            IOExcel io = new IOExcel(@"E:\temp\Book1.xlsx");
            io.ImportExcel();
        }

        private void ImportXMLButton(object sender, EventArgs e)
        {
            IXML.XMLtoStream();
        }

        private void testAsyncButton_Click(object sender, EventArgs e)
        {
            testASYNC.ThreadTest();
        }
    }
}
