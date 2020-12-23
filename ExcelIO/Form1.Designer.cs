namespace ExcelIO
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ExcelTestButton = new System.Windows.Forms.Button();
            this.ImportXML = new System.Windows.Forms.Button();
            this.testAsyncButton = new System.Windows.Forms.Button();
            this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReferenceExcelButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ReferenceXMLButton = new System.Windows.Forms.Button();
            this.openXMLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ExcelTestButton
            // 
            this.ExcelTestButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExcelTestButton.Location = new System.Drawing.Point(548, 12);
            this.ExcelTestButton.Name = "ExcelTestButton";
            this.ExcelTestButton.Size = new System.Drawing.Size(105, 44);
            this.ExcelTestButton.TabIndex = 0;
            this.ExcelTestButton.Text = "ExcelTest";
            this.ExcelTestButton.UseVisualStyleBackColor = true;
            this.ExcelTestButton.Click += new System.EventHandler(this.ExcelTestButton_Click);
            // 
            // ImportXML
            // 
            this.ImportXML.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ImportXML.Location = new System.Drawing.Point(548, 81);
            this.ImportXML.Name = "ImportXML";
            this.ImportXML.Size = new System.Drawing.Size(124, 44);
            this.ImportXML.TabIndex = 1;
            this.ImportXML.Text = "ImportXML";
            this.ImportXML.UseVisualStyleBackColor = true;
            this.ImportXML.Click += new System.EventHandler(this.ImportXMLButton);
            // 
            // testAsyncButton
            // 
            this.testAsyncButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.testAsyncButton.Location = new System.Drawing.Point(548, 183);
            this.testAsyncButton.Name = "testAsyncButton";
            this.testAsyncButton.Size = new System.Drawing.Size(157, 44);
            this.testAsyncButton.TabIndex = 2;
            this.testAsyncButton.Text = "非同期スレッドテスト";
            this.testAsyncButton.UseVisualStyleBackColor = true;
            this.testAsyncButton.Click += new System.EventHandler(this.testAsyncButton_Click);
            // 
            // openExcelFileDialog
            // 
            this.openExcelFileDialog.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 19);
            this.textBox1.TabIndex = 3;
            // 
            // ReferenceExcelButton
            // 
            this.ReferenceExcelButton.Location = new System.Drawing.Point(391, 28);
            this.ReferenceExcelButton.Name = "ReferenceExcelButton";
            this.ReferenceExcelButton.Size = new System.Drawing.Size(75, 23);
            this.ReferenceExcelButton.TabIndex = 4;
            this.ReferenceExcelButton.Text = "参照";
            this.ReferenceExcelButton.UseVisualStyleBackColor = true;
            this.ReferenceExcelButton.Click += new System.EventHandler(this.ReferenceExcelButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 19);
            this.textBox2.TabIndex = 5;
            // 
            // ReferenceXMLButton
            // 
            this.ReferenceXMLButton.Location = new System.Drawing.Point(391, 95);
            this.ReferenceXMLButton.Name = "ReferenceXMLButton";
            this.ReferenceXMLButton.Size = new System.Drawing.Size(75, 23);
            this.ReferenceXMLButton.TabIndex = 6;
            this.ReferenceXMLButton.Text = "参照";
            this.ReferenceXMLButton.UseVisualStyleBackColor = true;
            this.ReferenceXMLButton.Click += new System.EventHandler(this.ReferenceXMLButton_Click);
            // 
            // openXMLFileDialog
            // 
            this.openXMLFileDialog.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReferenceXMLButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ReferenceExcelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.testAsyncButton);
            this.Controls.Add(this.ImportXML);
            this.Controls.Add(this.ExcelTestButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExcelTestButton;
        private System.Windows.Forms.Button ImportXML;
        private System.Windows.Forms.Button testAsyncButton;
        private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReferenceExcelButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ReferenceXMLButton;
        private System.Windows.Forms.OpenFileDialog openXMLFileDialog;
    }
}

