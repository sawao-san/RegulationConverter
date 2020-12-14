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
            this.SuspendLayout();
            // 
            // ExcelTestButton
            // 
            this.ExcelTestButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExcelTestButton.Location = new System.Drawing.Point(97, 67);
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
            this.ImportXML.Location = new System.Drawing.Point(316, 67);
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
            this.testAsyncButton.Location = new System.Drawing.Point(517, 67);
            this.testAsyncButton.Name = "testAsyncButton";
            this.testAsyncButton.Size = new System.Drawing.Size(157, 44);
            this.testAsyncButton.TabIndex = 2;
            this.testAsyncButton.Text = "非同期スレッドテスト";
            this.testAsyncButton.UseVisualStyleBackColor = true;
            this.testAsyncButton.Click += new System.EventHandler(this.testAsyncButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testAsyncButton);
            this.Controls.Add(this.ImportXML);
            this.Controls.Add(this.ExcelTestButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExcelTestButton;
        private System.Windows.Forms.Button ImportXML;
        private System.Windows.Forms.Button testAsyncButton;
    }
}

