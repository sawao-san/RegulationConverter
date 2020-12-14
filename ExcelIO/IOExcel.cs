using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;  //https://csharp.keicode.com/topics/handling-excel-files-with-closedxml-install.php
using System.IO;


namespace regulationConverter
{
    class IOExcel
    {
        //プロパティ
        static XLWorkbook wb;
        static IXLWorksheet ws;
        static IXLCell cellA;
        static IXLCell cellB;
        
        static IXLCell cellD;
        static IXLCell cellE;
        static IXLCell cellF;
        static IXLCell pre_cellA;
        static IXLCell pre_cellB;
        static IXLCell pre_cellD;
        static IXLCell pre_cellE;
        static IXLCell Section;   //1や2などのただの数値である場合は
        static IXLCell S_Section; //(a)や
        static IXLCell S_S_Section;   //(1)など
        static IXLCell S_S_S_Section; //(i)など

        //フィールド
        private string importFilePath;

        public string ImportFilePath
        {
            set
            {
                this.importFilePath = value;
            }
            get
            {
                return this.importFilePath;
            }
        }
        

        public IOExcel(string filePath_)
        {
            this.importFilePath = filePath_;
            wb = new XLWorkbook(this.importFilePath);
        }

        /*エクセル操作を行うための関数*/
        public void ImportExcel()
        {
            //エクセルファイルを開けるかどうかのトライ
            try
            {
                ws = wb.Worksheet(1);
                int lastRow;

                //セルのの統合
                try
                {
                    lastRow = ws.LastRowUsed().RowNumber();
                    for (int i = 1; i <= lastRow; i++)
                    {
                        if (i == 1)
                        {

                        }
                        else
                        {
                            pre_cellA = ws.Cell(i - 1, 1);
                            pre_cellB = ws.Cell(i - 1, 2);
                            pre_cellD = ws.Cell(i - 1, 4);
                            pre_cellE = ws.Cell(i - 1, 5);
                        }
                        cellA = ws.Cell(i, 1);
                        cellB = ws.Cell(i, 2);
                        
                        cellD = ws.Cell(i, 4);
                        cellE = ws.Cell(i, 5);
                        cellF = ws.Cell(i, 6);


                        cellD.Value = cellA.Value.ToString();
                        cellE.Value = cellA.Value.ToString() + cellB.Value.ToString();  //cellの1列目と2列目を足し合わせる
                        if(cellA.Value.ToString() == "")
                        {
                            cellD.Value = pre_cellE.Value.ToString();
                        }
                        else
                        {
                            char[] c = cellA.Value.ToString().ToCharArray();
                            if (Char.IsNumber(c[0]))
                            {
                                cellF.Value = "〇";
                            }
                            else if (c[0] == '(')
                            {

                            }
                            else if(c[0] == ' ')
                            {
                                cellF.Value = "小小セクション";
                            }
                            
                        }

                        cellA.Value = createName(cellA.Value.ToString());

                        Console.WriteLine(cellB.Value);
                        
                    }

                    string filepath_ = createExportFilePath();
                    wb.SaveAs(filepath_);
                }
                catch (System.NullReferenceException)
                {
                    Console.WriteLine("エクセルファイル内の対象のセルに値が入力されていません");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("ファイルが見つかりません");
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("ファイルにアクセスできません。既にファイルを起動していないか確認してください");
            }
           
        }

        /*ファイル名の作成を自動で行う*/
        public static string createExportFilePath()
        {
            string folderPath = "E:\\temp\\test\\";
            string name = "test";
            string extension = ".xlsx";
            string re;

            string dir = @"E:\dir1";
            int fileCount;
            try
            {
                /*file数が0のとき、GetFile*/
                fileCount = Directory.GetFiles(dir, "*", SearchOption.TopDirectoryOnly).Length;
            }
            catch (System.IO.IOException)
            {
                fileCount = 0;
            }

            re = folderPath + name + fileCount.ToString() + extension;

            while (File.Exists(re))
            {
                fileCount++;
                re = folderPath + name + fileCount.ToString() + extension;
            }

            Console.WriteLine(re);
            return re;
        }

        /*一列目に入力するセクション名を自動で作成する*/
        public static string createName(string txt)
        {
            char[] charArray = txt.ToCharArray();


            //txtを文字列に分解して、最初の文字列で判断
            //if(Char.IsNumber(charArray[0]))
            /*---------------条件分岐----------------*/
            //数字である場合

            //(a)や（ⅰ）などの場合

            //空白の場合

            //その他の場合

            /*--------------------------------------*/

            return txt;
        }

        public static bool isSection(string txt)
        {
            if(txt == "")
            {
                return false;
            }

            char[] c = txt.ToCharArray();
            if (Char.IsNumber(c[0]))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool isS_Section(string txt)
        {
            if (txt == "")
            {
                return false;
            }

            if (txt.Contains("(a)"))
            {
                return true;
            }
            else if (txt.Contains("(b)"))
            {
                return true;
            }
            else if(txt.Contains("(c)"))
            {
                return true;
            }
            else if (txt.Contains("(d)"))
            {
                return true;
            }
            else if (txt.Contains("(e)"))
            {
                return true;
            }
            else if (txt.Contains("(f)"))
            {
                return true;
            }
            else if (txt.Contains("(g)"))
            {
                return true;
            }
            else if (txt.Contains("(h)"))
            {
                return true;
            }
            else if (txt.Contains("(i)"))
            {
                char[] c = txt.ToCharArray();
                if(c[0] == '(')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (txt.Contains("(j)"))
            {
                return true;
            }
            else if (txt.Contains("(k)"))
            {
                return true;
            }
            else if (txt.Contains("(l)"))
            {
                return true;
            }
            else if (txt.Contains("(m)"))
            {
                return true;
            }
            else if (txt.Contains("(n)"))
            {
                return true;
            }
            else if (txt.Contains("(o)"))
            {
                return true;
            }
            else if (txt.Contains("(p)"))
            {
                return true;
            }
            else if (txt.Contains("(q)"))
            {
                return true;
            }
            else if (txt.Contains("(r)"))
            {
                return true;
            }
            else if (txt.Contains("(s)"))
            {
                return true;
            }
            else if (txt.Contains("(t)"))
            {
                return true;
            }
            else if (txt.Contains("(u)"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isS_S_Sec
    }
}
