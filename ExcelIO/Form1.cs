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
        public static string ExcelFilePath;
        public static string XMLFilePath;

        public Form1()
        {
            InitializeComponent();
            openExcelFileDialog.InitialDirectory = @"E:\temp";
            openExcelFileDialog.FileName = "";
            openExcelFileDialog.Filter = "Excelファイル(*.xlsx)|*.xlsx;|すべてのファイル(*.*)|*.*";

            openXMLFileDialog.InitialDirectory = @"E:\temp";
            openXMLFileDialog.FileName = "";
            openXMLFileDialog.Filter = "XMLファイル(*.xml)|*.xml;|すべてのファイル(*.*)|*.*";
        }


        private void ExcelTestButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                IOExcel io = new IOExcel(textBox1.Text);
                io.ImportExcel();
            }
        }

        private void ImportXMLButton(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                IXML ioxml = new IXML(textBox2.Text);
                ioxml.XMLtoStream();
            }
        }

        private void testAsyncButton_Click(object sender, EventArgs e)
        {
            testASYNC.ThreadTest();
        }

        private void ReferenceExcelButton_Click(object sender, EventArgs e)
        {
            
            if (openExcelFileDialog.ShowDialog() ==DialogResult.OK)
            {
                textBox1.Text = openExcelFileDialog.FileName;
            }
        }

        private void ReferenceXMLButton_Click(object sender, EventArgs e)
        {
            if(openXMLFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openXMLFileDialog.FileName;
            }
        }
    }
}
