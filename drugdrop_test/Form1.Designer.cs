namespace drugdrop_test
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 42);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(260, 207);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // filePathBox
            // 
            this.filePathBox.AllowDrop = true;
            this.filePathBox.Location = new System.Drawing.Point(13, 13);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(180, 19);
            this.filePathBox.TabIndex = 1;
            this.filePathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.filePathBox_DragDrop);
            this.filePathBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.filePathBox_DragEnter);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(200, 13);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(72, 23);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "リセット";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "DragAndDrop_test";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Button resetBtn;
    }
}

